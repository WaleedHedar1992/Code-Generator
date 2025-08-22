namespace CodeGeneratore_0._1.UserControls
{
    partial class ctrlGenerateDALwithADO
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
            dgvProperties = new DataGridView();
            PropertyName = new DataGridViewTextBoxColumn();
            DataType = new DataGridViewTextBoxColumn();
            IncludeInSQL = new DataGridViewCheckBoxColumn();
            txtClassName = new TextBox();
            btnGenerateDAL = new Button();
            txtGeneratedCode = new RichTextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            chkConnection = new CheckBox();
            chkInsert = new CheckBox();
            chkDelete = new CheckBox();
            chkUpdate = new CheckBox();
            chkAdd = new CheckBox();
            chkFindWithName = new CheckBox();
            chkFindWithID = new CheckBox();
            chkGetAll = new CheckBox();
            label3 = new Label();
            cmbDataType = new ComboBox();
            label4 = new Label();
            txtProperties = new TextBox();
            btnAddProperty = new Button();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProperties).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgvProperties
            // 
            dgvProperties.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProperties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProperties.Columns.AddRange(new DataGridViewColumn[] { PropertyName, DataType, IncludeInSQL });
            dgvProperties.Location = new Point(537, 258);
            dgvProperties.Name = "dgvProperties";
            dgvProperties.Size = new Size(267, 385);
            dgvProperties.TabIndex = 37;
            // 
            // PropertyName
            // 
            PropertyName.HeaderText = "Property Name";
            PropertyName.Name = "PropertyName";
            // 
            // DataType
            // 
            DataType.HeaderText = "Data Type";
            DataType.Name = "DataType";
            // 
            // IncludeInSQL
            // 
            IncludeInSQL.HeaderText = "Include in SQL";
            IncludeInSQL.Name = "IncludeInSQL";
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(166, 88);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(192, 23);
            txtClassName.TabIndex = 31;
            // 
            // btnGenerateDAL
            // 
            btnGenerateDAL.BackColor = SystemColors.ControlLight;
            btnGenerateDAL.Location = new Point(688, 154);
            btnGenerateDAL.Name = "btnGenerateDAL";
            btnGenerateDAL.Size = new Size(115, 90);
            btnGenerateDAL.TabIndex = 30;
            btnGenerateDAL.Text = "Generate DAL";
            btnGenerateDAL.UseVisualStyleBackColor = false;
            btnGenerateDAL.Click += btnGenerateDAL_Click;
            // 
            // txtGeneratedCode
            // 
            txtGeneratedCode.BorderStyle = BorderStyle.FixedSingle;
            txtGeneratedCode.Location = new Point(40, 258);
            txtGeneratedCode.Name = "txtGeneratedCode";
            txtGeneratedCode.Size = new Size(491, 385);
            txtGeneratedCode.TabIndex = 29;
            txtGeneratedCode.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(40, 89);
            label2.Name = "label2";
            label2.Size = new Size(99, 16);
            label2.TabIndex = 28;
            label2.Text = "Class Name      :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Ink Free", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(135, 1);
            label1.Name = "label1";
            label1.Size = new Size(677, 62);
            label1.TabIndex = 27;
            label1.Text = "Generate \"DAL\" With ADO.net";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkConnection);
            groupBox1.Controls.Add(chkInsert);
            groupBox1.Controls.Add(chkDelete);
            groupBox1.Controls.Add(chkUpdate);
            groupBox1.Controls.Add(chkAdd);
            groupBox1.Controls.Add(chkFindWithName);
            groupBox1.Controls.Add(chkFindWithID);
            groupBox1.Controls.Add(chkGetAll);
            groupBox1.Location = new Point(40, 149);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(625, 94);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "Functions";
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
            chkInsert.Location = new Point(396, 22);
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
            // chkAdd
            // 
            chkAdd.AutoSize = true;
            chkAdd.Location = new Point(144, 57);
            chkAdd.Name = "chkAdd";
            chkAdd.Size = new Size(48, 19);
            chkAdd.TabIndex = 3;
            chkAdd.Text = "Add";
            chkAdd.UseVisualStyleBackColor = true;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(43, 119);
            label3.Name = "label3";
            label3.Size = new Size(97, 16);
            label3.TabIndex = 39;
            label3.Text = "DataType         :";
            // 
            // cmbDataType
            // 
            cmbDataType.FormattingEnabled = true;
            cmbDataType.Items.AddRange(new object[] { "int", "string", "float", "double", "bool", "decimal", "short", "long" });
            cmbDataType.Location = new Point(164, 119);
            cmbDataType.Name = "cmbDataType";
            cmbDataType.Size = new Size(104, 23);
            cmbDataType.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(292, 122);
            label4.Name = "label4";
            label4.Size = new Size(109, 16);
            label4.TabIndex = 41;
            label4.Text = "Properties           :";
            // 
            // txtProperties
            // 
            txtProperties.Location = new Point(425, 117);
            txtProperties.Name = "txtProperties";
            txtProperties.Size = new Size(240, 23);
            txtProperties.TabIndex = 42;
            // 
            // btnAddProperty
            // 
            btnAddProperty.BackColor = SystemColors.ControlLight;
            btnAddProperty.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddProperty.Image = Properties.Resources.Add_32;
            btnAddProperty.ImageAlign = ContentAlignment.MiddleRight;
            btnAddProperty.Location = new Point(689, 112);
            btnAddProperty.Name = "btnAddProperty";
            btnAddProperty.Size = new Size(114, 34);
            btnAddProperty.TabIndex = 43;
            btnAddProperty.Text = "Add ";
            btnAddProperty.TextAlign = ContentAlignment.MiddleLeft;
            btnAddProperty.UseVisualStyleBackColor = false;
            btnAddProperty.Click += btnAddProperty_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Generate_Code_0_1;
            pictureBox2.Location = new Point(37, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(95, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 44;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(37, 651);
            label6.Name = "label6";
            label6.Size = new Size(452, 14);
            label6.TabIndex = 60;
            label6.Text = "* To Generate DAL Functions , add the Data Types and Properties , then press add .";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(37, 671);
            label5.Name = "label5";
            label5.Size = new Size(347, 14);
            label5.TabIndex = 61;
            label5.Text = "* After Add The Parameters to DGV Choose the Function Name .";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(37, 691);
            label7.Name = "label7";
            label7.Size = new Size(561, 14);
            label7.TabIndex = 62;
            label7.Text = "* and click on the Check box inside the DGV to add the Parameters in the function , then generate DAL.";
            // 
            // ctrlGenerateDALwithADO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(btnAddProperty);
            Controls.Add(txtProperties);
            Controls.Add(label4);
            Controls.Add(cmbDataType);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(dgvProperties);
            Controls.Add(txtClassName);
            Controls.Add(btnGenerateDAL);
            Controls.Add(txtGeneratedCode);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ctrlGenerateDALwithADO";
            Size = new Size(849, 739);
            ((System.ComponentModel.ISupportInitialize)dgvProperties).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProperties;
        private TextBox txtClassName;
        private Button btnGenerateDAL;
        private RichTextBox txtGeneratedCode;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private CheckBox chkConnection;
        private CheckBox chkInsert;
        private CheckBox chkDelete;
        private CheckBox chkUpdate;
        private CheckBox chkAdd;
        private CheckBox chkFindWithName;
        private CheckBox chkFindWithID;
        private CheckBox chkGetAll;
        private DataGridViewTextBoxColumn PropertyName;
        private DataGridViewTextBoxColumn DataType;
        
        private Label label3;
        private ComboBox cmbDataType;
        private Label label4;
        private TextBox txtProperties;
        private Button btnAddProperty;
        private DataGridViewCheckBoxColumn IncludeInSQL;
        private PictureBox pictureBox2;
        private Label label6;
        private Label label5;
        private Label label7;
    }
}
