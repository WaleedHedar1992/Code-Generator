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
    public partial class ctrlGenerateConstructor : UserControl
    {
        public ctrlGenerateConstructor()
        {
            InitializeComponent();
        }

        private void btnGenerateConstructor_Click(object sender, EventArgs e)
        {
            string className = txtClassName.Text.Trim();
            if (string.IsNullOrEmpty(className))
            {
                MessageBox.Show("Please enter Class Name.");
                return;
            }
            
            StringBuilder sb = new StringBuilder();

            // Genrate Default Constructor
            if (chkDefaultConstructor.Checked)
            {
                sb.AppendLine($"public {className}()");
                sb.AppendLine("{");
                sb.AppendLine("    // Default constructor logic here");
                sb.AppendLine("}");
                sb.AppendLine();
            }

            // Generate Parameterized Constructor
            if (chkConstructorWithParameters.Checked)
            {
                List<string> parameters = new List<string>();
                List<string> assignments = new List<string>();

                foreach (DataGridViewRow row in dgvProperties.Rows)
                {
                    if (row.IsNewRow) continue;

                    bool include = false;
                    if (row.Cells["IncludeInConstructor"] is DataGridViewCheckBoxCell chkCell)
                    {
                        include = (bool)(chkCell.Value ?? false);
                    }

                    if (include)
                    {
                        var propNameObj = row.Cells["PropertyName"].Value;
                        var dataTypeObj = row.Cells["DataType"].Value;

                        string? propName = propNameObj as string;
                        string? dataType = dataTypeObj as string;

                        if (!string.IsNullOrEmpty(propName) && !string.IsNullOrEmpty(dataType))
                        {
                            string paramName = char.ToLower(propName[0]) + propName.Substring(1);
                            parameters.Add($"{dataType} {paramName}");
                            assignments.Add($"    this.{propName} = {paramName};");
                        }
                    }
                }

                if (parameters.Count > 0)
                {
                    sb.AppendLine($"public {className}({string.Join(", ", parameters)})");
                    sb.AppendLine("{");
                    foreach (string assignment in assignments)
                    {
                        sb.AppendLine(assignment);
                    }
                    sb.AppendLine("}");
                }
            }

            txtGeneratedCode.Text = sb.ToString();

          
        }

        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            string propertyName = txtPropertyName.Text.Trim();
            string? dataType = cmbDataType.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(propertyName) || string.IsNullOrEmpty(dataType))
            {
                MessageBox.Show("Please enter Property Name and select Data Type.");
                return;
            }

            dgvProperties.Rows.Add(propertyName, dataType);

            txtPropertyName.Clear();
            cmbDataType.SelectedIndex = -1;
        }
    }
}
