namespace CodeGeneratore_0._1.UserControls
{
    partial class ctrlGeneratePL
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
            dgvProperties = new DataGridView();
            PropertyName = new DataGridViewTextBoxColumn();
            DataType = new DataGridViewTextBoxColumn();
            ControlName = new DataGridViewTextBoxColumn();
            label2 = new Label();
            chkConnection = new CheckBox();
            chkInsert = new CheckBox();
            chkDelete = new CheckBox();
            chkUpdate = new CheckBox();
            chkSave = new CheckBox();
            chkFindWithName = new CheckBox();
            txtClassNameBL = new TextBox();
            btnGeneratePL = new Button();
            txtGeneratedCode = new RichTextBox();
            chkFindWithID = new CheckBox();
            chkGetAll = new CheckBox();
            btnClear = new Button();
            btnAddProperty = new Button();
            txtProperties = new TextBox();
            label4 = new Label();
            cmbDataType = new ComboBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label5 = new Label();
            txtDGVName = new TextBox();
            label6 = new Label();
            txtClassNameEntity = new TextBox();
            label7 = new Label();
            txtControlName = new TextBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProperties).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Generate_Code_0_1;
            pictureBox2.Location = new Point(216, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 71;
            pictureBox2.TabStop = false;
            // 
            // dgvProperties
            // 
            dgvProperties.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProperties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProperties.Columns.AddRange(new DataGridViewColumn[] { PropertyName, DataType, ControlName });
            dgvProperties.Location = new Point(539, 315);
            dgvProperties.Name = "dgvProperties";
            dgvProperties.Size = new Size(267, 331);
            dgvProperties.TabIndex = 63;
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
            // ControlName
            // 
            ControlName.HeaderText = "Control Name";
            ControlName.Name = "ControlName";
            ControlName.Resizable = DataGridViewTriState.True;
            ControlName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(49, 87);
            label2.Name = "label2";
            label2.Size = new Size(103, 16);
            label2.TabIndex = 59;
            label2.Text = "Class Name BL :";
            // 
            // chkConnection
            // 
            chkConnection.AutoSize = true;
            chkConnection.Location = new Point(396, 57);
            chkConnection.Name = "chkConnection";
            chkConnection.Size = new Size(122, 19);
            chkConnection.TabIndex = 14;
            chkConnection.Text = "Connection String";
            chkConnection.UseVisualStyleBackColor = true;
            // 
            // chkInsert
            // 
            chkInsert.AutoSize = true;
            chkInsert.Location = new Point(144, 56);
            chkInsert.Name = "chkInsert";
            chkInsert.Size = new Size(79, 19);
            chkInsert.TabIndex = 10;
            chkInsert.Text = "Insert Into";
            chkInsert.UseVisualStyleBackColor = true;
            // 
            // chkDelete
            // 
            chkDelete.AutoSize = true;
            chkDelete.Location = new Point(266, 57);
            chkDelete.Name = "chkDelete";
            chkDelete.Size = new Size(59, 19);
            chkDelete.TabIndex = 12;
            chkDelete.Text = "Delete";
            chkDelete.UseVisualStyleBackColor = true;
            // 
            // chkUpdate
            // 
            chkUpdate.AutoSize = true;
            chkUpdate.Location = new Point(266, 22);
            chkUpdate.Name = "chkUpdate";
            chkUpdate.Size = new Size(64, 19);
            chkUpdate.TabIndex = 11;
            chkUpdate.Text = "Update";
            chkUpdate.UseVisualStyleBackColor = true;
            // 
            // chkSave
            // 
            chkSave.AutoSize = true;
            chkSave.Location = new Point(396, 20);
            chkSave.Name = "chkSave";
            chkSave.Size = new Size(100, 19);
            chkSave.TabIndex = 13;
            chkSave.Text = "Save Function";
            chkSave.UseVisualStyleBackColor = true;
            // 
            // chkFindWithName
            // 
            chkFindWithName.AutoSize = true;
            chkFindWithName.Location = new Point(144, 22);
            chkFindWithName.Name = "chkFindWithName";
            chkFindWithName.Size = new Size(112, 19);
            chkFindWithName.TabIndex = 9;
            chkFindWithName.Text = "Find With Name";
            chkFindWithName.UseVisualStyleBackColor = true;
            // 
            // txtClassNameBL
            // 
            txtClassNameBL.Location = new Point(165, 85);
            txtClassNameBL.Name = "txtClassNameBL";
            txtClassNameBL.Size = new Size(192, 23);
            txtClassNameBL.TabIndex = 0;
            // 
            // btnGeneratePL
            // 
            btnGeneratePL.BackColor = SystemColors.ControlLight;
            btnGeneratePL.Location = new Point(690, 209);
            btnGeneratePL.Name = "btnGeneratePL";
            btnGeneratePL.Size = new Size(115, 42);
            btnGeneratePL.TabIndex = 15;
            btnGeneratePL.Text = "Generate PL";
            btnGeneratePL.UseVisualStyleBackColor = false;
            btnGeneratePL.Click += btnGeneratePL_Click;
            // 
            // txtGeneratedCode
            // 
            txtGeneratedCode.BorderStyle = BorderStyle.FixedSingle;
            txtGeneratedCode.Location = new Point(42, 315);
            txtGeneratedCode.Name = "txtGeneratedCode";
            txtGeneratedCode.Size = new Size(491, 331);
            txtGeneratedCode.TabIndex = 60;
            txtGeneratedCode.Text = "";
            // 
            // chkFindWithID
            // 
            chkFindWithID.AutoSize = true;
            chkFindWithID.Location = new Point(8, 57);
            chkFindWithID.Name = "chkFindWithID";
            chkFindWithID.Size = new Size(91, 19);
            chkFindWithID.TabIndex = 8;
            chkFindWithID.Text = "Find With ID";
            chkFindWithID.UseVisualStyleBackColor = true;
            // 
            // chkGetAll
            // 
            chkGetAll.AutoSize = true;
            chkGetAll.Location = new Point(8, 22);
            chkGetAll.Name = "chkGetAll";
            chkGetAll.Size = new Size(61, 19);
            chkGetAll.TabIndex = 7;
            chkGetAll.Text = "Get All";
            chkGetAll.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ControlLight;
            btnClear.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Image = Properties.Resources.delete_2_321;
            btnClear.ImageAlign = ContentAlignment.MiddleRight;
            btnClear.Location = new Point(690, 254);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(115, 41);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnAddProperty
            // 
            btnAddProperty.BackColor = SystemColors.ControlLight;
            btnAddProperty.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddProperty.Image = Properties.Resources.Add_32;
            btnAddProperty.ImageAlign = ContentAlignment.MiddleRight;
            btnAddProperty.Location = new Point(690, 154);
            btnAddProperty.Name = "btnAddProperty";
            btnAddProperty.Size = new Size(114, 34);
            btnAddProperty.TabIndex = 5;
            btnAddProperty.Text = "Add ";
            btnAddProperty.TextAlign = ContentAlignment.MiddleLeft;
            btnAddProperty.UseVisualStyleBackColor = false;
            btnAddProperty.Click += btnAddProperty_Click;
            // 
            // txtProperties
            // 
            txtProperties.Location = new Point(426, 163);
            txtProperties.Name = "txtProperties";
            txtProperties.Size = new Size(240, 23);
            txtProperties.TabIndex = 4;
            txtProperties.TextChanged += cmbDataType_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(293, 166);
            label4.Name = "label4";
            label4.Size = new Size(109, 16);
            label4.TabIndex = 67;
            label4.Text = "Properties           :";
            // 
            // cmbDataType
            // 
            cmbDataType.FormattingEnabled = true;
            cmbDataType.Items.AddRange(new object[] { "int", "string", "float", "double", "bool", "decimal", "short", "long" });
            cmbDataType.Location = new Point(166, 163);
            cmbDataType.Name = "cmbDataType";
            cmbDataType.Size = new Size(104, 23);
            cmbDataType.TabIndex = 3;
            cmbDataType.SelectedIndexChanged += cmbDataType_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(52, 165);
            label3.Name = "label3";
            label3.Size = new Size(100, 16);
            label3.TabIndex = 65;
            label3.Text = "DataType          :";
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
            groupBox1.Location = new Point(42, 202);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(625, 94);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Functions";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Ink Free", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(300, 6);
            label1.Name = "label1";
            label1.Size = new Size(333, 62);
            label1.TabIndex = 58;
            label1.Text = "Generate \"PL\"";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(51, 126);
            label5.Name = "label5";
            label5.Size = new Size(102, 16);
            label5.TabIndex = 72;
            label5.Text = "DGV Name        :";
            // 
            // txtDGVName
            // 
            txtDGVName.Location = new Point(166, 124);
            txtDGVName.Name = "txtDGVName";
            txtDGVName.Size = new Size(192, 23);
            txtDGVName.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.FlatStyle = FlatStyle.Popup;
            label6.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(426, 91);
            label6.Name = "label6";
            label6.Size = new Size(147, 16);
            label6.TabIndex = 74;
            label6.Text = "Class Name (Entity)     :";
            // 
            // txtClassNameEntity
            // 
            txtClassNameEntity.Location = new Point(612, 87);
            txtClassNameEntity.Name = "txtClassNameEntity";
            txtClassNameEntity.Size = new Size(192, 23);
            txtClassNameEntity.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(429, 127);
            label7.Name = "label7";
            label7.Size = new Size(142, 16);
            label7.TabIndex = 76;
            label7.Text = "Control Name               :";
            // 
            // txtControlName
            // 
            txtControlName.Location = new Point(612, 124);
            txtControlName.Name = "txtControlName";
            txtControlName.Size = new Size(192, 23);
            txtControlName.TabIndex = 77;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.Control;
            label10.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Maroon;
            label10.Location = new Point(43, 658);
            label10.Name = "label10";
            label10.Size = new Size(418, 14);
            label10.TabIndex = 78;
            label10.Text = "I Prefere to generate the PL Function one by one hard code , not Generate it.";
            // 
            // ctrlGeneratePL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(txtControlName);
            Controls.Add(label6);
            Controls.Add(txtClassNameEntity);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(dgvProperties);
            Controls.Add(txtDGVName);
            Controls.Add(label2);
            Controls.Add(txtClassNameBL);
            Controls.Add(btnGeneratePL);
            Controls.Add(txtGeneratedCode);
            Controls.Add(btnClear);
            Controls.Add(btnAddProperty);
            Controls.Add(txtProperties);
            Controls.Add(label4);
            Controls.Add(cmbDataType);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "ctrlGeneratePL";
            Size = new Size(849, 739);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProperties).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private DataGridView dgvProperties;
        private Label label2;
        private CheckBox chkConnection;
        private CheckBox chkInsert;
        private CheckBox chkDelete;
        private CheckBox chkUpdate;
        private CheckBox chkSave;
        private CheckBox chkFindWithName;
        private TextBox txtClassNameBL;
        private Button btnGeneratePL;
        private RichTextBox txtGeneratedCode;
        private CheckBox chkFindWithID;
        private CheckBox chkGetAll;
        private Button btnClear;
        private Button btnAddProperty;
        private TextBox txtProperties;
        private Label label4;
        private ComboBox cmbDataType;
        private Label label3;
        private GroupBox groupBox1;
        private Label label1;
        private Label label5;
        private TextBox txtDGVName;
        private Label label6;
        private TextBox txtClassNameEntity;
        private DataGridViewTextBoxColumn PropertyName;
        private DataGridViewTextBoxColumn DataType;
        private DataGridViewTextBoxColumn ControlName;
        private Label label7;
        private TextBox txtControlName;
        private Label label10;
    }
}
