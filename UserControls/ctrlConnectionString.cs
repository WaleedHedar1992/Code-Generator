
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;


namespace CodeGeneratore_0._1.UserControls
{
    public partial class ctrlConnectionString : UserControl
    {
        public ctrlConnectionString()
        {
            InitializeComponent();
        }

        string connectionString = "";
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

        private void ctrlConnectionString_Load(object sender, EventArgs e)
        {
            cmbConnectionType.SelectedIndex = 0;
        }

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
                       
                    MessageBox.Show("Connection Seccessfully ✅", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtGeneratedSQLCode.Text = connectionString;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Field To Connect ❌\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connectionString = "";
                }
            }
        }

        // the true connection string is (Server=.;Database=ContactsDB;User Id=sa;Password=sa123456;TrustServerCertificate = True;)
        private void btnGenerateConnection_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show( "Please Test Connection before print it.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                txtGeneratedSQLCode.Text = connectionString;
        }
    }
}
