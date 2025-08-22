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
    public partial class ctrlGeneratePL : UserControl
    {
        public ctrlGeneratePL()
        {
            InitializeComponent();
        }

        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProperties.Text) || string.IsNullOrWhiteSpace(txtControlName.Text) || cmbDataType.SelectedItem == null)
            {
                MessageBox.Show("Please enter Property Name, Control Name, and select a Data Type");
                return;
            }
            dgvProperties.Rows.Add(txtProperties.Text, cmbDataType.SelectedItem.ToString(), txtControlName.Text);
            txtProperties.Clear();
            txtControlName.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClassNameBL.Clear();
            txtClassNameEntity.Clear();
            txtDGVName.Clear();
            txtProperties.Clear();
            txtControlName.Clear();
            dgvProperties.Rows.Clear();
            txtGeneratedCode.Clear();
        }

        private void btnGeneratePL_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            string classBL = txtClassNameBL.Text.Trim();
            string classEntity = txtClassNameEntity.Text.Trim();
            string dgvName = txtDGVName.Text.Trim();
           
         


            sb.AppendLine($"// Generated PL Class for {classBL}");
            sb.AppendLine($"public partial class frm{classEntity} : Form");
            sb.AppendLine("{");
            sb.AppendLine($"    {classBL} bl = new {classBL}();");
            sb.AppendLine();

            foreach (DataGridViewRow row in dgvProperties.Rows)
            {
                string? propName = row.Cells[0].Value as string;
                string? controlName = row.Cells[2].Value as string  ;
                if (!string.IsNullOrEmpty(propName) && !string.IsNullOrEmpty(controlName))
                {
                    sb.AppendLine($"    private {classEntity} FillEntity()");
                    sb.AppendLine("    {");
                    sb.AppendLine($"        {classEntity} obj = new {classEntity}();");
                    foreach (DataGridViewRow r in dgvProperties.Rows)
                    {
                        string? pName = r.Cells[0].Value as string;
                        string? pType = r.Cells[1].Value as string;
                        string? cName = r.Cells[2].Value as string;
                        if (!string.IsNullOrEmpty(pName) && !string.IsNullOrEmpty(cName))
                        {
                            if (pType == "int" || pType == "decimal")
                                sb.AppendLine($"        obj.{pName} = {pType}.Parse({cName}.Text);");
                            else
                                sb.AppendLine($"        obj.{pName} = {cName}.Text;");
                        }
                    }
                    sb.AppendLine("        return obj;");
                    sb.AppendLine("    }");
                    break;
                }
            }

            sb.AppendLine();
            if (chkInsert.Checked)
            {
                sb.AppendLine("    private void InsertData()");
                sb.AppendLine("    {");
                sb.AppendLine("        bl.Insert(FillEntity());");
                sb.AppendLine("    }");
            }
            if (chkUpdate.Checked)
            {
                sb.AppendLine("    private void UpdateData()");
                sb.AppendLine("    {");
                sb.AppendLine("        bl.Update(FillEntity());");
                sb.AppendLine("    }");
            }
            if (chkDelete.Checked)
            {
                sb.AppendLine("    private void DeleteData(int id)");
                sb.AppendLine("    {");
                sb.AppendLine("        bl.Delete(id);");
                sb.AppendLine("    }");
            }
            if (chkGetAll.Checked)
            {
                sb.AppendLine("    private void LoadData()");
                sb.AppendLine("    {");
                sb.AppendLine($"        {dgvName}.DataSource = bl.GetAll();");
                sb.AppendLine("    }");
            }
            sb.AppendLine("}");

            txtGeneratedCode.Text = sb.ToString();
        }

        private void cmbDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? controlName = cmbDataType.SelectedItem?.ToString();
            txtControlName.Text = controlName ?? string.Empty;
            txtControlName.ReadOnly = true;
        }
    }
}
