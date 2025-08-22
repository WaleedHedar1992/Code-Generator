using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGeneratore_0._1.UserControls
{
    public partial class ctrlGenerateBL : UserControl
    {
        public ctrlGenerateBL()
        {
            InitializeComponent();
        }

        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            string propName = txtProperties.Text.Trim();
            string dataType = cmbDataType.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrEmpty(propName) || string.IsNullOrEmpty(dataType))
            {
                MessageBox.Show("Please enter Property Name and select Data Type.");
                return;
            }

            dgvProperties.Rows.Add(propName, dataType, true); // Add new row with IncludeInSQL default = true
            txtProperties.Clear();
            cmbDataType.SelectedIndex = 0;
        }

        private void btnGenerateBL_Click(object sender, EventArgs e)
        {
            string className = txtClassName.Text.Trim();
            if (string.IsNullOrEmpty(className))
            {
                MessageBox.Show("Please enter Class Name.");
                return;
            }

            string primaryKey = string.Empty;
            if (dgvProperties.Rows.Count > 0 && dgvProperties.Rows[0].Cells["PropertyName"].Value != null)
            {
                var pkValue = dgvProperties.Rows[0].Cells["PropertyName"].Value;
                primaryKey = pkValue?.ToString() ?? string.Empty;
            }

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"public class {className}BL");
            sb.AppendLine("{");
            sb.AppendLine($"    private {className}DAL dal = new {className}DAL();");
            sb.AppendLine();

            // Save Function
            if (chkSave.Checked)
            {
                sb.AppendLine($"    public bool Save({className} obj)");
                sb.AppendLine("    {");
                sb.AppendLine($"        if (obj.{primaryKey} == 0)");
                sb.AppendLine("        {");
                sb.AppendLine($"            dal.Insert{className}(obj);");
                sb.AppendLine("        }");
                sb.AppendLine("        else");
                sb.AppendLine("        {");
                sb.AppendLine($"            dal.Update{className}(obj);");
                sb.AppendLine("        }");
                sb.AppendLine("        return true;");
                sb.AppendLine("    }");
                sb.AppendLine();
            }

            // Delete
            if (chkDelete.Checked)
            {
                sb.AppendLine($"    public void Delete(int id)");
                sb.AppendLine("    {");
                sb.AppendLine($"        dal.Delete{className}(id);");
                sb.AppendLine("    }");
                sb.AppendLine();
            }

            // GetAll
            if (chkGetAll.Checked)
            {
                sb.AppendLine($"    public List<{className}> GetAll()");
                sb.AppendLine("    {");
                sb.AppendLine($"        return dal.GetAll{className}s();");
                sb.AppendLine("    }");
                sb.AppendLine();
            }

            // Find With ID
            if (chkFindWithID.Checked)
            {
                sb.AppendLine($"    public {className} FindWithID(int id)");
                sb.AppendLine("    {");
                sb.AppendLine($"        return dal.FindWithID(id);");
                sb.AppendLine("    }");
                sb.AppendLine();
            }

            // Find With Name
            if (chkFindWithName.Checked)
            {
                sb.AppendLine($"    public List<{className}> FindWithName(string name)");
                sb.AppendLine("    {");
                sb.AppendLine($"        return dal.FindWithName(name);");
                sb.AppendLine("    }");
                sb.AppendLine();
            }

            // Insert Function
            if (chkInsert.Checked)
            {
                sb.AppendLine($"    public void Insert({className} obj)");
                sb.AppendLine("    {");
                sb.AppendLine($"        dal.Insert{className}(obj);");
                sb.AppendLine("    }");
                sb.AppendLine();
            }

            // Update Function
            if (chkUpdate.Checked)
            {
                sb.AppendLine($"    public void Update({className} obj)");
                sb.AppendLine("    {");
                sb.AppendLine($"        dal.Update{className}(obj);");
                sb.AppendLine("    }");
                sb.AppendLine();
            }

            sb.AppendLine("}"); // End Class

            txtGeneratedCode.Text = sb.ToString(); // Output to TextBox
        }

        private void btnGenerateDAL_Click(object sender, EventArgs e)
        {
            string className = txtClassName.Text.Trim();
            if (string.IsNullOrEmpty(className))
            {
                MessageBox.Show("Please enter Class Name.");
                return;
            }

            List<(string Name, string DataType)> properties = new List<(string, string)>();
            foreach (DataGridViewRow row in dgvProperties.Rows)
            {
                if (row.IsNewRow) continue;

                bool include = (bool)(row.Cells["IncludeInSQL"].Value ?? false);
                if (include)
                {
                    string propName = row.Cells["PropertyName"].Value?.ToString() ?? "";
                    string dataType = row.Cells["DataType"].Value?.ToString() ?? "";
                    if (!string.IsNullOrEmpty(propName))
                        properties.Add((propName, dataType));
                }
            }

            if (properties.Count == 0)
            {
                MessageBox.Show("Please add at least one property.");
                return;
            }

            string primaryKey = properties.First().Name;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"public class {className}DAL");
            sb.AppendLine("{");
            sb.AppendLine("    private string connectionString = \"YourConnectionString\";");
            sb.AppendLine();

            // INSERT Function
            if (chkInsert.Checked)
            {
                sb.AppendLine($"    public void Insert{className}({className} obj)");
                sb.AppendLine("    {");
                sb.AppendLine("        using (SqlConnection con = new SqlConnection(connectionString))");
                sb.AppendLine("        {");
                var columns = string.Join(", ", properties.Select(p => p.Name));
                var parameters = string.Join(", ", properties.Select(p => "@" + p.Name));
                sb.AppendLine($"            string query = \"INSERT INTO {className} ({columns}) VALUES ({parameters})\";");
                sb.AppendLine("            SqlCommand cmd = new SqlCommand(query, con);");
                foreach (var prop in properties)
                {
                    sb.AppendLine($"            cmd.Parameters.AddWithValue(\"@{prop.Name}\", obj.{prop.Name});");
                }
                sb.AppendLine("            con.Open();");
                sb.AppendLine("            cmd.ExecuteNonQuery();");
                sb.AppendLine("        }");
                sb.AppendLine("    }");
                sb.AppendLine();
            }

            // UPDATE Function
            if (chkUpdate.Checked)
            {
                var setClauses = string.Join(", ", properties.Skip(1).Select(p => $"{p.Name} = @{p.Name}"));
                sb.AppendLine($"    public void Update{className}({className} obj)");
                sb.AppendLine("    {");
                sb.AppendLine("        using (SqlConnection con = new SqlConnection(connectionString))");
                sb.AppendLine("        {");
                sb.AppendLine($"            string query = \"UPDATE {className} SET {setClauses} WHERE {primaryKey} = @{primaryKey}\";");
                sb.AppendLine("            SqlCommand cmd = new SqlCommand(query, con);");
                foreach (var prop in properties)
                {
                    sb.AppendLine($"            cmd.Parameters.AddWithValue(\"@{prop.Name}\", obj.{prop.Name});");
                }
                sb.AppendLine("            con.Open();");
                sb.AppendLine("            cmd.ExecuteNonQuery();");
                sb.AppendLine("        }");
                sb.AppendLine("    }");
                sb.AppendLine();
            }

            // DELETE Function
            if (chkDelete.Checked)
            {
                sb.AppendLine($"    public void Delete{className}(int id)");
                sb.AppendLine("    {");
                sb.AppendLine("        using (SqlConnection con = new SqlConnection(connectionString))");
                sb.AppendLine("        {");
                sb.AppendLine($"            string query = \"DELETE FROM {className} WHERE {primaryKey} = @id\";");
                sb.AppendLine("            SqlCommand cmd = new SqlCommand(query, con);");
                sb.AppendLine("            cmd.Parameters.AddWithValue(\"@id\", id);");
                sb.AppendLine("            con.Open();");
                sb.AppendLine("            cmd.ExecuteNonQuery();");
                sb.AppendLine("        }");
                sb.AppendLine("    }");
                sb.AppendLine();
            }

            // GET ALL Function
            if (chkGetAll.Checked)
            {
                sb.AppendLine($"    public List<{className}> GetAll{className}s()");
                sb.AppendLine("    {");
                sb.AppendLine($"        List<{className}> list = new List<{className}>();");
                sb.AppendLine("        using (SqlConnection con = new SqlConnection(connectionString))");
                sb.AppendLine("        {");
                sb.AppendLine($"            string query = \"SELECT * FROM {className}\";");
                sb.AppendLine("            SqlCommand cmd = new SqlCommand(query, con);");
                sb.AppendLine("            con.Open();");
                sb.AppendLine("            SqlDataReader reader = cmd.ExecuteReader();");
                sb.AppendLine("            while (reader.Read())");
                sb.AppendLine("            {");
                sb.AppendLine($"                {className} obj = new {className}();");
                foreach (var prop in properties)
                {
                    sb.AppendLine($"                obj.{prop.Name} = ({prop.DataType})reader[\"{prop.Name}\"];");
                }
                sb.AppendLine("                list.Add(obj);");
                sb.AppendLine("            }");
                sb.AppendLine("        }");
                sb.AppendLine("        return list;");
                sb.AppendLine("    }");
                sb.AppendLine();
            }

            // FIND WITH ID
            if (chkFindWithID.Checked)
            {
                sb.AppendLine($"    public {className} FindWithID(int id)");
                sb.AppendLine("    {");
                sb.AppendLine($"        {className} obj = null;");
                sb.AppendLine("        using (SqlConnection con = new SqlConnection(connectionString))");
                sb.AppendLine("        {");
                sb.AppendLine($"            string query = \"SELECT * FROM {className} WHERE {primaryKey} = @id\";");
                sb.AppendLine("            SqlCommand cmd = new SqlCommand(query, con);");
                sb.AppendLine("            cmd.Parameters.AddWithValue(\"@id\", id);");
                sb.AppendLine("            con.Open();");
                sb.AppendLine("            SqlDataReader reader = cmd.ExecuteReader();");
                sb.AppendLine("            if (reader.Read())");
                sb.AppendLine("            {");
                sb.AppendLine($"                obj = new {className}();");
                foreach (var prop in properties)
                {
                    sb.AppendLine($"                obj.{prop.Name} = ({prop.DataType})reader[\"{prop.Name}\"];");
                }
                sb.AppendLine("            }");
                sb.AppendLine("        }");
                sb.AppendLine("        return obj;");
                sb.AppendLine("    }");
                sb.AppendLine();
            }

            // FIND WITH NAME
            if (chkFindWithName.Checked)
            {
                sb.AppendLine($"    public List<{className}> FindWithName(string name)");
                sb.AppendLine("    {");
                sb.AppendLine($"        List<{className}> list = new List<{className}>();");
                sb.AppendLine("        using (SqlConnection con = new SqlConnection(connectionString))");
                sb.AppendLine("        {");
                sb.AppendLine($"            string query = \"SELECT * FROM {className} WHERE Name LIKE '%' + @name + '%'\";");
                sb.AppendLine("            SqlCommand cmd = new SqlCommand(query, con);");
                sb.AppendLine("            cmd.Parameters.AddWithValue(\"@name\", name);");
                sb.AppendLine("            con.Open();");
                sb.AppendLine("            SqlDataReader reader = cmd.ExecuteReader();");
                sb.AppendLine("            while (reader.Read())");
                sb.AppendLine("            {");
                sb.AppendLine($"                {className} obj = new {className}();");
                foreach (var prop in properties)
                {
                    sb.AppendLine($"                obj.{prop.Name} = ({prop.DataType})reader[\"{prop.Name}\"];");
                }
                sb.AppendLine("                list.Add(obj);");
                sb.AppendLine("            }");
                sb.AppendLine("        }");
                sb.AppendLine("        return list;");
                sb.AppendLine("    }");
                sb.AppendLine();
            }

            sb.AppendLine("}"); // End Class

            txtGeneratedCode.Text = sb.ToString(); // Output to TextBox
        }
    }
}
