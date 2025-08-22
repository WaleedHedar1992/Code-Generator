using Microsoft.Data.SqlClient;
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
    public partial class ctrlGenerateFunctionsFromDB : UserControl
    {
        public ctrlGenerateFunctionsFromDB()
        {
            InitializeComponent();
        }

        private void cmbConnectionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbConnectionType.SelectedItem?.ToString() == "Windows Authentication")
            {
                txtUserName.Enabled = false;
                txtPassWord.Enabled = false;

            }
            else
            {
                txtUserName.Enabled = true;
                txtPassWord.Enabled = true;
            }
        }

        string connectionString = "";
        private void btnTestConnection_Click(object sender, EventArgs e)
        {

            if (cmbConnectionType.SelectedItem?.ToString() == "Windows Authentication")
            {
                connectionString = $"Server={txtServerName.Text};Database={txtDBName.Text};Integrated Security=True;";
            }
            else
            {
                connectionString = $"Server={txtServerName.Text};Database={txtDBName.Text};User Id={txtUserName.Text};Password={txtPassWord.Text};";
            }

            if (chkTrustServerCertificateTrue.Checked) { connectionString += "TrustServerCertificate = True;"; }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                try
                {
                    conn.Open();

                    MessageBox.Show("تم الاتصال بنجاح ✅", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtConnectionString.Text = connectionString;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("فشل الاتصال ❌\n" + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connectionString = "";
                }
            }
        }

        private void ctrlGenerateFunctionsFromDB_Load(object sender, EventArgs e)
        {
            cmbConnectionType.SelectedIndex = 0;
            
            txtDB_Name1.Enabled = false;
            grbFunctions.Enabled = false;
            btnGenerateFunction.Enabled = false;
            btnLoadColumns.Enabled = false;
            txtGeneratedCode.Enabled = false;
            dgvDBColumns.Enabled = false;
            txtDB_Name1.Enabled = false;
            txtTableName.Enabled = false;
            txtClassName.Enabled = false;
        }

        private void txtConnectionString_TextChanged(object sender, EventArgs e)
        {
            txtConnectionString.BackColor = Color.MediumSeaGreen;
            txtConnectionString.ForeColor = Color.Black;
            grbGetConnectionString.Enabled = false;
            cmbConnectionType.SelectedIndex = 0; 
            grbFunctions.Enabled = true;
            btnGenerateFunction.Enabled = true;
            btnLoadColumns.Enabled = true;
            txtGeneratedCode.Enabled = true;
            dgvDBColumns.Enabled = true;
            btnTestConnection.Enabled = false;
            txtTableName.Enabled = true;
            txtClassName.Enabled = true;
        }

        // the true connection string is (Server=.;Database=ContactsDB;User Id=sa;Password=sa123456;TrustServerCertificate = True;)


        private void btnLoadData_Click(object sender, EventArgs e)
        {
            string tableName = txtTableName.Text.Trim();
            if (string.IsNullOrEmpty(connectionString) || string.IsNullOrEmpty(tableName))
            {
                MessageBox.Show("Please enter Connection String and Table Name.");
                return;
            }

            string query = $"SELECT * FROM {tableName}"; // Get All Data from the table

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDBColumns.DataSource = dt;

                // Add a checkbox column for selection
                if (!dgvDBColumns.Columns.Contains("Select"))
                {
                    DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                    chk.Name = "Select";
                    chk.HeaderText = "Select";
                    dgvDBColumns.Columns.Insert(0, chk);
                }
            }
        }

        private void btnGenerateFunction_Click(object sender, EventArgs e)
        {
            txtGeneratedCode.Clear();
            string tableName = txtTableName.Text.Trim();
            string className = txtClassName.Text.Trim();

            if (string.IsNullOrEmpty(className))
            {
                MessageBox.Show("Please enter Class Name.");
                return;
            }

            if (dgvDBColumns.Rows.Count == 0)
            {
                MessageBox.Show("Please load table data first.");
                return;
            }

            // Primary Key detection
            var pkColumn = dgvDBColumns.Columns
                            .Cast<DataGridViewColumn>()
                            .FirstOrDefault(c => c.HeaderText.ToLower().Contains("id"))?.Name;

            if (string.IsNullOrEmpty(pkColumn))
            {
                txtGeneratedCode.AppendText("// Error: No primary key found.\n");
                return;
            }

            // Generate functions based on checkboxes
            if (chkInsert.Checked)
                txtGeneratedCode.AppendText(GenerateInsertFunction(tableName, dgvDBColumns, className));

            if (chkUpdate.Checked)
                txtGeneratedCode.AppendText(GenerateUpdateFunctionFromData(tableName, dgvDBColumns, className));

            if (chkDelete.Checked)
                txtGeneratedCode.AppendText(GenerateDeleteFunction(tableName, dgvDBColumns, className));

            if (chkGetAll.Checked)
                txtGeneratedCode.AppendText(GenerateGetAllFunction(tableName, dgvDBColumns, className));

            if (chkFindWithID.Checked)
                txtGeneratedCode.AppendText(GenerateFindByIDFunction(tableName, dgvDBColumns, className));

            if (chkFindWithName.Checked)
                txtGeneratedCode.AppendText(GenerateFindByNameFunction(tableName, dgvDBColumns, className));

            if (chkSave.Checked)
                txtGeneratedCode.AppendText(GenerateSaveFunction(tableName, dgvDBColumns, className));
        }

        private string GenerateInsertFunction(string tableName, DataGridView dgv, string className)
        {
            var columns = dgv.Columns.Cast<DataGridViewColumn>()
                             .Select(c => c.Name)
                             .ToList();

            string func = $"public void Insert_{className}({className} obj)\n{{\n";
            func += $"    string sql = \"INSERT INTO {tableName} ({string.Join(", ", columns)}) VALUES ({string.Join(", ", columns.Select(c => "@" + c))})\";\n\n";
            func += "    using (SqlConnection conn = new SqlConnection(connectionString))\n";
            func += "    using (SqlCommand cmd = new SqlCommand(sql, conn))\n    {\n";
            foreach (var col in columns)
                func += $"        cmd.Parameters.AddWithValue(\"@{col}\", obj.{col});\n";
            func += "        conn.Open();\n";
            func += "        cmd.ExecuteNonQuery();\n";
            func += "    }\n";
            func += "}\n\n";
            return func;
        }


        private string GenerateUpdateFunctionFromData(string tableName, DataGridView dgv, string className)
        {
            var pkColumn = dgv.Columns.Cast<DataGridViewColumn>()
                            .FirstOrDefault(c => c.HeaderText.ToLower().Contains("id"))?.Name;
            if (string.IsNullOrEmpty(pkColumn))
                return "// Error: No primary key found\n";

            var columns = dgv.Columns.Cast<DataGridViewColumn>()
                            .Where(c => c.Name != "Select" && c.Name != pkColumn)
                            .Select(c => c.Name)
                            .ToList();

            string func = $"public void Update_{className}({className} obj)\n{{\n";
            func += $"    string sql = \"UPDATE {tableName} SET {string.Join(", ", columns.Select(c => c + " = @" + c))} WHERE {pkColumn} = @{pkColumn}\";\n\n";

            func += "    using (SqlConnection conn = new SqlConnection(connectionString))\n";
            func += "    using (SqlCommand cmd = new SqlCommand(sql, conn))\n    {\n";

            foreach (var col in columns)
                func += $"        cmd.Parameters.AddWithValue(\"@{col}\", obj.{col});\n";

            func += $"        cmd.Parameters.AddWithValue(\"@{pkColumn}\", obj.{pkColumn});\n\n";
            func += "        conn.Open();\n";
            func += "        cmd.ExecuteNonQuery();\n";
            func += "    }\n";
            func += "}\n\n";

            return func;
        }

        private string GenerateDeleteFunction(string tableName, DataGridView dgv, string className)
        {
            var pkColumn = dgv.Columns.Cast<DataGridViewColumn>()
                            .FirstOrDefault(c => c.HeaderText.ToLower().Contains("id"))?.Name;
            if (string.IsNullOrEmpty(pkColumn))
                return "// Error: No primary key found\n";

            string func = $"public void Delete_{className}(int {pkColumn})\n{{\n";
            func += $"    string sql = \"DELETE FROM {tableName} WHERE {pkColumn} = @{pkColumn}\";\n\n";
            func += "    using (SqlConnection conn = new SqlConnection(connectionString))\n";
            func += "    using (SqlCommand cmd = new SqlCommand(sql, conn))\n    {\n";
            func += $"        cmd.Parameters.AddWithValue(\"@{pkColumn}\", {pkColumn});\n";
            func += "        conn.Open();\n";
            func += "        cmd.ExecuteNonQuery();\n";
            func += "    }\n";
            func += "}\n\n";
            return func;
        }


        private string GenerateGetAllFunction(string tableName, DataGridView dgv, string className)
        {
            string func = $"public List<{className}> GetAll_{className}()\n{{\n";
            func += $"    List<{className}> list = new List<{className}>();\n";
            func += $"    string sql = \"SELECT * FROM {tableName}\";\n\n";
            func += "    using (SqlConnection conn = new SqlConnection(connectionString))\n";
            func += "    using (SqlCommand cmd = new SqlCommand(sql, conn))\n    {\n";
            func += "        conn.Open();\n";
            func += "        using (SqlDataReader reader = cmd.ExecuteReader())\n";
            func += "        {\n";
            func += "            while (reader.Read())\n";
            func += "            {\n";
            func += $"                {className} obj = new {className}();\n";

            // generate Assign for each column automatically
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                string colName = col.Name;
                string conversion = "ToString()"; // Default conversion
                string colType = col.ValueType != null ? col.ValueType.Name : "string";

                if (colType == "Int32" || colType == "Int16" || colType == "Int64")
                    conversion = "Convert.ToInt32(reader[\"" + colName + "\"])";
                else if (colType == "Decimal" || colType == "Double" || colType == "Single")
                    conversion = "Convert.ToDecimal(reader[\"" + colName + "\"])";
                else if (colType == "DateTime")
                    conversion = "Convert.ToDateTime(reader[\"" + colName + "\"])";
                else
                    conversion = "reader[\"" + colName + "\"].ToString()";

                func += $"                obj.{colName} = {conversion};\n";
            }

            func += "                list.Add(obj);\n";
            func += "            }\n";
            func += "        }\n";
            func += "    }\n";
            func += "    return list;\n";
            func += "}\n\n";

            return func;
        }


        private string GenerateFindByIDFunction(string tableName, DataGridView dgv, string className)
        {
            var pkColumn = dgv.Columns.Cast<DataGridViewColumn>()
                            .FirstOrDefault(c => c.HeaderText.ToLower().Contains("id"))?.Name;
            if (string.IsNullOrEmpty(pkColumn))
                return "// Error: No primary key found\n";

            string func = $"public {className} FindByID_{className}(int {pkColumn})\n{{\n";
            func += $"    {className} obj = null;\n";
            func += $"    string sql = \"SELECT * FROM {tableName} WHERE {pkColumn} = @{pkColumn}\";\n\n";

            func += "    using (SqlConnection conn = new SqlConnection(connectionString))\n";
            func += "    using (SqlCommand cmd = new SqlCommand(sql, conn))\n    {\n";
            func += $"        cmd.Parameters.AddWithValue(\"@{pkColumn}\", {pkColumn});\n";
            func += "        conn.Open();\n\n";
            func += "        using (SqlDataReader reader = cmd.ExecuteReader())\n";
            func += "        {\n";
            func += "            if (reader.Read())\n";
            func += "            {\n";
            func += $"                obj = new {className}();\n";

            // Genrerate Assign for each column automatically
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                string colName = col.Name;
                string conversion = "ToString()"; // default conversion
                string colType = col.ValueType != null ? col.ValueType.Name : "string";

                if (colType == "Int32" || colType == "Int16" || colType == "Int64")
                    conversion = "Convert.ToInt32(reader[\"" + colName + "\"])";
                else if (colType == "Decimal" || colType == "Double" || colType == "Single")
                    conversion = "Convert.ToDecimal(reader[\"" + colName + "\"])";
                else if (colType == "DateTime")
                    conversion = "Convert.ToDateTime(reader[\"" + colName + "\"])";
                else
                    conversion = "reader[\"" + colName + "\"].ToString()";

                func += $"                obj.{colName} = {conversion};\n";
            }

            func += "            }\n";
            func += "        }\n";
            func += "    }\n\n";
            func += "    return obj;\n";
            func += "}\n\n";

            return func;
        }


        private string GenerateFindByNameFunction(string tableName, DataGridView dgv, string className)
        {
            var nameColumn = dgv.Columns.Cast<DataGridViewColumn>()
                              .FirstOrDefault(c => c.HeaderText.ToLower().Contains("name"))?.Name;
            if (string.IsNullOrEmpty(nameColumn)) return "// Error: No Name column found\n";

            string func = $"public List<{className}> FindByName_{className}(string {nameColumn})\n{{\n";
            func += $"    List<{className}> list = new List<{className}>();\n";
            func += $"    string sql = \"SELECT * FROM {tableName} WHERE {nameColumn} LIKE '%' + @{nameColumn} + '%'\";\n\n";
            func += "    using (SqlConnection conn = new SqlConnection(connectionString))\n";
            func += "    using (SqlCommand cmd = new SqlCommand(sql, conn))\n";
            func += "    {\n";
            func += $"        cmd.Parameters.AddWithValue(\"@{nameColumn}\", {nameColumn});\n";
            func += "        conn.Open();\n";
            func += "        using (SqlDataReader reader = cmd.ExecuteReader())\n";
            func += "        {\n";
            func += "            while (reader.Read())\n";
            func += "            {\n";
            func += $"                {className} obj = new {className}();\n";

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                string colName = col.Name;
                string conversion = "reader[\"" + colName + "\"].ToString()";
                string colType = col.ValueType != null ? col.ValueType.Name : "string";
                if (colType == "Int32" || colType == "Int16" || colType == "Int64") conversion = $"Convert.ToInt32(reader[\"{colName}\"])";
                else if (colType == "Decimal" || colType == "Double" || colType == "Single") conversion = $"Convert.ToDecimal(reader[\"{colName}\"])";
                else if (colType == "DateTime") conversion = $"Convert.ToDateTime(reader[\"{colName}\"])";
                func += $"                obj.{colName} = {conversion};\n";
            }

            func += "                list.Add(obj);\n";
            func += "            }\n";
            func += "        }\n";
            func += "    }\n";
            func += "    return list;\n";
            func += "}\n\n";
            return func;
        }


        private string GenerateSaveFunction(string tableName, DataGridView dgv, string className)
        {
            var pkColumn = dgv.Columns.Cast<DataGridViewColumn>()
                            .FirstOrDefault(c => c.HeaderText.ToLower().Contains("id"))?.Name;
            if (string.IsNullOrEmpty(pkColumn)) return "// Error: No primary key found\n";

            string func = $"public void Save_{className}({className} obj)\n{{\n";
            func += $"    string sqlCheck = \"SELECT COUNT(1) FROM {tableName} WHERE {pkColumn} = @{pkColumn}\";\n\n";
            func += "    using (SqlConnection conn = new SqlConnection(connectionString))\n";
            func += "    using (SqlCommand cmd = new SqlCommand(sqlCheck, conn))\n";
            func += "    {\n";
            func += $"        cmd.Parameters.AddWithValue(\"@{pkColumn}\", obj.{pkColumn});\n";
            func += "        conn.Open();\n";
            func += "        int count = (int)cmd.ExecuteScalar();\n";
            func += "        if(count > 0)\n";
            func += $"            Update_{className}(obj);\n";
            func += "        else\n";
            func += $"            Insert_{className}(obj);\n";
            func += "    }\n";
            func += "}\n\n";
            return func;
        }

        private void txtDBName_TextChanged(object sender, EventArgs e)
        {
            txtDB_Name1.Text = txtDBName.Text.Trim();
        }






    }


}

