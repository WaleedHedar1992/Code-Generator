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
    public partial class ctrlGenerateDALwithADO : UserControl
    {
        public ctrlGenerateDALwithADO()
        {
            InitializeComponent();
        }

        private void btnGenerateDAL_Click(object sender, EventArgs e)
        {
            string className = txtClassName.Text.Trim();
            if (string.IsNullOrEmpty(className))
            {
                MessageBox.Show("Please enter Class Name.");
                return;
            }

            // Read Properties from DataGridView
            List<(string Name, string DataType)> properties = new List<(string, string)>();
            foreach (DataGridViewRow row in dgvProperties.Rows)
            {
                if (row.IsNewRow) continue;

                bool include = false;
                if (row.Cells["IncludeInSQL"] is DataGridViewCheckBoxCell chkCell)
                {
                    include = (bool)(chkCell.Value ?? false);
                }

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
                MessageBox.Show("Please select properties to include in SQL.");
                return;
            }

            string primaryKey = properties.First().Name; // Assume first property is Primary Key
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"public class {className}DAL");
            sb.AppendLine("{");
            sb.AppendLine("    private string connectionString = \"YourConnectionString\";");
            sb.AppendLine("    public string ConnectionString");
            sb.AppendLine("    {");
            sb.AppendLine("        get { return connectionString; }");
            sb.AppendLine("        set { connectionString = value; }");
            sb.AppendLine("    }");
            sb.AppendLine();

            // INSERT
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

            // UPDATE
            if (chkUpdate.Checked)
            {
                sb.AppendLine($"    public void Update{className}({className} obj)");
                sb.AppendLine("    {");
                sb.AppendLine("        using (SqlConnection con = new SqlConnection(connectionString))");
                sb.AppendLine("        {");
                var setClauses = string.Join(", ", properties.Skip(1).Select(p => $"{p.Name} = @{p.Name}"));
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

            // DELETE
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

            // GET ALL
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

            sb.AppendLine("}"); // Close Class

            // Output Generated Code
            txtGeneratedCode.Text = sb.ToString();


        }

        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            string propertyName = txtProperties.Text.Trim();
            string? dataType = cmbDataType.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(propertyName) || string.IsNullOrEmpty(dataType))
            {
                MessageBox.Show("Please enter Property Name and select Data Type.");
                return;
            }

            dgvProperties.Rows.Add(propertyName, dataType);

            txtProperties.Clear();
            cmbDataType.SelectedIndex = -1;
        }
    }
}
