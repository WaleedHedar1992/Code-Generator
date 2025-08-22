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
    public partial class ctrlGenerateBLFunctionFromSP : UserControl
    {
        public ctrlGenerateBLFunctionFromSP()
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

                    MessageBox.Show("Connection Successful! ✅", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtConnectionString.Text = connectionString;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: ❌\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connectionString = "";
                }
            }
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
                            var paramNameObj = reader["PARAMETER_NAME"];
                            dgvParameters.Rows[rowIndex].Cells["ParameterName"].Value =
                                paramNameObj?.ToString()?.Replace("@", "") ?? string.Empty;

                            // DataType (TextBox column)
                            var dataTypeObj = reader["DATA_TYPE"];
                            dgvParameters.Rows[rowIndex].Cells["DataType"].Value =
                                dataTypeObj?.ToString() ?? string.Empty;
                        }
                    }
                }
            }
        }

        private void btnGenerateFunction_Click(object sender, EventArgs e)
        {
            // check the required fields
            if (string.IsNullOrWhiteSpace(txtDALClassName.Text) ||
                string.IsNullOrWhiteSpace(txtDALFunctionName.Text) ||
                string.IsNullOrWhiteSpace(txtBLFunctionName.Text) ||
                string.IsNullOrWhiteSpace(txtStoredProcedureName.Text))
            {
                MessageBox.Show("Please fill all required text fields (DAL Class, DAL Function, BL Function, Table, Stored Procedure).");
                return;
            }

            StringBuilder sb = new StringBuilder();

            // get the parameters from the DataGridView
            List<string> functionParams = new List<string>();
            List<string> dalCallParams = new List<string>();

            foreach (DataGridViewRow row in dgvParameters.Rows)
            {
                if (row.IsNewRow) continue;

                string dataType = row.Cells["DataType"].Value?.ToString() ?? string.Empty;
                string paramName = row.Cells["ParameterName"].Value?.ToString() ?? string.Empty;
                // Fix: Safely handle possible null value for colArgName
                string argName = row.Cells["colArgName"].Value?.ToString() ?? string.Empty;
                // Fix: Safely handle possible null value for colNullable
                string isNullable = row.Cells["colNullable"].Value?.ToString() ?? "false";

                if (string.IsNullOrWhiteSpace(dataType) || string.IsNullOrWhiteSpace(paramName))
                    continue;

                string finalArgName = string.IsNullOrWhiteSpace(argName) ? paramName.Replace("@", "").ToLower() : argName;
                string csharpType = ConvertSqlToCSharp(dataType, isNullable == "true");

                functionParams.Add($"{csharpType} {finalArgName}");
                dalCallParams.Add(finalArgName);
            }


            if (functionParams.Count > 0)
            {
                // if there are parameters make the function with parameters
                sb.AppendLine($"\tpublic static void {txtBLFunctionName.Text}({string.Join(", ", functionParams)})");
                sb.AppendLine("\t{");
                sb.AppendLine($"\t\t{txtDALClassName.Text}.{txtDALFunctionName.Text}({string.Join(", ", dalCallParams)});");
                sb.AppendLine("\t}");
            }
            else
            {
                // in case there are no parameters, generate a parameterless function
                sb.AppendLine($"\tpublic static void {txtBLFunctionName.Text}()");
                sb.AppendLine("\t{");
                sb.AppendLine($"\t\t{txtDALClassName.Text}.{txtDALFunctionName.Text}();");
                sb.AppendLine("\t}");
            }

            txtGeneratedCode.Text = sb.ToString();
        }


        private string ConvertSqlToCSharp(string sqlType, bool isNullable)
        {
            string result;
            switch (sqlType.ToLower())
            {
                case "int":
                case "integer":
                    result = "int";
                    break;
                case "bigint":
                    result = "long";
                    break;
                case "smallint":
                    result = "short";
                    break;
                case "tinyint":
                    result = "byte";
                    break;
                case "bit":
                    result = "bool";
                    break;
                case "decimal":
                case "numeric":
                case "money":
                case "smallmoney":
                    result = "decimal";
                    break;
                case "float":
                    result = "double";
                    break;
                case "real":
                    result = "float";
                    break;
                case "datetime":
                case "smalldatetime":
                case "date":
                case "time":
                    result = "DateTime";
                    break;
                case "char":
                case "nchar":
                case "ntext":
                case "nvarchar":
                case "varchar":
                case "text":
                    result = "string";
                    break;
                case "uniqueidentifier":
                    result = "Guid";
                    break;
                case "binary":
                case "varbinary":
                case "image":
                    result = "byte[]";
                    break;
                default:
                    result = "object";
                    break;
            }

            if (isNullable && result != "string" && result != "byte[]" && result != "object")
                result += "?";

            return result;
        }


    }
}
