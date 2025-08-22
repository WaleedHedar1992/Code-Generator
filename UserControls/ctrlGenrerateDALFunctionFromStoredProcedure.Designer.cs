namespace CodeGeneratore_0._1.UserControls
{
    partial class ctrlGenrerateDALFunctionFromStoredProcedure
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbGetConnectionString = new GroupBox();
            cmbConnectionType = new ComboBox();
            label8 = new Label();
            label5 = new Label();
            label2 = new Label();
            txtPassWord = new TextBox();
            txtConnectionString = new TextBox();
            chkTrustServerCertificateTrue = new CheckBox();
            label6 = new Label();
            txtUserName = new TextBox();
            label7 = new Label();
            label9 = new Label();
            txtDBName = new TextBox();
            txtServerName = new TextBox();
            label10 = new Label();
            label12 = new Label();
            btnGenerateFunction = new Button();
            btnTestConnection = new Button();
            txtGeneratedCode = new RichTextBox();
            txtStoredProcedureName = new TextBox();
            label11 = new Label();
            pictureBox2 = new PictureBox();
            dgvParameters = new DataGridView();
            DataType = new DataGridViewTextBoxColumn();
            ParameterName = new DataGridViewTextBoxColumn();
            colArgName = new DataGridViewTextBoxColumn();
            colNullable = new DataGridViewCheckBoxColumn();
            txtDALClassName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtReturnType = new TextBox();
            label13 = new Label();
            txtTableName = new TextBox();
            label14 = new Label();
            btnLoadParameters = new Button();
            cmbFunctionType = new ComboBox();
            label16 = new Label();
            label15 = new Label();
            label17 = new Label();
            grbGetConnectionString.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvParameters).BeginInit();
            SuspendLayout();
            // 
            // grbGetConnectionString
            // 
            grbGetConnectionString.Controls.Add(cmbConnectionType);
            grbGetConnectionString.Controls.Add(label8);
            grbGetConnectionString.Controls.Add(label5);
            grbGetConnectionString.Controls.Add(label2);
            grbGetConnectionString.Controls.Add(txtPassWord);
            grbGetConnectionString.Controls.Add(txtConnectionString);
            grbGetConnectionString.Controls.Add(chkTrustServerCertificateTrue);
            grbGetConnectionString.Controls.Add(label6);
            grbGetConnectionString.Controls.Add(txtUserName);
            grbGetConnectionString.Controls.Add(label7);
            grbGetConnectionString.Controls.Add(label9);
            grbGetConnectionString.Controls.Add(txtDBName);
            grbGetConnectionString.Controls.Add(txtServerName);
            grbGetConnectionString.Controls.Add(label10);
            grbGetConnectionString.Location = new Point(34, 78);
            grbGetConnectionString.Name = "grbGetConnectionString";
            grbGetConnectionString.Size = new Size(781, 164);
            grbGetConnectionString.TabIndex = 90;
            grbGetConnectionString.TabStop = false;
            grbGetConnectionString.Text = "Get Connection String";
            // 
            // cmbConnectionType
            // 
            cmbConnectionType.DisplayMember = "0";
            cmbConnectionType.FormattingEnabled = true;
            cmbConnectionType.Items.AddRange(new object[] { "Windows Authentication", "SQL Server Authentication" });
            cmbConnectionType.Location = new Point(147, 23);
            cmbConnectionType.Name = "cmbConnectionType";
            cmbConnectionType.Size = new Size(192, 23);
            cmbConnectionType.TabIndex = 72;
            cmbConnectionType.ValueMember = "0";
            cmbConnectionType.SelectedIndexChanged += cmbConnectionType_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.FlatStyle = FlatStyle.System;
            label8.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(434, 16);
            label8.Name = "label8";
            label8.Size = new Size(239, 14);
            label8.TabIndex = 52;
            label8.Text = "* if Server need to trust Certificate use this.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(14, 27);
            label5.Name = "label5";
            label5.Size = new Size(119, 16);
            label5.TabIndex = 74;
            label5.Text = "Connection Type :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(11, 132);
            label2.Name = "label2";
            label2.Size = new Size(128, 16);
            label2.TabIndex = 59;
            label2.Text = "Connection String  :";
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(522, 95);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(253, 23);
            txtPassWord.TabIndex = 4;
            // 
            // txtConnectionString
            // 
            txtConnectionString.Location = new Point(144, 131);
            txtConnectionString.Name = "txtConnectionString";
            txtConnectionString.Size = new Size(631, 23);
            txtConnectionString.TabIndex = 62;
            txtConnectionString.TextChanged += txtConnectionString_TextChanged;
            // 
            // chkTrustServerCertificateTrue
            // 
            chkTrustServerCertificateTrue.AutoSize = true;
            chkTrustServerCertificateTrue.Location = new Point(415, 36);
            chkTrustServerCertificateTrue.Name = "chkTrustServerCertificateTrue";
            chkTrustServerCertificateTrue.Size = new Size(178, 19);
            chkTrustServerCertificateTrue.TabIndex = 51;
            chkTrustServerCertificateTrue.Text = "TrustServerCertificate = True;";
            chkTrustServerCertificateTrue.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.FlatStyle = FlatStyle.Popup;
            label6.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(409, 62);
            label6.Name = "label6";
            label6.Size = new Size(100, 16);
            label6.TabIndex = 39;
            label6.Text = "User Name       :";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(522, 60);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(253, 23);
            txtUserName.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(17, 62);
            label7.Name = "label7";
            label7.Size = new Size(115, 16);
            label7.TabIndex = 37;
            label7.Text = "Server Name        :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.FlatStyle = FlatStyle.Popup;
            label9.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(17, 97);
            label9.Name = "label9";
            label9.Size = new Size(115, 16);
            label9.TabIndex = 29;
            label9.Text = "DB Name                :";
            // 
            // txtDBName
            // 
            txtDBName.Location = new Point(145, 95);
            txtDBName.Name = "txtDBName";
            txtDBName.Size = new Size(193, 23);
            txtDBName.TabIndex = 3;
            // 
            // txtServerName
            // 
            txtServerName.Location = new Point(146, 59);
            txtServerName.Name = "txtServerName";
            txtServerName.Size = new Size(193, 23);
            txtServerName.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.Control;
            label10.FlatStyle = FlatStyle.Popup;
            label10.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(410, 97);
            label10.Name = "label10";
            label10.Size = new Size(99, 16);
            label10.TabIndex = 33;
            label10.Text = "PassWord         :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.Control;
            label12.FlatStyle = FlatStyle.Popup;
            label12.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(533, 288);
            label12.Name = "label12";
            label12.Size = new Size(120, 16);
            label12.TabIndex = 92;
            label12.Text = "StoredProcName :";
            // 
            // btnGenerateFunction
            // 
            btnGenerateFunction.BackColor = SystemColors.ControlLight;
            btnGenerateFunction.Location = new Point(700, 347);
            btnGenerateFunction.Name = "btnGenerateFunction";
            btnGenerateFunction.Size = new Size(115, 41);
            btnGenerateFunction.TabIndex = 88;
            btnGenerateFunction.Text = "Generate Function";
            btnGenerateFunction.UseVisualStyleBackColor = false;
            btnGenerateFunction.Click += btnGenerateFunction_Click;
            // 
            // btnTestConnection
            // 
            btnTestConnection.BackColor = SystemColors.ControlLight;
            btnTestConnection.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTestConnection.ImageAlign = ContentAlignment.MiddleRight;
            btnTestConnection.Location = new Point(699, 243);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(114, 34);
            btnTestConnection.TabIndex = 87;
            btnTestConnection.Text = "Test Connection";
            btnTestConnection.UseVisualStyleBackColor = false;
            btnTestConnection.Click += btnTestConnection_Click;
            // 
            // txtGeneratedCode
            // 
            txtGeneratedCode.BorderStyle = BorderStyle.FixedSingle;
            txtGeneratedCode.Location = new Point(30, 403);
            txtGeneratedCode.Name = "txtGeneratedCode";
            txtGeneratedCode.Size = new Size(340, 308);
            txtGeneratedCode.TabIndex = 80;
            txtGeneratedCode.Text = "";
            // 
            // txtStoredProcedureName
            // 
            txtStoredProcedureName.Location = new Point(656, 284);
            txtStoredProcedureName.Name = "txtStoredProcedureName";
            txtStoredProcedureName.Size = new Size(127, 23);
            txtStoredProcedureName.TabIndex = 93;
            txtStoredProcedureName.Text = "sp_UpdatePerson";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.Control;
            label11.FlatStyle = FlatStyle.System;
            label11.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Maroon;
            label11.Location = new Point(36, 253);
            label11.Name = "label11";
            label11.Size = new Size(397, 14);
            label11.TabIndex = 91;
            label11.Text = "* The Following Tools For Make Functions Depend on the Data From DB.";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Generate_Code_0_1;
            pictureBox2.Location = new Point(1, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 89;
            pictureBox2.TabStop = false;
            // 
            // dgvParameters
            // 
            dgvParameters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvParameters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParameters.Columns.AddRange(new DataGridViewColumn[] { DataType, ParameterName, colArgName, colNullable });
            dgvParameters.Location = new Point(376, 403);
            dgvParameters.Name = "dgvParameters";
            dgvParameters.Size = new Size(442, 308);
            dgvParameters.TabIndex = 82;
            // 
            // DataType
            // 
            DataType.HeaderText = "Data Type";
            DataType.Name = "DataType";
            // 
            // ParameterName
            // 
            ParameterName.HeaderText = "Parameters Name";
            ParameterName.Name = "ParameterName";
            // 
            // colArgName
            // 
            colArgName.HeaderText = "Argument Name";
            colArgName.Name = "colArgName";
            colArgName.Resizable = DataGridViewTriState.True;
            colArgName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colNullable
            // 
            colNullable.HeaderText = "Nullable";
            colNullable.Name = "colNullable";
            // 
            // txtDALClassName
            // 
            txtDALClassName.Location = new Point(144, 284);
            txtDALClassName.Name = "txtDALClassName";
            txtDALClassName.Size = new Size(129, 23);
            txtDALClassName.TabIndex = 94;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(282, 288);
            label4.Name = "label4";
            label4.Size = new Size(109, 16);
            label4.TabIndex = 85;
            label4.Text = "Function Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(52, 287);
            label3.Name = "label3";
            label3.Size = new Size(90, 16);
            label3.TabIndex = 84;
            label3.Text = "Class Name   :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Ink Free", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(75, 13);
            label1.Name = "label1";
            label1.Size = new Size(773, 45);
            label1.TabIndex = 79;
            label1.Text = "Generate DAL Functions From Stored Procedure";
            // 
            // txtReturnType
            // 
            txtReturnType.Location = new Point(144, 313);
            txtReturnType.Name = "txtReturnType";
            txtReturnType.Size = new Size(129, 23);
            txtReturnType.TabIndex = 96;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.Control;
            label13.FlatStyle = FlatStyle.Popup;
            label13.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(51, 317);
            label13.Name = "label13";
            label13.Size = new Size(91, 16);
            label13.TabIndex = 95;
            label13.Text = "Return Type :";
            // 
            // txtTableName
            // 
            txtTableName.Location = new Point(392, 313);
            txtTableName.Name = "txtTableName";
            txtTableName.Size = new Size(130, 23);
            txtTableName.TabIndex = 98;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.Control;
            label14.FlatStyle = FlatStyle.Popup;
            label14.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(283, 320);
            label14.Name = "label14";
            label14.Size = new Size(108, 16);
            label14.TabIndex = 97;
            label14.Text = "Table Name        :";
            // 
            // btnLoadParameters
            // 
            btnLoadParameters.BackColor = SystemColors.ControlLight;
            btnLoadParameters.Location = new Point(571, 348);
            btnLoadParameters.Name = "btnLoadParameters";
            btnLoadParameters.Size = new Size(115, 41);
            btnLoadParameters.TabIndex = 99;
            btnLoadParameters.Text = "Load Parameters";
            btnLoadParameters.UseVisualStyleBackColor = false;
            btnLoadParameters.Click += btnLoadParameters_Click;
            // 
            // cmbFunctionType
            // 
            cmbFunctionType.DisplayMember = "0";
            cmbFunctionType.FormattingEnabled = true;
            cmbFunctionType.Items.AddRange(new object[] { "Add", "Update", "delete", "GetAll", "FindByID", "FindByName" });
            cmbFunctionType.Location = new Point(392, 284);
            cmbFunctionType.Name = "cmbFunctionType";
            cmbFunctionType.Size = new Size(130, 23);
            cmbFunctionType.TabIndex = 75;
            cmbFunctionType.ValueMember = "0";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = SystemColors.Control;
            label16.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Maroon;
            label16.Location = new Point(30, 345);
            label16.Name = "label16";
            label16.Size = new Size(332, 14);
            label16.TabIndex = 120;
            label16.Text = "* The Connection String is required before Load Parameters.";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = SystemColors.Control;
            label15.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Maroon;
            label15.Location = new Point(30, 381);
            label15.Name = "label15";
            label15.Size = new Size(417, 14);
            label15.TabIndex = 119;
            label15.Text = "* Then add DAL Class Name & Functions Names and press Generate function.";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = SystemColors.Control;
            label17.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Maroon;
            label17.Location = new Point(30, 362);
            label17.Name = "label17";
            label17.Size = new Size(464, 14);
            label17.TabIndex = 118;
            label17.Text = "* Add the stored procedure name , thin press load  Parameters to load it in the DGV.";
            // 
            // ctrlGenrerateDALFunctionFromStoredProcedure
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label17);
            Controls.Add(cmbFunctionType);
            Controls.Add(btnLoadParameters);
            Controls.Add(txtTableName);
            Controls.Add(label14);
            Controls.Add(txtReturnType);
            Controls.Add(label13);
            Controls.Add(grbGetConnectionString);
            Controls.Add(label12);
            Controls.Add(btnGenerateFunction);
            Controls.Add(btnTestConnection);
            Controls.Add(txtGeneratedCode);
            Controls.Add(txtStoredProcedureName);
            Controls.Add(label11);
            Controls.Add(pictureBox2);
            Controls.Add(dgvParameters);
            Controls.Add(txtDALClassName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "ctrlGenrerateDALFunctionFromStoredProcedure";
            Size = new Size(849, 734);
            grbGetConnectionString.ResumeLayout(false);
            grbGetConnectionString.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvParameters).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbGetConnectionString;
        private ComboBox cmbConnectionType;
        private Label label8;
        private Label label5;
        private Label label2;
        private TextBox txtPassWord;
        private TextBox txtConnectionString;
        private CheckBox chkTrustServerCertificateTrue;
        private Label label6;
        private TextBox txtUserName;
        private Label label7;
        private Label label9;
        private TextBox txtDBName;
        private TextBox txtServerName;
        private Label label10;
        private Label label12;
        private Button btnGenerateFunction;
        private Button btnTestConnection;
        private RichTextBox txtGeneratedCode;
        private TextBox txtStoredProcedureName;
        private Label label11;
        private PictureBox pictureBox2;
        private DataGridView dgvParameters;
        private TextBox txtDALClassName;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txtReturnType;
        private Label label13;
        private TextBox txtTableName;
        private Label label14;
        private Button btnLoadParameters;
        private ComboBox cmbFunctionType;
        private DataGridViewTextBoxColumn DataType;
        private DataGridViewTextBoxColumn ParameterName;
        private DataGridViewTextBoxColumn colArgName;
        private DataGridViewCheckBoxColumn colNullable;
        private Label label16;
        private Label label15;
        private Label label17;
    }
}
