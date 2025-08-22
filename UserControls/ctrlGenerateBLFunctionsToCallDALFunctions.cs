using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CodeGeneratore_0._1.UserControls.ctrlGenerateBLFunctionsToCallDALFunctions;

namespace CodeGeneratore_0._1.UserControls
{
    public partial class ctrlGenerateBLFunctionsToCallDALFunctions : UserControl
    {
        public ctrlGenerateBLFunctionsToCallDALFunctions()
        {
            InitializeComponent();
        }

        // Insert a parameter to the DataGridView
        private void btnAddParameter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtParameterName.Text) || string.IsNullOrWhiteSpace(txtDataType.Text))
            {
                ValidateTextBoxesAddParameters();

                return;
            }

            dgvParameters.Rows.Add(txtParameterName.Text, txtDataType.Text);

            txtParameterName.Clear();
            txtDataType.Clear();
            txtDataType.Focus();
        }

        // Insert the error messages to the error provider
        private bool ValidateTextBoxesFunctions()
        {
            bool isValid = true;

            // check if any of the text boxes are empty
            if (string.IsNullOrWhiteSpace(txtBLClassName.Text))
            {
                errorProvider1.SetError(txtBLClassName, "Insert Class BL Name");
                isValid = false;
            }
            else
                errorProvider1.SetError(txtBLClassName, "");

            if (string.IsNullOrWhiteSpace(txtBLFunctionName.Text))
            {
                errorProvider1.SetError(txtBLFunctionName, "Insert BL function Name.");
                isValid = false;
            }
            else
                errorProvider1.SetError(txtBLFunctionName, "");

            if (string.IsNullOrWhiteSpace(txtDALClassName.Text))
            {
                errorProvider1.SetError(txtDALClassName, "Insert Class DAL Name.");
                isValid = false;
            }
            else
                errorProvider1.SetError(txtDALClassName, "");

            if (string.IsNullOrWhiteSpace(txtDALFunctionName.Text))
            {
                errorProvider1.SetError(txtDALFunctionName, "Insert DAL function Name.");
                isValid = false;
            }
            else
                errorProvider1.SetError(txtDALFunctionName, "");

            if (string.IsNullOrWhiteSpace(txtFunctionDataType.Text))
            {
                errorProvider1.SetError(txtFunctionDataType, "Insert function Data Type.");
                isValid = false;
            }
            else
                errorProvider1.SetError(txtDALFunctionName, "");


            return isValid;
        }

        private bool ValidateTextBoxesAddParameters()
        {
            bool isValid = true;


            if (string.IsNullOrWhiteSpace(txtDataType.Text))
            {
                errorProvider1.SetError(txtDataType, "Insert Data Type Name.");
                isValid = false;
            }
            else
                errorProvider1.SetError(txtDataType, "");

            if (string.IsNullOrWhiteSpace(txtParameterName.Text))
            {
                errorProvider1.SetError(txtParameterName, "Insert Data Type Name.");
                isValid = false;
            }
            else
                errorProvider1.SetError(txtParameterName, "");


            return isValid;
        }


        // insert BL Function and DAL Function
        private void btnAddFunction_Click(object sender, EventArgs e)
        {
            // check if any of the text boxes are empty
            if (string.IsNullOrWhiteSpace(txtBLClassName.Text) ||
                string.IsNullOrWhiteSpace(txtBLFunctionName.Text) ||
                string.IsNullOrWhiteSpace(txtDALClassName.Text) ||
                string.IsNullOrWhiteSpace(txtDALFunctionName.Text))
            {
                ValidateTextBoxesFunctions();
                return;
            }

            // colloect parameters from dgvParameters
            var paramList = new StringBuilder();
            foreach (DataGridViewRow row in dgvParameters.Rows)
            {
                if (row.IsNewRow) continue;
                paramList.Append($"{row.Cells["DataType"].Value} {row.Cells["PropertyName"].Value}, ");
            }
            if (paramList.Length > 0)
                paramList.Length -= 2; // clear the last comma and space

            // add the function to the dgvFunctions
            dgvFunctions.Rows.Add(
                txtBLClassName.Text,
                txtBLFunctionName.Text,
                txtDALClassName.Text,
                txtDALFunctionName.Text,
                paramList.ToString()
            );

            // clear the text boxes
            dgvParameters.Rows.Clear();
            txtBLFunctionName.Clear();
            txtDALFunctionName.Clear();
        }


        // Generate the final code.
        private void btnGenerateCode_Click(object sender, EventArgs e)
        {
            // functions without parameters
            if (!string.IsNullOrWhiteSpace(txtDALClassName.Text) &&
                !string.IsNullOrWhiteSpace(txtDALFunctionName.Text) &&
                !string.IsNullOrWhiteSpace(txtBLFunctionName.Text) &&
                !string.IsNullOrWhiteSpace(txtFunctionDataType.Text) &&
                (dgvFunctions.Rows.Count == 0 || dgvFunctions.Rows.Cast<DataGridViewRow>().All(r => r.IsNewRow)))
            {
                StringBuilder stringBuilder = new StringBuilder();

                stringBuilder.AppendLine($"public static {txtFunctionDataType.Text} {txtBLFunctionName.Text}()");
                stringBuilder.AppendLine("{");
                stringBuilder.AppendLine($"\t{txtDALClassName.Text} dal = new {txtDALClassName.Text}();");
                stringBuilder.AppendLine($"\tdal.{txtDALFunctionName.Text}();");
                stringBuilder.AppendLine("}");

                txtGeneratedCode.Text = stringBuilder.ToString();
                return;
            }

            // functions with parameters
            if (dgvFunctions.Rows.Count == 0 || dgvFunctions.Rows.Cast<DataGridViewRow>().All(r => r.IsNewRow))
            {
                MessageBox.Show("There is no Functions to Generate.");
                return;
            }

            StringBuilder sb = new StringBuilder();

            foreach (DataGridViewRow row in dgvFunctions.Rows)
            {
                if (row.IsNewRow) continue;

                string funcType = string.IsNullOrWhiteSpace(txtFunctionDataType.Text) ? "void" : txtFunctionDataType.Text;
                string blFunc = row.Cells["colBLFunction"].Value?.ToString() ?? string.Empty;
                string dalClass = row.Cells["colDALClass"].Value?.ToString() ?? string.Empty;
                string dalFunc = row.Cells["colDALFunction"].Value?.ToString() ?? string.Empty;
                string parameters = row.Cells["colParameters"].Value?.ToString() ?? "";
                string paramNames = GetParameterNames(parameters);

                sb.AppendLine($"public static {funcType} {blFunc}({parameters})");
                sb.AppendLine("{");
                sb.AppendLine($"\t{dalClass} dal = new {dalClass}();");
                sb.AppendLine($"\tdal.{dalFunc}({paramNames});");
                sb.AppendLine("}");
                sb.AppendLine();
            }

            txtGeneratedCode.Text = sb.ToString();
        }


       





        // get the parameter names from the parameters string
        private string GetParameterNames(string parameters)
        {
            if (string.IsNullOrWhiteSpace(parameters))
                return "";

            //declare a string array to hold the parameter names
            var parts = parameters.Split(',');
            for (int i = 0; i < parts.Length; i++)
            {
                var p = parts[i].Trim().Split(' ');
                if (p.Length > 1)
                    parts[i] = p[1]; //data type is at index 0, name is at index 1
            }
            return string.Join(", ", parts);
        }


       



    }
}
