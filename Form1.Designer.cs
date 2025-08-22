namespace CodeGeneratore_0._1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            LiftPanel = new Panel();
            panel1 = new Panel();
            btnBack = new Button();
            label6 = new Label();
            groupBox4DataBase = new GroupBox();
            btnGenerateBLFunctionSP1 = new Button();
            button10 = new Button();
            btnGenerateBLF_F_DALF = new Button();
            btnGenerateFunctionsFromDB1 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            lblTime = new Label();
            lblDate = new Label();
            groupBox3IDECode = new GroupBox();
            ValidatingFunctions1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            btnGenerateDAL1 = new Button();
            btnGenerateConstructor1 = new Button();
            btnGenerateClass1 = new Button();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1IDECode = new GroupBox();
            btnValidatingFunctions = new Button();
            btnGenerateFunction = new Button();
            btnGeneratePL = new Button();
            btnGenerateBL = new Button();
            btnGenerateDAL = new Button();
            btnGenerateConstructor = new Button();
            btnGenerateClass = new Button();
            groupBox2DataBase = new GroupBox();
            btngenerateBLfunctionFromSP = new Button();
            btnGenrateFunctionFromSP = new Button();
            btnGenerateBLFunctions = new Button();
            btnGenerateFunctionsFromDB = new Button();
            btnConnection = new Button();
            btnCreateQuery = new Button();
            btnCreateDataBase = new Button();
            MainPanel = new Panel();
            btnRunUpdate = new Button();
            lblUpdateAvailable = new Label();
            lblAboutDiv = new Label();
            lblAboutProgram = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            LiftPanel.SuspendLayout();
            panel1.SuspendLayout();
            groupBox4DataBase.SuspendLayout();
            groupBox3IDECode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1IDECode.SuspendLayout();
            groupBox2DataBase.SuspendLayout();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Ink Free", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(317, 5);
            label1.Name = "label1";
            label1.Size = new Size(628, 62);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Code Generatore";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(224, 224, 224);
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Ink Free", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(29, 694);
            label2.Name = "label2";
            label2.Size = new Size(137, 16);
            label2.TabIndex = 1;
            label2.Text = "Code Generatore 0.1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(224, 224, 224);
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Ink Free", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(47, 718);
            label3.Name = "label3";
            label3.Size = new Size(88, 16);
            label3.TabIndex = 2;
            label3.Text = "First Virsion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(224, 224, 224);
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Ink Free", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(30, 670);
            label4.Name = "label4";
            label4.Size = new Size(132, 16);
            label4.TabIndex = 3;
            label4.Text = "Dev : Waleed Hedar";
            // 
            // LiftPanel
            // 
            LiftPanel.BackColor = Color.FromArgb(224, 224, 224);
            LiftPanel.Controls.Add(panel1);
            LiftPanel.Controls.Add(label5);
            LiftPanel.Controls.Add(pictureBox1);
            LiftPanel.Controls.Add(label2);
            LiftPanel.Controls.Add(label4);
            LiftPanel.Controls.Add(label3);
            LiftPanel.Dock = DockStyle.Left;
            LiftPanel.Location = new Point(0, 0);
            LiftPanel.Name = "LiftPanel";
            LiftPanel.Size = new Size(229, 739);
            LiftPanel.TabIndex = 4;
            LiftPanel.Paint += panel1_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(groupBox4DataBase);
            panel1.Controls.Add(lblTime);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(groupBox3IDECode);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 739);
            panel1.TabIndex = 8;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlLight;
            btnBack.Location = new Point(52, 621);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(91, 44);
            btnBack.TabIndex = 6;
            btnBack.Text = "<--- Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(224, 224, 224);
            label6.FlatStyle = FlatStyle.Popup;
            label6.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 0, 64);
            label6.Location = new Point(56, 78);
            label6.Name = "label6";
            label6.Size = new Size(116, 16);
            label6.TabIndex = 7;
            label6.Text = "Code {</>} Gen";
            // 
            // groupBox4DataBase
            // 
            groupBox4DataBase.Controls.Add(btnGenerateBLFunctionSP1);
            groupBox4DataBase.Controls.Add(button10);
            groupBox4DataBase.Controls.Add(btnGenerateBLF_F_DALF);
            groupBox4DataBase.Controls.Add(btnGenerateFunctionsFromDB1);
            groupBox4DataBase.Controls.Add(button13);
            groupBox4DataBase.Controls.Add(button14);
            groupBox4DataBase.Controls.Add(button15);
            groupBox4DataBase.Location = new Point(103, 130);
            groupBox4DataBase.Name = "groupBox4DataBase";
            groupBox4DataBase.Size = new Size(117, 486);
            groupBox4DataBase.TabIndex = 11;
            groupBox4DataBase.TabStop = false;
            groupBox4DataBase.Text = "Data Base Code";
            // 
            // btnGenerateBLFunctionSP1
            // 
            btnGenerateBLFunctionSP1.BackColor = SystemColors.ControlLight;
            btnGenerateBLFunctionSP1.Location = new Point(11, 432);
            btnGenerateBLFunctionSP1.Name = "btnGenerateBLFunctionSP1";
            btnGenerateBLFunctionSP1.Size = new Size(91, 44);
            btnGenerateBLFunctionSP1.TabIndex = 6;
            btnGenerateBLFunctionSP1.Text = "Generate BLF F SP";
            btnGenerateBLFunctionSP1.UseVisualStyleBackColor = false;
            btnGenerateBLFunctionSP1.Click += btngenerateBLfunctionFromSP_Click;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ControlLight;
            button10.Location = new Point(11, 366);
            button10.Name = "button10";
            button10.Size = new Size(91, 44);
            button10.TabIndex = 5;
            button10.Text = "Generate DAL F F SP";
            button10.UseVisualStyleBackColor = false;
            button10.Click += btnGenrateFunctionFromSP_Click;
            // 
            // btnGenerateBLF_F_DALF
            // 
            btnGenerateBLF_F_DALF.BackColor = SystemColors.ControlLight;
            btnGenerateBLF_F_DALF.Location = new Point(11, 300);
            btnGenerateBLF_F_DALF.Name = "btnGenerateBLF_F_DALF";
            btnGenerateBLF_F_DALF.Size = new Size(94, 44);
            btnGenerateBLF_F_DALF.TabIndex = 4;
            btnGenerateBLF_F_DALF.Text = "Generate BLF F DALF";
            btnGenerateBLF_F_DALF.UseVisualStyleBackColor = false;
            btnGenerateBLF_F_DALF.Click += btnGenerateBLFunctions_Click;
            // 
            // btnGenerateFunctionsFromDB1
            // 
            btnGenerateFunctionsFromDB1.BackColor = SystemColors.ControlLight;
            btnGenerateFunctionsFromDB1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerateFunctionsFromDB1.Location = new Point(11, 232);
            btnGenerateFunctionsFromDB1.Name = "btnGenerateFunctionsFromDB1";
            btnGenerateFunctionsFromDB1.Size = new Size(94, 60);
            btnGenerateFunctionsFromDB1.TabIndex = 3;
            btnGenerateFunctionsFromDB1.Text = "Generate Functions From DB";
            btnGenerateFunctionsFromDB1.UseVisualStyleBackColor = false;
            btnGenerateFunctionsFromDB1.Click += btnCreateFunctionsFromDB_Click;
            // 
            // button13
            // 
            button13.BackColor = SystemColors.ControlLight;
            button13.Location = new Point(11, 168);
            button13.Name = "button13";
            button13.Size = new Size(94, 44);
            button13.TabIndex = 2;
            button13.Text = "Data Base Connection";
            button13.UseVisualStyleBackColor = false;
            button13.Click += btnConnection_Click;
            // 
            // button14
            // 
            button14.BackColor = SystemColors.ControlLight;
            button14.Location = new Point(11, 102);
            button14.Name = "button14";
            button14.Size = new Size(94, 44);
            button14.TabIndex = 1;
            button14.Text = "Create Query";
            button14.UseVisualStyleBackColor = false;
            button14.Click += btnCreateQuery_Click;
            // 
            // button15
            // 
            button15.BackColor = SystemColors.ControlLight;
            button15.Location = new Point(11, 36);
            button15.Name = "button15";
            button15.Size = new Size(94, 44);
            button15.TabIndex = 0;
            button15.Text = "Create Data Base";
            button15.UseVisualStyleBackColor = false;
            button15.Click += btnCreateDataBase_Click;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.FromArgb(224, 224, 224);
            lblTime.FlatStyle = FlatStyle.Popup;
            lblTime.Font = new Font("Cambria", 8.25F, FontStyle.Bold);
            lblTime.ForeColor = Color.FromArgb(0, 0, 64);
            lblTime.Location = new Point(121, 103);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(31, 12);
            lblTime.TabIndex = 4;
            lblTime.Text = "Time";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.FromArgb(224, 224, 224);
            lblDate.FlatStyle = FlatStyle.Popup;
            lblDate.Font = new Font("Cambria", 8.25F, FontStyle.Bold);
            lblDate.ForeColor = Color.FromArgb(0, 0, 64);
            lblDate.Location = new Point(25, 103);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(29, 12);
            lblDate.TabIndex = 5;
            lblDate.Text = "Date";
            // 
            // groupBox3IDECode
            // 
            groupBox3IDECode.Controls.Add(ValidatingFunctions1);
            groupBox3IDECode.Controls.Add(button2);
            groupBox3IDECode.Controls.Add(button3);
            groupBox3IDECode.Controls.Add(button4);
            groupBox3IDECode.Controls.Add(btnGenerateDAL1);
            groupBox3IDECode.Controls.Add(btnGenerateConstructor1);
            groupBox3IDECode.Controls.Add(btnGenerateClass1);
            groupBox3IDECode.Location = new Point(13, 128);
            groupBox3IDECode.Name = "groupBox3IDECode";
            groupBox3IDECode.Size = new Size(89, 488);
            groupBox3IDECode.TabIndex = 10;
            groupBox3IDECode.TabStop = false;
            groupBox3IDECode.Text = "IDE Code";
            // 
            // ValidatingFunctions1
            // 
            ValidatingFunctions1.BackColor = SystemColors.ControlLight;
            ValidatingFunctions1.Location = new Point(-2, 433);
            ValidatingFunctions1.Name = "ValidatingFunctions1";
            ValidatingFunctions1.Size = new Size(91, 44);
            ValidatingFunctions1.TabIndex = 7;
            ValidatingFunctions1.Text = "Validating Functions";
            ValidatingFunctions1.UseVisualStyleBackColor = false;
            ValidatingFunctions1.Click += btnValidatingFunctions_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Location = new Point(-1, 367);
            button2.Name = "button2";
            button2.Size = new Size(91, 44);
            button2.TabIndex = 5;
            button2.Text = "Generate Function";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnGenerateFunction_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.Location = new Point(-1, 301);
            button3.Name = "button3";
            button3.Size = new Size(91, 44);
            button3.TabIndex = 4;
            button3.Text = "Generate PL";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnGeneratePL_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLight;
            button4.Location = new Point(-1, 235);
            button4.Name = "button4";
            button4.Size = new Size(91, 44);
            button4.TabIndex = 3;
            button4.Text = "Generate BL";
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnGenerateBL_Click;
            // 
            // btnGenerateDAL1
            // 
            btnGenerateDAL1.BackColor = SystemColors.ControlLight;
            btnGenerateDAL1.Location = new Point(-1, 169);
            btnGenerateDAL1.Name = "btnGenerateDAL1";
            btnGenerateDAL1.Size = new Size(91, 44);
            btnGenerateDAL1.TabIndex = 2;
            btnGenerateDAL1.Text = "Generate DAL";
            btnGenerateDAL1.UseVisualStyleBackColor = false;
            btnGenerateDAL1.Click += btnGenerateDAL_Click;
            // 
            // btnGenerateConstructor1
            // 
            btnGenerateConstructor1.BackColor = SystemColors.ControlLight;
            btnGenerateConstructor1.Location = new Point(-1, 103);
            btnGenerateConstructor1.Name = "btnGenerateConstructor1";
            btnGenerateConstructor1.Size = new Size(91, 44);
            btnGenerateConstructor1.TabIndex = 1;
            btnGenerateConstructor1.Text = "Generate Consructor";
            btnGenerateConstructor1.UseVisualStyleBackColor = false;
            btnGenerateConstructor1.Click += btnGenerateConstructor_Click;
            // 
            // btnGenerateClass1
            // 
            btnGenerateClass1.BackColor = SystemColors.ControlLight;
            btnGenerateClass1.Location = new Point(-1, 37);
            btnGenerateClass1.Name = "btnGenerateClass1";
            btnGenerateClass1.Size = new Size(91, 44);
            btnGenerateClass1.TabIndex = 0;
            btnGenerateClass1.Text = "Generate Class";
            btnGenerateClass1.UseVisualStyleBackColor = false;
            btnGenerateClass1.Click += btnGenerateClass_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Generate_Code_0_1;
            pictureBox2.Location = new Point(65, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(99, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(224, 224, 224);
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Ink Free", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(41, 694);
            label7.Name = "label7";
            label7.Size = new Size(118, 16);
            label7.TabIndex = 1;
            label7.Text = "Code Generatore ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(224, 224, 224);
            label8.FlatStyle = FlatStyle.Popup;
            label8.Font = new Font("Ink Free", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(0, 0, 64);
            label8.Location = new Point(32, 670);
            label8.Name = "label8";
            label8.Size = new Size(132, 16);
            label8.TabIndex = 3;
            label8.Text = "Dev : Waleed Hedar";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(224, 224, 224);
            label9.FlatStyle = FlatStyle.Popup;
            label9.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(0, 0, 64);
            label9.Location = new Point(49, 718);
            label9.Name = "label9";
            label9.Size = new Size(97, 19);
            label9.TabIndex = 2;
            label9.Text = "Version 0.0.1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(224, 224, 224);
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(50, 36);
            label5.Name = "label5";
            label5.Size = new Size(116, 16);
            label5.TabIndex = 7;
            label5.Text = "Code {</>} Gen";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 33);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // groupBox1IDECode
            // 
            groupBox1IDECode.Controls.Add(btnValidatingFunctions);
            groupBox1IDECode.Controls.Add(btnGenerateFunction);
            groupBox1IDECode.Controls.Add(btnGeneratePL);
            groupBox1IDECode.Controls.Add(btnGenerateBL);
            groupBox1IDECode.Controls.Add(btnGenerateDAL);
            groupBox1IDECode.Controls.Add(btnGenerateConstructor);
            groupBox1IDECode.Controls.Add(btnGenerateClass);
            groupBox1IDECode.Location = new Point(286, 121);
            groupBox1IDECode.Name = "groupBox1IDECode";
            groupBox1IDECode.Size = new Size(335, 510);
            groupBox1IDECode.TabIndex = 6;
            groupBox1IDECode.TabStop = false;
            groupBox1IDECode.Text = "IDE Code";
            // 
            // btnValidatingFunctions
            // 
            btnValidatingFunctions.BackColor = SystemColors.ControlLight;
            btnValidatingFunctions.Location = new Point(78, 431);
            btnValidatingFunctions.Name = "btnValidatingFunctions";
            btnValidatingFunctions.Size = new Size(179, 40);
            btnValidatingFunctions.TabIndex = 6;
            btnValidatingFunctions.Text = "Validating Functions";
            btnValidatingFunctions.UseVisualStyleBackColor = false;
            btnValidatingFunctions.Click += btnValidatingFunctions_Click;
            // 
            // btnGenerateFunction
            // 
            btnGenerateFunction.BackColor = SystemColors.ControlLight;
            btnGenerateFunction.Location = new Point(78, 367);
            btnGenerateFunction.Name = "btnGenerateFunction";
            btnGenerateFunction.Size = new Size(179, 40);
            btnGenerateFunction.TabIndex = 5;
            btnGenerateFunction.Text = "Generate Function";
            btnGenerateFunction.UseVisualStyleBackColor = false;
            btnGenerateFunction.Click += btnGenerateFunction_Click;
            // 
            // btnGeneratePL
            // 
            btnGeneratePL.BackColor = SystemColors.ControlLight;
            btnGeneratePL.Location = new Point(78, 301);
            btnGeneratePL.Name = "btnGeneratePL";
            btnGeneratePL.Size = new Size(179, 40);
            btnGeneratePL.TabIndex = 4;
            btnGeneratePL.Text = "Generate PL";
            btnGeneratePL.UseVisualStyleBackColor = false;
            btnGeneratePL.Click += btnGeneratePL_Click;
            // 
            // btnGenerateBL
            // 
            btnGenerateBL.BackColor = SystemColors.ControlLight;
            btnGenerateBL.Location = new Point(78, 235);
            btnGenerateBL.Name = "btnGenerateBL";
            btnGenerateBL.Size = new Size(179, 40);
            btnGenerateBL.TabIndex = 3;
            btnGenerateBL.Text = "Generate BL";
            btnGenerateBL.UseVisualStyleBackColor = false;
            btnGenerateBL.Click += btnGenerateBL_Click;
            // 
            // btnGenerateDAL
            // 
            btnGenerateDAL.BackColor = SystemColors.ControlLight;
            btnGenerateDAL.Location = new Point(78, 169);
            btnGenerateDAL.Name = "btnGenerateDAL";
            btnGenerateDAL.Size = new Size(179, 40);
            btnGenerateDAL.TabIndex = 2;
            btnGenerateDAL.Text = "Generate DAL";
            btnGenerateDAL.UseVisualStyleBackColor = false;
            btnGenerateDAL.Click += btnGenerateDAL_Click;
            // 
            // btnGenerateConstructor
            // 
            btnGenerateConstructor.BackColor = SystemColors.ControlLight;
            btnGenerateConstructor.Location = new Point(78, 103);
            btnGenerateConstructor.Name = "btnGenerateConstructor";
            btnGenerateConstructor.Size = new Size(179, 40);
            btnGenerateConstructor.TabIndex = 1;
            btnGenerateConstructor.Text = "Generate Consructor";
            btnGenerateConstructor.UseVisualStyleBackColor = false;
            btnGenerateConstructor.Click += btnGenerateConstructor_Click;
            // 
            // btnGenerateClass
            // 
            btnGenerateClass.BackColor = SystemColors.ControlLight;
            btnGenerateClass.Location = new Point(78, 37);
            btnGenerateClass.Name = "btnGenerateClass";
            btnGenerateClass.Size = new Size(179, 40);
            btnGenerateClass.TabIndex = 0;
            btnGenerateClass.Text = "Generate Class";
            btnGenerateClass.UseVisualStyleBackColor = false;
            btnGenerateClass.Click += btnGenerateClass_Click;
            // 
            // groupBox2DataBase
            // 
            groupBox2DataBase.Controls.Add(btngenerateBLfunctionFromSP);
            groupBox2DataBase.Controls.Add(btnGenrateFunctionFromSP);
            groupBox2DataBase.Controls.Add(btnGenerateBLFunctions);
            groupBox2DataBase.Controls.Add(btnGenerateFunctionsFromDB);
            groupBox2DataBase.Controls.Add(btnConnection);
            groupBox2DataBase.Controls.Add(btnCreateQuery);
            groupBox2DataBase.Controls.Add(btnCreateDataBase);
            groupBox2DataBase.Location = new Point(641, 121);
            groupBox2DataBase.Name = "groupBox2DataBase";
            groupBox2DataBase.Size = new Size(338, 512);
            groupBox2DataBase.TabIndex = 7;
            groupBox2DataBase.TabStop = false;
            groupBox2DataBase.Text = "Data Base Code";
            // 
            // btngenerateBLfunctionFromSP
            // 
            btngenerateBLfunctionFromSP.BackColor = SystemColors.ControlLight;
            btngenerateBLfunctionFromSP.Location = new Point(80, 433);
            btngenerateBLfunctionFromSP.Name = "btngenerateBLfunctionFromSP";
            btngenerateBLfunctionFromSP.Size = new Size(179, 40);
            btngenerateBLfunctionFromSP.TabIndex = 6;
            btngenerateBLfunctionFromSP.Text = "Generate BL Function Stored Procdure";
            btngenerateBLfunctionFromSP.UseVisualStyleBackColor = false;
            btngenerateBLfunctionFromSP.Click += btngenerateBLfunctionFromSP_Click;
            // 
            // btnGenrateFunctionFromSP
            // 
            btnGenrateFunctionFromSP.BackColor = SystemColors.ControlLight;
            btnGenrateFunctionFromSP.Location = new Point(80, 367);
            btnGenrateFunctionFromSP.Name = "btnGenrateFunctionFromSP";
            btnGenrateFunctionFromSP.Size = new Size(179, 40);
            btnGenrateFunctionFromSP.TabIndex = 5;
            btnGenrateFunctionFromSP.Text = "Generate DAL Function From Stored Procedure";
            btnGenrateFunctionFromSP.UseVisualStyleBackColor = false;
            btnGenrateFunctionFromSP.Click += btnGenrateFunctionFromSP_Click;
            // 
            // btnGenerateBLFunctions
            // 
            btnGenerateBLFunctions.BackColor = SystemColors.ControlLight;
            btnGenerateBLFunctions.Location = new Point(80, 301);
            btnGenerateBLFunctions.Name = "btnGenerateBLFunctions";
            btnGenerateBLFunctions.Size = new Size(179, 40);
            btnGenerateBLFunctions.TabIndex = 4;
            btnGenerateBLFunctions.Text = "Generate BL Functions From DAL Functions";
            btnGenerateBLFunctions.UseVisualStyleBackColor = false;
            btnGenerateBLFunctions.Click += btnGenerateBLFunctions_Click;
            // 
            // btnGenerateFunctionsFromDB
            // 
            btnGenerateFunctionsFromDB.BackColor = SystemColors.ControlLight;
            btnGenerateFunctionsFromDB.Location = new Point(80, 235);
            btnGenerateFunctionsFromDB.Name = "btnGenerateFunctionsFromDB";
            btnGenerateFunctionsFromDB.Size = new Size(179, 40);
            btnGenerateFunctionsFromDB.TabIndex = 3;
            btnGenerateFunctionsFromDB.Text = "Generate DAL Functions From DB";
            btnGenerateFunctionsFromDB.UseVisualStyleBackColor = false;
            btnGenerateFunctionsFromDB.Click += btnCreateFunctionsFromDB_Click;
            // 
            // btnConnection
            // 
            btnConnection.BackColor = SystemColors.ControlLight;
            btnConnection.Location = new Point(80, 169);
            btnConnection.Name = "btnConnection";
            btnConnection.Size = new Size(179, 40);
            btnConnection.TabIndex = 2;
            btnConnection.Text = "Data Base Connection";
            btnConnection.UseVisualStyleBackColor = false;
            btnConnection.Click += btnConnection_Click;
            // 
            // btnCreateQuery
            // 
            btnCreateQuery.BackColor = SystemColors.ControlLight;
            btnCreateQuery.Location = new Point(80, 103);
            btnCreateQuery.Name = "btnCreateQuery";
            btnCreateQuery.Size = new Size(179, 40);
            btnCreateQuery.TabIndex = 1;
            btnCreateQuery.Text = "Create Query";
            btnCreateQuery.UseVisualStyleBackColor = false;
            btnCreateQuery.Click += btnCreateQuery_Click;
            // 
            // btnCreateDataBase
            // 
            btnCreateDataBase.BackColor = SystemColors.ControlLight;
            btnCreateDataBase.Location = new Point(80, 37);
            btnCreateDataBase.Name = "btnCreateDataBase";
            btnCreateDataBase.Size = new Size(179, 40);
            btnCreateDataBase.TabIndex = 0;
            btnCreateDataBase.Text = "Create Data Base";
            btnCreateDataBase.UseVisualStyleBackColor = false;
            btnCreateDataBase.Click += btnCreateDataBase_Click;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(btnRunUpdate);
            MainPanel.Controls.Add(lblUpdateAvailable);
            MainPanel.Controls.Add(lblAboutDiv);
            MainPanel.Controls.Add(lblAboutProgram);
            MainPanel.Location = new Point(231, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(849, 739);
            MainPanel.TabIndex = 9;
            // 
            // btnRunUpdate
            // 
            btnRunUpdate.BackColor = SystemColors.ControlLight;
            btnRunUpdate.Location = new Point(667, 69);
            btnRunUpdate.Name = "btnRunUpdate";
            btnRunUpdate.Size = new Size(81, 23);
            btnRunUpdate.TabIndex = 7;
            btnRunUpdate.Text = "Update !";
            btnRunUpdate.UseVisualStyleBackColor = false;
            btnRunUpdate.Click += btnRunUpdate_Click;
            // 
            // lblUpdateAvailable
            // 
            lblUpdateAvailable.BackColor = SystemColors.Control;
            lblUpdateAvailable.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUpdateAvailable.ForeColor = Color.Red;
            lblUpdateAvailable.Location = new Point(561, 73);
            lblUpdateAvailable.Name = "lblUpdateAvailable";
            lblUpdateAvailable.Size = new Size(111, 16);
            lblUpdateAvailable.TabIndex = 83;
            lblUpdateAvailable.Text = "Update Available!";
            lblUpdateAvailable.UseWaitCursor = true;
            // 
            // lblAboutDiv
            // 
            lblAboutDiv.BackColor = SystemColors.Control;
            lblAboutDiv.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAboutDiv.ForeColor = Color.Black;
            lblAboutDiv.Location = new Point(41, 721);
            lblAboutDiv.Name = "lblAboutDiv";
            lblAboutDiv.Size = new Size(555, 18);
            lblAboutDiv.TabIndex = 81;
            lblAboutDiv.Text = "* Code generator Created by Developer Waleed Hedar , to Contact me >> Whedar8@gmail.com , 00201123779491";
            lblAboutDiv.UseWaitCursor = true;
            // 
            // lblAboutProgram
            // 
            lblAboutProgram.BackColor = SystemColors.Control;
            lblAboutProgram.Font = new Font("Ink Free", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAboutProgram.ForeColor = Color.Maroon;
            lblAboutProgram.Location = new Point(36, 667);
            lblAboutProgram.Name = "lblAboutProgram";
            lblAboutProgram.Size = new Size(744, 51);
            lblAboutProgram.TabIndex = 82;
            lblAboutProgram.Text = "* This Programe will give you a template function not final Functions , You can modify the code as needed for your project.";
            lblAboutProgram.UseWaitCursor = true;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 739);
            Controls.Add(groupBox2DataBase);
            Controls.Add(groupBox1IDECode);
            Controls.Add(LiftPanel);
            Controls.Add(label1);
            Controls.Add(MainPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Code Generatore 0.1";
            Load += MainForm_Load;
            LiftPanel.ResumeLayout(false);
            LiftPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox4DataBase.ResumeLayout(false);
            groupBox3IDECode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1IDECode.ResumeLayout(false);
            groupBox2DataBase.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel LiftPanel;
        private Label lblTime;
        private Label lblDate;
        private PictureBox pictureBox1;
        private Label label5;
        private GroupBox groupBox1IDECode;
        private Button btnGenerateClass;
        private Button btnValidatingFunctions;
        private Button btnGenerateFunction;
        private Button btnGeneratePL;
        private Button btnGenerateBL;
        private Button btnGenerateDAL;
        private Button btnGenerateConstructor;
        private GroupBox groupBox2DataBase;
        private Button btngenerateBLfunctionFromSP;
        private Button btnGenrateFunctionFromSP;
        private Button btnGenerateBLFunctions;
        private Button btnGenerateFunctionsFromDB;
        private Button btnConnection;
        private Button btnCreateQuery;
        private Button btnCreateDataBase;
        private Panel MainPanel;
        private Panel panel1;
        private GroupBox groupBox4DataBase;
        private Button btnGenerateBLFunctionSP1;
        private Button button10;
        private Button btnGenerateBLF_F_DALF;
        private Button btnGenerateFunctionsFromDB1;
        private Button button13;
        private Button button14;
        private Button button15;
        private GroupBox groupBox3IDECode;
        private Button btnBack;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btnGenerateDAL1;
        private Button btnGenerateConstructor1;
        private Button btnGenerateClass1;
        private Label label6;
        private PictureBox pictureBox2;
        private Label label7;
        private Label label8;
        private Label label9;
        private System.Windows.Forms.Timer timer1;
        private Button ValidatingFunctions1;
        private Label lblAboutDiv;
        private Label lblAboutProgram;
        private Label lblUpdateAvailable;
        private Button btnRunUpdate;
    }
}
