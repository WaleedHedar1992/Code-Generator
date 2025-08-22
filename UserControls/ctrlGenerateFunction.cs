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
    public partial class ctrlGenerateFunction : UserControl
    {
        public ctrlGenerateFunction()
        {
            InitializeComponent();
        }

        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            string PropertyName = txtProperties.Text.Trim();
            string? DataType = cmbDataType.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(DataType) || string.IsNullOrEmpty(PropertyName))
            {
                MessageBox.Show("Please inter Properties and data type.");
                return;
            }

            dgvProperties.Rows.Add(PropertyName, DataType, false);
            txtProperties.Clear();
            cmbDataType.SelectedIndex = 0;
        }

        private string GenerateFunctionParameters()
        {
            List<string> parameters = new List<string>();

            foreach (DataGridViewRow row in dgvProperties.Rows)
            {
                if (row.IsNewRow) continue;

                string propName = row.Cells["PropertyName"].Value?.ToString() ?? "";
                string dataType = row.Cells["DataType"].Value?.ToString() ?? "";
                bool isRef = (bool)(row.Cells["WithReference"].Value ?? false);

                if (!string.IsNullOrEmpty(propName) && !string.IsNullOrEmpty(dataType))
                {
                    string param = $"{(isRef ? "ref " : "")}{dataType} {propName}";
                    parameters.Add(param);
                }
            }

            return string.Join(", ", parameters);
        }

        private void btnGenerateFunction_Click(object sender, EventArgs e)
        {
            string FunctionName = txtFunctionName.Text.Trim();
            string functionType = txtFunctionType.Text.Trim();  
            string AdditionalThings = richtxtAdditionalThings.Text?.Trim() ?? string.Empty;

            if (string.IsNullOrEmpty(FunctionName))
            {
                MessageBox.Show("Please Inter Function Name.");
            }

            StringBuilder sb = new StringBuilder();

            if (chkWithParameters.Checked)
            {
                string parameter = GenerateFunctionParameters();

                sb.AppendLine($"public static {functionType} {FunctionName} ({parameter})");
                sb.AppendLine("{");
                sb.AppendLine($" {AdditionalThings}");
                sb.AppendLine("}");
            }
            else
            {
                sb.AppendLine($"public static  { functionType } { FunctionName} ()" );
                sb.AppendLine("{");
                sb.AppendLine($" {AdditionalThings}");
                sb.AppendLine("}");
            }

            txtGeneratedCode.Text = sb.ToString();
        }



        


    }
}
