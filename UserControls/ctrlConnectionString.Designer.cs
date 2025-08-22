namespace CodeGeneratore_0._1.UserControls
{
    partial class ctrlConnectionString
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
            components = new System.ComponentModel.Container();
            btnTestConnection = new Button();
            btnGenerateConnection = new Button();
            txtGeneratedSQLCode = new RichTextBox();
            label1 = new Label();
            txtPassWord = new TextBox();
            label3 = new Label();
            txtUserName = new TextBox();
            label2 = new Label();
            label5 = new Label();
            txtDBName = new TextBox();
            txtServerName = new TextBox();
            grb = new GroupBox();
            label8 = new Label();
            chkTrustServerCertificateTrue = new CheckBox();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            cmbConnectionType = new ComboBox();
            label4 = new Label();
            label6 = new Label();
            errorProvider1 = new ErrorProvider(components);
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            grb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnTestConnection
            // 
            btnTestConnection.BackColor = SystemColors.ControlLight;
            btnTestConnection.Location = new Point(163, 396);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(238, 34);
            btnTestConnection.TabIndex = 43;
            btnTestConnection.Text = "Test Connection";
            btnTestConnection.UseVisualStyleBackColor = false;
            btnTestConnection.Click += btnTestConnection_Click;
            // 
            // btnGenerateConnection
            // 
            btnGenerateConnection.BackColor = SystemColors.ControlLight;
            btnGenerateConnection.Location = new Point(447, 396);
            btnGenerateConnection.Name = "btnGenerateConnection";
            btnGenerateConnection.Size = new Size(238, 34);
            btnGenerateConnection.TabIndex = 42;
            btnGenerateConnection.Text = "Generate Connection";
            btnGenerateConnection.UseVisualStyleBackColor = false;
            btnGenerateConnection.Click += btnGenerateConnection_Click;
            // 
            // txtGeneratedSQLCode
            // 
            txtGeneratedSQLCode.BorderStyle = BorderStyle.FixedSingle;
            txtGeneratedSQLCode.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGeneratedSQLCode.Location = new Point(43, 476);
            txtGeneratedSQLCode.Name = "txtGeneratedSQLCode";
            txtGeneratedSQLCode.Size = new Size(762, 180);
            txtGeneratedSQLCode.TabIndex = 46;
            txtGeneratedSQLCode.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Ink Free", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(172, 20);
            label1.Name = "label1";
            label1.Size = new Size(609, 62);
            label1.TabIndex = 45;
            label1.Text = "Generate Connection String";
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(521, 74);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(192, 23);
            txtPassWord.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(388, 34);
            label3.Name = "label3";
            label3.Size = new Size(100, 16);
            label3.TabIndex = 39;
            label3.Text = "User Name       :";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(521, 33);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(192, 23);
            txtUserName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(17, 31);
            label2.Name = "label2";
            label2.Size = new Size(118, 16);
            label2.TabIndex = 37;
            label2.Text = "Server Name         :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(17, 74);
            label5.Name = "label5";
            label5.Size = new Size(115, 16);
            label5.TabIndex = 29;
            label5.Text = "DB Name                :";
            // 
            // txtDBName
            // 
            txtDBName.Location = new Point(144, 75);
            txtDBName.Name = "txtDBName";
            txtDBName.Size = new Size(192, 23);
            txtDBName.TabIndex = 3;
            // 
            // txtServerName
            // 
            txtServerName.Location = new Point(144, 30);
            txtServerName.Name = "txtServerName";
            txtServerName.Size = new Size(192, 23);
            txtServerName.TabIndex = 1;
            // 
            // grb
            // 
            grb.Controls.Add(label8);
            grb.Controls.Add(txtPassWord);
            grb.Controls.Add(chkTrustServerCertificateTrue);
            grb.Controls.Add(label3);
            grb.Controls.Add(txtUserName);
            grb.Controls.Add(label2);
            grb.Controls.Add(label5);
            grb.Controls.Add(txtDBName);
            grb.Controls.Add(txtServerName);
            grb.Controls.Add(label7);
            grb.Location = new Point(29, 216);
            grb.Name = "grb";
            grb.Size = new Size(762, 148);
            grb.TabIndex = 44;
            grb.TabStop = false;
            grb.Text = "Connection Requirments";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(342, 116);
            label8.Name = "label8";
            label8.Size = new Size(369, 14);
            label8.TabIndex = 52;
            label8.Text = "* if Server need to trust Certificate or SSL Provider get error use this.";
            // 
            // chkTrustServerCertificateTrue
            // 
            chkTrustServerCertificateTrue.AutoSize = true;
            chkTrustServerCertificateTrue.Location = new Point(144, 115);
            chkTrustServerCertificateTrue.Name = "chkTrustServerCertificateTrue";
            chkTrustServerCertificateTrue.Size = new Size(178, 19);
            chkTrustServerCertificateTrue.TabIndex = 51;
            chkTrustServerCertificateTrue.Text = "TrustServerCertificate = True;";
            chkTrustServerCertificateTrue.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(388, 74);
            label7.Name = "label7";
            label7.Size = new Size(99, 16);
            label7.TabIndex = 33;
            label7.Text = "PassWord         :";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Generate_Code_0_1;
            pictureBox2.Location = new Point(67, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(99, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 48;
            pictureBox2.TabStop = false;
            // 
            // cmbConnectionType
            // 
            cmbConnectionType.DisplayMember = "0";
            cmbConnectionType.FormattingEnabled = true;
            cmbConnectionType.Items.AddRange(new object[] { "Windows Authentication", "SQL Server Authentication" });
            cmbConnectionType.Location = new Point(172, 177);
            cmbConnectionType.Name = "cmbConnectionType";
            cmbConnectionType.Size = new Size(192, 23);
            cmbConnectionType.TabIndex = 0;
            cmbConnectionType.ValueMember = "0";
            cmbConnectionType.SelectedIndexChanged += cmbConnectionType_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(43, 179);
            label4.Name = "label4";
            label4.Size = new Size(119, 16);
            label4.TabIndex = 50;
            label4.Text = "Connection Type :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.FlatStyle = FlatStyle.System;
            label6.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(173, 148);
            label6.Name = "label6";
            label6.Size = new Size(266, 14);
            label6.TabIndex = 40;
            label6.Text = "* Choose the connection type to DB or windows.";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Maroon;
            label9.Location = new Point(46, 668);
            label9.Name = "label9";
            label9.Size = new Size(263, 14);
            label9.TabIndex = 53;
            label9.Text = "* To Connect to Data base need to all of above.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.Control;
            label10.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Maroon;
            label10.Location = new Point(46, 689);
            label10.Name = "label10";
            label10.Size = new Size(426, 14);
            label10.TabIndex = 54;
            label10.Text = "* If local Server in your PC use (.), the User Name and Password for SQL Server.";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.Control;
            label11.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Maroon;
            label11.Location = new Point(46, 710);
            label11.Name = "label11";
            label11.Size = new Size(391, 14);
            label11.TabIndex = 55;
            label11.Text = "* Test The Connection To Data Base Before Generate Connection String.";
            // 
            // ctrlConnectionString
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(cmbConnectionType);
            Controls.Add(label4);
            Controls.Add(btnTestConnection);
            Controls.Add(btnGenerateConnection);
            Controls.Add(txtGeneratedSQLCode);
            Controls.Add(label1);
            Controls.Add(grb);
            Controls.Add(pictureBox2);
            Name = "ctrlConnectionString";
            Size = new Size(849, 739);
            Load += ctrlConnectionString_Load;
            grb.ResumeLayout(false);
            grb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTestConnection;
        private Button btnGenerateConnection;
        private RichTextBox txtGeneratedSQLCode;
        private Label label1;
        private TextBox txtPassWord;
        private Label label3;
        private TextBox txtUserName;
        private Label label2;
        private Label label5;
        private TextBox txtDBName;
        private TextBox txtServerName;
        private GroupBox grb;
        private Label label7;
        private PictureBox pictureBox2;
        private ComboBox cmbConnectionType;
        private Label label4;
        private Label label6;
        private ErrorProvider errorProvider1;
        private CheckBox chkTrustServerCertificateTrue;
        private Label label8;
        private Label label10;
        private Label label9;
        private Label label11;
    }
}
