using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGeneratore_0._1
{
    public partial class ctrlGenerateClass : UserControl
    {
        public ctrlGenerateClass()
        {
            InitializeComponent();
        }

        private void ctrlGenerateClass_Load(object sender, EventArgs e)
        {

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

        private void btnGenerateClass_Click(object sender, EventArgs e)
        {
            string className = txtClassName.Text.Trim();
            if (string.IsNullOrEmpty(className))
            {
                MessageBox.Show("Please enter Class Name.");
                return;
            }

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"public class {className}");
            sb.AppendLine("{");

            // generate properties
            foreach (DataGridViewRow row in dgvProperties.Rows)
            {
                if (row.IsNewRow) continue;

                string? propName = row.Cells[0].Value?.ToString();
                string? dataType = row.Cells[1].Value?.ToString();

                if (string.IsNullOrEmpty(propName) || string.IsNullOrEmpty(dataType))
                    continue;

                sb.AppendLine($"    public {dataType} {propName} {{ get; set; }}");
            }

            // generate Constructor
            if (chkGenerateConstructor.Checked)
            {
                sb.AppendLine();
                sb.AppendLine($"    public {className}()");
                sb.AppendLine("    {");
                sb.AppendLine("        // Constructor logic here");
                sb.AppendLine("    }");
            }

            // Generate ToString
            if (chkGenerateToString.Checked)
            {
                sb.AppendLine();
                sb.AppendLine("    public override string ToString()");
                sb.AppendLine("    {");
                sb.Append("        return $\"");

                foreach (DataGridViewRow row in dgvProperties.Rows)
                {
                    if (row.IsNewRow) continue;
                    string? propName = row.Cells[0].Value?.ToString();
                    if (string.IsNullOrEmpty(propName))
                        continue;
                    sb.Append($"{propName}: {{{propName}}} ");
                }

                sb.AppendLine("\";");
                sb.AppendLine("    }");
            }

            sb.AppendLine("}");

            txtGeneratedCode.Text = sb.ToString();
        }
    }
}
