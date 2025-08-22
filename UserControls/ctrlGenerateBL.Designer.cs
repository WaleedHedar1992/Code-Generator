namespace CodeGeneratore_0._1.UserControls
{
    partial class ctrlGenerateBL
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
            btnAddProperty = new Button();
            txtProperties = new TextBox();
            label4 = new Label();
            cmbDataType = new ComboBox();
            label3 = new Label();
            chkConnection = new CheckBox();
            groupBox1 = new GroupBox();
            chkInsert = new CheckBox();
            chkDelete = new CheckBox();
            chkUpdate = new CheckBox();
            chkSave = new CheckBox();
            chkFindWithName = new CheckBox();
            chkFindWithID = new CheckBox();
            chkGetAll = new CheckBox();
            label1 = new Label();
            txtClassName = new TextBox();
            btnGenerateBL = new Button();
            txtGeneratedCode = new RichTextBox();
            IncludeInSQL = new DataGridViewCheckBoxColumn();
            DataType = new DataGridViewTextBoxColumn();
            PropertyName = new DataGridViewTextBoxColumn();
            dgvProperties = new DataGridView();
            label2 = new Label();
            btnGenerateDAL = new Button();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnAddProperty
            // 
            btnAddProperty.BackColor = SystemColors.ControlLight;
            btnAddProperty.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddProperty.Image = Properties.Resources.Add_32;
            btnAddProperty.ImageAlign = ContentAlignment.MiddleRight;
            btnAddProperty.Location = new Point(678, 112);
            btnAddProperty.Name = "btnAddProperty";
            btnAddProperty.Size = new Size(114, 34);
            btnAddProperty.TabIndex = 55;
            btnAddProperty.Text = "Add ";
            btnAddProperty.TextAlign = ContentAlignment.MiddleLeft;
            btnAddProperty.UseVisualStyleBackColor = false;
            btnAddProperty.Click += btnAddProperty_Click;
            // 
            // txtProperties
            // 
            txtProperties.Location = new Point(414, 117);
            txtProperties.Name = "txtProperties";
            txtProperties.Size = new Size(240, 23);
            txtProperties.TabIndex = 54;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(281, 122);
            label4.Name = "label4";
            label4.Size = new Size(109, 16);
            label4.TabIndex = 53;
            label4.Text = "Properties           :";
            // 
            // cmbDataType
            // 
            cmbDataType.FormattingEnabled = true;
            cmbDataType.Items.AddRange(new object[] { "int", "string", "float", "double", "bool", "decimal", "short", "long" });
            cmbDataType.Location = new Point(153, 119);
            cmbDataType.Name = "cmbDataType";
            cmbDataType.Size = new Size(104, 23);
            cmbDataType.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(32, 119);
            label3.Name = "label3";
            label3.Size = new Size(97, 16);
            label3.TabIndex = 51;
            label3.Text = "DataType         :";
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
            // groupBox1
            // 
            groupBox1.Controls.Add(chkConnection);
            groupBox1.Controls.Add(chkInsert);
            groupBox1.Controls.Add(chkDelete);
            groupBox1.Controls.Add(chkUpdate);
            groupBox1.Controls.Add(chkSave);
            groupBox1.Controls.Add(chkFindWithName);
            groupBox1.Controls.Add(chkFindWithID);
            groupBox1.Controls.Add(chkGetAll);
            groupBox1.Location = new Point(29, 149);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(625, 94);
            groupBox1.TabIndex = 50;
            groupBox1.TabStop = false;
            groupBox1.Text = "Functions";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Ink Free", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(142, 3);
            label1.Name = "label1";
            label1.Size = new Size(648, 62);
            label1.TabIndex = 44;
            label1.Text = "Generate \"BL\" With ADO.net";
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(155, 88);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(192, 23);
            txtClassName.TabIndex = 48;
            // 
            // btnGenerateBL
            // 
            btnGenerateBL.BackColor = SystemColors.ControlLight;
            btnGenerateBL.Location = new Point(677, 156);
            btnGenerateBL.Name = "btnGenerateBL";
            btnGenerateBL.Size = new Size(115, 42);
            btnGenerateBL.TabIndex = 47;
            btnGenerateBL.Text = "Generate BL";
            btnGenerateBL.UseVisualStyleBackColor = false;
            btnGenerateBL.Click += btnGenerateBL_Click;
            // 
            // txtGeneratedCode
            // 
            txtGeneratedCode.BorderStyle = BorderStyle.FixedSingle;
            txtGeneratedCode.Location = new Point(29, 258);
            txtGeneratedCode.Name = "txtGeneratedCode";
            txtGeneratedCode.Size = new Size(491, 385);
            txtGeneratedCode.TabIndex = 46;
            txtGeneratedCode.Text = "";
            // 
            // IncludeInSQL
            // 
            IncludeInSQL.HeaderText = "Include in SQL";
            IncludeInSQL.Name = "IncludeInSQL";
            // 
            // DataType
            // 
            DataType.HeaderText = "Data Type";
            DataType.Name = "DataType";
            // 
            // PropertyName
            // 
            PropertyName.HeaderText = "Property Name";
            PropertyName.Name = "PropertyName";
            // 
            // dgvProperties
            // 
            dgvProperties.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProperties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProperties.Columns.AddRange(new DataGridViewColumn[] { PropertyName, DataType, IncludeInSQL });
            dgvProperties.Location = new Point(526, 258);
            dgvProperties.Name = "dgvProperties";
            dgvProperties.Size = new Size(267, 385);
            dgvProperties.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(29, 89);
            label2.Name = "label2";
            label2.Size = new Size(99, 16);
            label2.TabIndex = 45;
            label2.Text = "Class Name      :";
            // 
            // btnGenerateDAL
            // 
            btnGenerateDAL.BackColor = SystemColors.ControlLight;
            btnGenerateDAL.Location = new Point(677, 201);
            btnGenerateDAL.Name = "btnGenerateDAL";
            btnGenerateDAL.Size = new Size(115, 41);
            btnGenerateDAL.TabIndex = 56;
            btnGenerateDAL.Text = "Generate DAL";
            btnGenerateDAL.UseVisualStyleBackColor = false;
            btnGenerateDAL.Click += btnGenerateDAL_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Generate_Code_0_1;
            pictureBox2.Location = new Point(58, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 57;
            pictureBox2.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Maroon;
            label9.Location = new Point(22, 659);
            label9.Name = "label9";
            label9.Size = new Size(248, 14);
            label9.TabIndex = 58;
            label9.Text = "* To create DAl Functions and BL Functions  : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(46, 677);
            label5.Name = "label5";
            label5.Size = new Size(649, 14);
            label5.TabIndex = 59;
            label5.Text = "- Add The class name , thin Data type and Properties and press add , to add the parameters inside the Data grid view .";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(46, 699);
            label6.Name = "label6";
            label6.Size = new Size(430, 14);
            label6.TabIndex = 60;
            label6.Text = "- after add all parameters inside the DGV , press Generate DAL or BL function .";
            // 
            // ctrlGenerateBL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(pictureBox2);
            Controls.Add(btnGenerateDAL);
            Controls.Add(btnAddProperty);
            Controls.Add(txtProperties);
            Controls.Add(label4);
            Controls.Add(cmbDataType);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(txtClassName);
            Controls.Add(btnGenerateBL);
            Controls.Add(txtGeneratedCode);
            Controls.Add(dgvProperties);
            Controls.Add(label2);
            Name = "ctrlGenerateBL";
            Size = new Size(849, 739);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddProperty;
        private TextBox txtProperties;
        private Label label4;
        private ComboBox cmbDataType;
        private Label label3;
        private CheckBox chkConnection;
        private GroupBox groupBox1;
        private CheckBox chkInsert;
        private CheckBox chkDelete;
        private CheckBox chkUpdate;
        private CheckBox chkSave;
        private CheckBox chkFindWithName;
        private CheckBox chkFindWithID;
        private CheckBox chkGetAll;
        private Label label1;
        private TextBox txtClassName;
        private Button btnGenerateBL;
        private RichTextBox txtGeneratedCode;
        private DataGridViewCheckBoxColumn IncludeInSQL;
        private DataGridViewTextBoxColumn DataType;
        private DataGridViewTextBoxColumn PropertyName;
        private DataGridView dgvProperties;
        private Label label2;
        private Button btnGenerateDAL;
        private PictureBox pictureBox2;
        private Label label9;
        private Label label5;
        private Label label6;
    }
}
