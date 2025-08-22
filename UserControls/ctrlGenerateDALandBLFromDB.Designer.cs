namespace CodeGeneratore_0._1.UserControls
{
    partial class ctrlGenerateFunctionsFromDB
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
            pictureBox2 = new PictureBox();
            dgvDBColumns = new DataGridView();
            label2 = new Label();
            chkConnection = new CheckBox();
            chkInsert = new CheckBox();
            chkDelete = new CheckBox();
            chkUpdate = new CheckBox();
            chkSave = new CheckBox();
            chkFindWithName = new CheckBox();
            txtConnectionString = new TextBox();
            btnLoadColumns = new Button();
            txtGeneratedCode = new RichTextBox();
            chkFindWithID = new CheckBox();
            chkGetAll = new CheckBox();
            btnGenerateFunction = new Button();
            btnTestConnection = new Button();
            txtDB_Name1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            grbFunctions = new GroupBox();
            label1 = new Label();
            cmbConnectionType = new ComboBox();
            label5 = new Label();
            grbGetConnectionString = new GroupBox();
            label8 = new Label();
            txtPassWord = new TextBox();
            chkTrustServerCertificateTrue = new CheckBox();
            label6 = new Label();
            txtUserName = new TextBox();
            label7 = new Label();
            label9 = new Label();
            txtDBName = new TextBox();
            txtServerName = new TextBox();
            label10 = new Label();
            label11 = new Label();
            txtTableName = new TextBox();
            label12 = new Label();
            txtClassName = new TextBox();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDBColumns).BeginInit();
            grbFunctions.SuspendLayout();
            grbGetConnectionString.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Generate_Code_0_1;
            pictureBox2.Location = new Point(59, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 71;
            pictureBox2.TabStop = false;
            // 
            // dgvDBColumns
            // 
            dgvDBColumns.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDBColumns.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDBColumns.Location = new Point(373, 406);
            dgvDBColumns.Name = "dgvDBColumns";
            dgvDBColumns.Size = new Size(442, 308);
            dgvDBColumns.TabIndex = 63;
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
            // chkConnection
            // 
            chkConnection.AutoSize = true;
            chkConnection.Location = new Point(396, 57);
            chkConnection.Name = "chkConnection";
            chkConnection.Size = new Size(122, 19);
            chkConnection.TabIndex = 7;
            chkConnection.Text = "Connection String";
            chkConnection.UseVisualStyleBackColor = true;
            // 
            // chkInsert
            // 
            chkInsert.AutoSize = true;
            chkInsert.Location = new Point(144, 56);
            chkInsert.Name = "chkInsert";
            chkInsert.Size = new Size(79, 19);
            chkInsert.TabIndex = 6;
            chkInsert.Text = "Insert Into";
            chkInsert.UseVisualStyleBackColor = true;
            // 
            // chkDelete
            // 
            chkDelete.AutoSize = true;
            chkDelete.Location = new Point(266, 57);
            chkDelete.Name = "chkDelete";
            chkDelete.Size = new Size(59, 19);
            chkDelete.TabIndex = 5;
            chkDelete.Text = "Delete";
            chkDelete.UseVisualStyleBackColor = true;
            // 
            // chkUpdate
            // 
            chkUpdate.AutoSize = true;
            chkUpdate.Location = new Point(266, 22);
            chkUpdate.Name = "chkUpdate";
            chkUpdate.Size = new Size(64, 19);
            chkUpdate.TabIndex = 4;
            chkUpdate.Text = "Update";
            chkUpdate.UseVisualStyleBackColor = true;
            // 
            // chkSave
            // 
            chkSave.AutoSize = true;
            chkSave.Location = new Point(396, 20);
            chkSave.Name = "chkSave";
            chkSave.Size = new Size(100, 19);
            chkSave.TabIndex = 3;
            chkSave.Text = "Save Function";
            chkSave.UseVisualStyleBackColor = true;
            // 
            // chkFindWithName
            // 
            chkFindWithName.AutoSize = true;
            chkFindWithName.Location = new Point(144, 22);
            chkFindWithName.Name = "chkFindWithName";
            chkFindWithName.Size = new Size(112, 19);
            chkFindWithName.TabIndex = 2;
            chkFindWithName.Text = "Find With Name";
            chkFindWithName.UseVisualStyleBackColor = true;
            // 
            // txtConnectionString
            // 
            txtConnectionString.Location = new Point(144, 131);
            txtConnectionString.Name = "txtConnectionString";
            txtConnectionString.Size = new Size(631, 23);
            txtConnectionString.TabIndex = 62;
            txtConnectionString.TextChanged += txtConnectionString_TextChanged;
            // 
            // btnLoadColumns
            // 
            btnLoadColumns.BackColor = SystemColors.ControlLight;
            btnLoadColumns.Location = new Point(697, 302);
            btnLoadColumns.Name = "btnLoadColumns";
            btnLoadColumns.Size = new Size(115, 42);
            btnLoadColumns.TabIndex = 61;
            btnLoadColumns.Text = "Load Columns";
            btnLoadColumns.UseVisualStyleBackColor = false;
            btnLoadColumns.Click += btnLoadData_Click;
            // 
            // txtGeneratedCode
            // 
            txtGeneratedCode.BorderStyle = BorderStyle.FixedSingle;
            txtGeneratedCode.Location = new Point(27, 406);
            txtGeneratedCode.Name = "txtGeneratedCode";
            txtGeneratedCode.Size = new Size(340, 308);
            txtGeneratedCode.TabIndex = 60;
            txtGeneratedCode.Text = "";
            // 
            // chkFindWithID
            // 
            chkFindWithID.AutoSize = true;
            chkFindWithID.Location = new Point(8, 57);
            chkFindWithID.Name = "chkFindWithID";
            chkFindWithID.Size = new Size(91, 19);
            chkFindWithID.TabIndex = 1;
            chkFindWithID.Text = "Find With ID";
            chkFindWithID.UseVisualStyleBackColor = true;
            // 
            // chkGetAll
            // 
            chkGetAll.AutoSize = true;
            chkGetAll.Location = new Point(8, 22);
            chkGetAll.Name = "chkGetAll";
            chkGetAll.Size = new Size(61, 19);
            chkGetAll.TabIndex = 0;
            chkGetAll.Text = "Get All";
            chkGetAll.UseVisualStyleBackColor = true;
            // 
            // btnGenerateFunction
            // 
            btnGenerateFunction.BackColor = SystemColors.ControlLight;
            btnGenerateFunction.Location = new Point(697, 347);
            btnGenerateFunction.Name = "btnGenerateFunction";
            btnGenerateFunction.Size = new Size(115, 41);
            btnGenerateFunction.TabIndex = 70;
            btnGenerateFunction.Text = "Generate Function";
            btnGenerateFunction.UseVisualStyleBackColor = false;
            btnGenerateFunction.Click += btnGenerateFunction_Click;
            // 
            // btnTestConnection
            // 
            btnTestConnection.BackColor = SystemColors.ControlLight;
            btnTestConnection.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTestConnection.ImageAlign = ContentAlignment.MiddleRight;
            btnTestConnection.Location = new Point(698, 237);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(114, 34);
            btnTestConnection.TabIndex = 69;
            btnTestConnection.Text = "Test Connection";
            btnTestConnection.UseVisualStyleBackColor = false;
            btnTestConnection.Click += btnTestConnection_Click;
            // 
            // txtDB_Name1
            // 
            txtDB_Name1.Location = new Point(416, 274);
            txtDB_Name1.Name = "txtDB_Name1";
            txtDB_Name1.Size = new Size(125, 23);
            txtDB_Name1.TabIndex = 68;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(337, 278);
            label4.Name = "label4";
            label4.Size = new Size(76, 16);
            label4.TabIndex = 67;
            label4.Text = "DB Name   :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(49, 277);
            label3.Name = "label3";
            label3.Size = new Size(102, 16);
            label3.TabIndex = 65;
            label3.Text = "Class Name       :";
            // 
            // grbFunctions
            // 
            grbFunctions.Controls.Add(chkConnection);
            grbFunctions.Controls.Add(chkInsert);
            grbFunctions.Controls.Add(chkDelete);
            grbFunctions.Controls.Add(chkUpdate);
            grbFunctions.Controls.Add(chkSave);
            grbFunctions.Controls.Add(chkFindWithName);
            grbFunctions.Controls.Add(chkFindWithID);
            grbFunctions.Controls.Add(chkGetAll);
            grbFunctions.Location = new Point(27, 297);
            grbFunctions.Name = "grbFunctions";
            grbFunctions.Size = new Size(664, 93);
            grbFunctions.TabIndex = 64;
            grbFunctions.TabStop = false;
            grbFunctions.Text = "Functions";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Ink Free", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(143, 4);
            label1.Name = "label1";
            label1.Size = new Size(646, 62);
            label1.TabIndex = 58;
            label1.Text = "Generate Functions From DB";
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
            grbGetConnectionString.Location = new Point(31, 72);
            grbGetConnectionString.Name = "grbGetConnectionString";
            grbGetConnectionString.Size = new Size(781, 164);
            grbGetConnectionString.TabIndex = 73;
            grbGetConnectionString.TabStop = false;
            grbGetConnectionString.Text = "Get Connection String";
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
            // txtPassWord
            // 
            txtPassWord.Location = new Point(522, 95);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(253, 23);
            txtPassWord.TabIndex = 4;
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
            txtDBName.TextChanged += txtDBName_TextChanged;
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
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.Control;
            label11.FlatStyle = FlatStyle.System;
            label11.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Maroon;
            label11.Location = new Point(33, 243);
            label11.Name = "label11";
            label11.Size = new Size(397, 14);
            label11.TabIndex = 75;
            label11.Text = "* The Following Tools For Make Functions Depend on the Data From DB.";
            // 
            // txtTableName
            // 
            txtTableName.Location = new Point(653, 274);
            txtTableName.Name = "txtTableName";
            txtTableName.Size = new Size(125, 23);
            txtTableName.TabIndex = 77;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.Control;
            label12.FlatStyle = FlatStyle.Popup;
            label12.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(558, 278);
            label12.Name = "label12";
            label12.Size = new Size(93, 16);
            label12.TabIndex = 76;
            label12.Text = "Table Name   :";
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(154, 274);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(177, 23);
            txtClassName.TabIndex = 78;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.Control;
            label13.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Maroon;
            label13.Location = new Point(19, 719);
            label13.Name = "label13";
            label13.Size = new Size(764, 14);
            label13.TabIndex = 79;
            label13.Text = "* should add DB Name and Table Name, then click Load Columns to DGV . then use the function name to generate the code depend on this.";
            // 
            // ctrlGenerateFunctionsFromDB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label13);
            Controls.Add(txtClassName);
            Controls.Add(txtTableName);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(grbGetConnectionString);
            Controls.Add(pictureBox2);
            Controls.Add(dgvDBColumns);
            Controls.Add(btnLoadColumns);
            Controls.Add(txtGeneratedCode);
            Controls.Add(btnGenerateFunction);
            Controls.Add(btnTestConnection);
            Controls.Add(txtDB_Name1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(grbFunctions);
            Controls.Add(label1);
            Name = "ctrlGenerateFunctionsFromDB";
            Size = new Size(849, 739);
            Load += ctrlGenerateFunctionsFromDB_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDBColumns).EndInit();
            grbFunctions.ResumeLayout(false);
            grbFunctions.PerformLayout();
            grbGetConnectionString.ResumeLayout(false);
            grbGetConnectionString.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private DataGridView dgvDBColumns;
        private Label label2;
        private CheckBox chkConnection;
        private CheckBox chkInsert;
        private CheckBox chkDelete;
        private CheckBox chkUpdate;
        private CheckBox chkSave;
        private CheckBox chkFindWithName;
        private TextBox txtConnectionString;
        private Button btnLoadColumns;
        private RichTextBox txtGeneratedCode;
        private CheckBox chkFindWithID;
        private CheckBox chkGetAll;
        private Button btnGenerateFunction;
        private Button btnTestConnection;
        private TextBox txtDB_Name1;
        private Label label4;
        private Label label3;
        private GroupBox grbFunctions;
        private Label label1;
        private ComboBox cmbConnectionType;
        private Label label5;
        private GroupBox grbGetConnectionString;
        private Label label8;
        private TextBox txtPassWord;
        private CheckBox chkTrustServerCertificateTrue;
        private Label label6;
        private TextBox txtUserName;
        private Label label7;
        private Label label9;
        private TextBox txtDBName;
        private TextBox txtServerName;
        private Label label10;
        private Label label11;
        private TextBox txtTableName;
        private Label label12;
        private TextBox txtClassName;
        private Label label13;
    }
}
