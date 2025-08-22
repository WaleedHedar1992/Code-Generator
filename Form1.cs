using CodeGeneratore_0._1.UserControls;
using System;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace CodeGeneratore_0._1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void GetDateAndTime()
        {
            lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        // في حدث Tick الخاص بالـ Timer

        private void MainForm_Load(object sender, EventArgs e)
        {
            CheckForLocalUpdates();
            timer1.Interval = 1000; // تحدث كل ثانية
            timer1.Start();
            groupBox3IDECode.Visible = false;
            groupBox4DataBase.Visible = false;
            lblUpdateAvailable.Visible = false;
            btnRunUpdate.Visible = false;

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // this function hides all controls in the main panel
        private void HideAllInTheMain()
        {
            label1.Visible = false;
            label2.Visible = false;
            groupBox1IDECode.Visible = false;
            groupBox2DataBase.Visible = false;
            
            // LiftPanel.Visible = false;
        }

        private void LoadControl(UserControl control)
        {
            
            groupBox3IDECode.Visible = true;
            groupBox4DataBase.Visible = true;
            HideAllInTheMain();
            MainPanel.Controls.Clear();               // remove all existing controls from the MainPanel
            control.Dock = DockStyle.Fill;            // fill the MainPanel with the new control
            MainPanel.Controls.Add(control);          // add the new control to the MainPanel
        }

        private (string latestVersion, string filePath) GetLatestVersionFromLocal()
        {
            // المسار الجديد لملف JSON
            string versionFile = @"C:\Users\20112\CodeGeneratorUpdates\version.json";

            try
            {
                if (!File.Exists(versionFile))
                    return (null, null);

                string json = File.ReadAllText(versionFile);
                dynamic data = JsonConvert.DeserializeObject(json);

                string latestVersion = data.latestVersion;
                string filePath = data.filePath;

                // تأكد أن الملف التنفيذي موجود
                if (!File.Exists(filePath))
                    return (null, null);

                return (latestVersion, filePath);
            }
            catch
            {
                return (null, null);
            }
        }


        private void btnRunUpdate_Click(object sender, EventArgs e)
        {
            if (btnRunUpdate.Tag != null)
            {
                string filePath = btnRunUpdate.Tag.ToString();
                System.Diagnostics.Process.Start(filePath); // تشغيل النسخة الجديدة
                Application.Exit(); // إغلاق النسخة القديمة
            }
        }


        private void CheckForLocalUpdates()
        {
            string currentVersion = "1.1.0"; // النسخة الحالية للبرنامج
            var (latestVersion, filePath) = GetLatestVersionFromLocal();

            if (!string.IsNullOrEmpty(latestVersion))
            {
                Version current = new Version(currentVersion);
                Version latest = new Version(latestVersion);

                if (latest > current)
                {
                    // إظهار Label و Button
                    lblUpdateAvailable.Visible = true;
                    btnRunUpdate.Visible = true;

                    // يمكنك تخزين filePath في Tag الزر لاستخدامه لاحقًا
                    btnRunUpdate.Tag = filePath;
                }
            }
        }




        private void ShowMainButtons()
        {
            //MainPanel.Controls.Clear();
            //groupBox1IDECode.Visible = true;
            //groupBox2DataBase.Visible = true;

            //groupBox3IDECode.Visible = false;
            //groupBox4DataBase.Visible = false;

            //lblAboutProgram.Visible = false;
            //lblAboutDiv.Visible = false;

            //label1.Visible = true;

            if (MainPanel != null)
                MainPanel.Controls.Clear();

            if (groupBox1IDECode != null) groupBox1IDECode.Visible = true;
            if (groupBox2DataBase != null) groupBox2DataBase.Visible = true;

            if (groupBox3IDECode != null) groupBox3IDECode.Visible = false;
            if (groupBox4DataBase != null) groupBox4DataBase.Visible = false;

            if (lblAboutProgram != null) lblAboutProgram.Visible = true;
            if (lblAboutDiv != null) lblAboutDiv.Visible = true;


            if (label1 != null) label1.Visible = true;

            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowMainButtons();
        }

        private void btnGenerateConstructor_Click(object sender, EventArgs e)
        {
            LoadControl(new ctrlGenerateConstructor());
        }

        private void btnGenerateClass_Click(object sender, EventArgs e)
        {
            LoadControl(new ctrlGenerateClass());
        }



        private void btnGenerateDAL_Click(object sender, EventArgs e)
        {
            LoadControl(new ctrlGenerateDALwithADO());
        }

        private void btnGenerateBL_Click(object sender, EventArgs e)
        {
            LoadControl(new ctrlGenerateBL());
        }

        private void btnGenerateFunction_Click(object sender, EventArgs e)
        {
            LoadControl(new ctrlGenerateFunction());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetDateAndTime();
        }

        private void btnGeneratePL_Click(object sender, EventArgs e)
        {
            LoadControl(new ctrlGeneratePL());
        }

        private void btnCreateDataBase_Click(object sender, EventArgs e)
        {
            LoadControl(new ctrlCreateDataBase());
        }

        private void btnCreateQuery_Click(object sender, EventArgs e)
        {
            LoadControl(new ctrlCreateQuery());
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            LoadControl(new ctrlConnectionString());
        }

        private void btnCreateFunctionsFromDB_Click(object sender, EventArgs e)
        {
            LoadControl(new ctrlGenerateFunctionsFromDB());
        }

        private void btnGenerateBLFunctions_Click(object sender, EventArgs e)
        {
            LoadControl(new ctrlGenerateBLFunctionsToCallDALFunctions());
        }

        private void btnGenrateFunctionFromSP_Click(object sender, EventArgs e)
        {
            LoadControl(new ctrlGenrerateDALFunctionFromStoredProcedure());
        }

        private void btngenerateBLfunctionFromSP_Click(object sender, EventArgs e)
        {
            LoadControl(new ctrlGenerateBLFunctionFromSP());
        }

        private void btnValidatingFunctions_Click(object sender, EventArgs e)
        {
            LoadControl(new ctrlGenerateVlidatingFunctions());
        }
    }
}
