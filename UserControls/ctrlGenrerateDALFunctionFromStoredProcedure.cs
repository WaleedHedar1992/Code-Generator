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
    public partial class ctrlGenrerateDALFunctionFromStoredProcedure : UserControl
    {
        public ctrlGenrerateDALFunctionFromStoredProcedure()
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
            btnGenerateFunction.Enabled = false;
            txtGeneratedCode.Enabled = false;
            dgvParameters.Enabled = false;
            txtStoredProcedureName.Enabled = false;
            txtDALClassName.Enabled = false;
        }

        private void txtConnectionString_TextChanged(object sender, EventArgs e)
        {
            txtConnectionString.BackColor = Color.MediumSeaGreen;
            txtConnectionString.ForeColor = Color.Black;
            grbGetConnectionString.Enabled = false;
            cmbConnectionType.SelectedIndex = 0;
            btnGenerateFunction.Enabled = true;
            txtGeneratedCode.Enabled = true;
            dgvParameters.Enabled = true;
            btnTestConnection.Enabled = false;
            txtStoredProcedureName.Enabled = true;
            txtDALClassName.Enabled = true;
        }

        private string SqlTypeToCSharp(string sqlType)
        {
            switch (sqlType.ToLower())
            {
                case "int": return "int";
                case "bigint": return "long";
                case "decimal":
                case "money":
                case "numeric": return "decimal";
                case "float": return "double";
                case "bit": return "bool";
                case "datetime":
                case "smalldatetime": return "DateTime";
                case "nvarchar":
                case "varchar":
                case "nchar":
                case "char":
                case "text": return "string";
                default: return "object";
            }
        }


        private void btnGenerateFunction_Click(object sender, EventArgs e)
        {
            string? functionName = cmbFunctionType.SelectedItem?.ToString();
            txtGeneratedCode.Clear();

            if (string.IsNullOrWhiteSpace(functionName) ||
                string.IsNullOrWhiteSpace(txtStoredProcedureName.Text) ||
                string.IsNullOrWhiteSpace(txtConnectionString.Text))
            {
                MessageBox.Show(" Function Name, Stored Procedure Name and Connection String.");
                return;
            }

            StringBuilder sb = new StringBuilder();

            // جمع جميع المعلمات لتعريف الدالة
            List<string> funcParams = new List<string>();
            foreach (DataGridViewRow row in dgvParameters.Rows)
            {
                if (row.IsNewRow) continue;
                string? paramName = row.Cells["ParameterName"].Value?.ToString();
                string dataType = SqlTypeToCSharp(row.Cells["DataType"].Value?.ToString() ?? "string"); // type of parameter
                if (!string.IsNullOrWhiteSpace(paramName))
                {
                    funcParams.Add($"{dataType} {paramName}");
                }
            }

            string parameters = string.Join(", ", funcParams);

            // توليد تعريف الدالة مع المعلمات
            sb.AppendLine($"\tpublic static void {functionName}({parameters})");
            sb.AppendLine("\t{");

            sb.AppendLine("\t\tusing (SqlConnection conn = new SqlConnection(connectionString))");
            sb.AppendLine($"\t\tusing (SqlCommand cmd = new SqlCommand(\"{txtStoredProcedureName.Text}\", conn))");
            sb.AppendLine("\t\t{");
            sb.AppendLine("\t\t\tcmd.CommandType = CommandType.StoredProcedure;");

            // توليد Parameters داخل الـ SqlCommand
            foreach (DataGridViewRow row in dgvParameters.Rows)
            {
                if (row.IsNewRow) continue;

                string paramName = row.Cells["ParameterName"].Value?.ToString()??string.Empty;
                string argument = row.Cells["colArgName"]?.Value?.ToString()?? string.Empty;

                if (!string.IsNullOrWhiteSpace(paramName))
                {
                    if (!string.IsNullOrWhiteSpace(argument))
                    {
                        // استخدام القيمة الثابتة المدخلة
                        sb.AppendLine($"\t\t\tcmd.Parameters.AddWithValue(\"@{paramName}\", {argument});");
                    }
                    else
                    {
                        // استخدام المتغير القادم من PL/BL
                        sb.AppendLine($"\t\t\tcmd.Parameters.AddWithValue(\"@{paramName}\", {paramName});");
                    }
                }
            }

            sb.AppendLine("\t\t\tconn.Open();");
            sb.AppendLine("\t\t\tcmd.ExecuteNonQuery();");
            sb.AppendLine("\t\t}");
            sb.AppendLine("\t}");

            txtGeneratedCode.Text = sb.ToString();
        }



        private void btnLoadParameters_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConnectionString.Text) ||
                string.IsNullOrWhiteSpace(txtStoredProcedureName.Text))
            {
                MessageBox.Show("Please enter Connection String and Stored Procedure Name.");
                return;
            }

            dgvParameters.Rows.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                                SELECT PARAMETER_NAME, DATA_TYPE
                                FROM INFORMATION_SCHEMA.PARAMETERS
                                WHERE SPECIFIC_NAME = @SPName
                                ORDER BY ORDINAL_POSITION";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SPName", txtStoredProcedureName.Text.Trim());
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int rowIndex = dgvParameters.Rows.Add();

                            // ParameterName
                            dgvParameters.Rows[rowIndex].Cells["ParameterName"].Value =
                                reader["PARAMETER_NAME"].ToString().Replace("@", "");

                            // DataType (TextBox column)
                            dgvParameters.Rows[rowIndex].Cells["DataType"].Value =
                                reader["DATA_TYPE"].ToString();
                        }
                    }
                }
            }
        }


        
	




    }
}
