namespace CodeGeneratore_0._1
{
    partial class ctrlGenerateClass
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
            label1 = new Label();
            label2 = new Label();
            txtGeneratedCode = new RichTextBox();
            btnGenerateClass = new Button();
            txtClassName = new TextBox();
            label3 = new Label();
            txtPropertyName = new TextBox();
            label4 = new Label();
            cmbDataType = new ComboBox();
            btnAddProperty = new Button();
            dgvProperties = new DataGridView();
            PropertyName = new DataGridViewTextBoxColumn();
            DataType = new DataGridViewTextBoxColumn();
            chkGenerateConstructor = new CheckBox();
            chkGenerateToString = new CheckBox();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            label1.Location = new Point(302, 4);
            label1.Name = "label1";
            label1.Size = new Size(350, 62);
            label1.TabIndex = 1;
            label1.Text = "Generate Class";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(51, 93);
            label2.Name = "label2";
            label2.Size = new Size(114, 16);
            label2.TabIndex = 2;
            label2.Text = "Class Name           :";
            // 
            // txtGeneratedCode
            // 
            txtGeneratedCode.BorderStyle = BorderStyle.FixedSingle;
            txtGeneratedCode.Location = new Point(51, 238);
            txtGeneratedCode.Name = "txtGeneratedCode";
            txtGeneratedCode.Size = new Size(491, 385);
            txtGeneratedCode.TabIndex = 3;
            txtGeneratedCode.Text = "";
            // 
            // btnGenerateClass
            // 
            btnGenerateClass.BackColor = SystemColors.ControlLight;
            btnGenerateClass.Location = new Point(662, 129);
            btnGenerateClass.Name = "btnGenerateClass";
            btnGenerateClass.Size = new Size(111, 68);
            btnGenerateClass.TabIndex = 4;
            btnGenerateClass.Text = "Generate Class";
            btnGenerateClass.UseVisualStyleBackColor = false;
            btnGenerateClass.Click += btnGenerateClass_Click;
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(202, 91);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(192, 23);
            txtClassName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(51, 176);
            label3.Name = "label3";
            label3.Size = new Size(115, 16);
            label3.TabIndex = 6;
            label3.Text = "Property Name   :";
            // 
            // txtPropertyName
            // 
            txtPropertyName.Location = new Point(202, 172);
            txtPropertyName.Name = "txtPropertyName";
            txtPropertyName.Size = new Size(192, 23);
            txtPropertyName.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(50, 133);
            label4.Name = "label4";
            label4.Size = new Size(115, 16);
            label4.TabIndex = 8;
            label4.Text = "Data Type              :";
            // 
            // cmbDataType
            // 
            cmbDataType.DisplayMember = "0";
            cmbDataType.FormattingEnabled = true;
            cmbDataType.Items.AddRange(new object[] { "int", "string", "double", "bool", "float", "short", "Decimal", "Long", "" });
            cmbDataType.Location = new Point(202, 131);
            cmbDataType.Name = "cmbDataType";
            cmbDataType.Size = new Size(192, 23);
            cmbDataType.TabIndex = 9;
            cmbDataType.ValueMember = "0";
            // 
            // btnAddProperty
            // 
            btnAddProperty.BackColor = SystemColors.ControlLight;
            btnAddProperty.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddProperty.Image = Properties.Resources.Add_32;
            btnAddProperty.ImageAlign = ContentAlignment.MiddleRight;
            btnAddProperty.Location = new Point(432, 163);
            btnAddProperty.Name = "btnAddProperty";
            btnAddProperty.Size = new Size(145, 34);
            btnAddProperty.TabIndex = 10;
            btnAddProperty.Text = "Add ";
            btnAddProperty.TextAlign = ContentAlignment.MiddleLeft;
            btnAddProperty.UseVisualStyleBackColor = false;
            btnAddProperty.Click += btnAddProperty_Click;
            // 
            // dgvProperties
            // 
            dgvProperties.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProperties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProperties.Columns.AddRange(new DataGridViewColumn[] { PropertyName, DataType });
            dgvProperties.Location = new Point(548, 238);
            dgvProperties.Name = "dgvProperties";
            dgvProperties.Size = new Size(267, 385);
            dgvProperties.TabIndex = 11;
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
            // chkGenerateConstructor
            // 
            chkGenerateConstructor.AutoSize = true;
            chkGenerateConstructor.Location = new Point(433, 96);
            chkGenerateConstructor.Name = "chkGenerateConstructor";
            chkGenerateConstructor.Size = new Size(145, 19);
            chkGenerateConstructor.TabIndex = 12;
            chkGenerateConstructor.Text = "Generate Constructore";
            chkGenerateConstructor.UseVisualStyleBackColor = true;
            // 
            // chkGenerateToString
            // 
            chkGenerateToString.AutoSize = true;
            chkGenerateToString.Location = new Point(435, 130);
            chkGenerateToString.Name = "chkGenerateToString";
            chkGenerateToString.Size = new Size(123, 19);
            chkGenerateToString.TabIndex = 13;
            chkGenerateToString.Text = "Generate To String";
            chkGenerateToString.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Generate_Code_0_1;
            pictureBox2.Location = new Point(197, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(99, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Maroon;
            label9.Location = new Point(53, 670);
            label9.Name = "label9";
            label9.Size = new Size(693, 14);
            label9.TabIndex = 56;
            label9.Text = "* More options , if you Generate Constructore , Click Check box true , to String it's override function return Parameters as string..";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(53, 653);
            label5.Name = "label5";
            label5.Size = new Size(309, 14);
            label5.TabIndex = 57;
            label5.Text = "* After Fill the properties to DGV , Press Generate Class.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(53, 636);
            label6.Name = "label6";
            label6.Size = new Size(554, 14);
            label6.TabIndex = 58;
            label6.Text = "* To Generate Class , Add the class name and properties and press add to add the properties to DGV.";
            // 
            // ctrlGenerateClass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(pictureBox2);
            Controls.Add(chkGenerateToString);
            Controls.Add(chkGenerateConstructor);
            Controls.Add(dgvProperties);
            Controls.Add(btnAddProperty);
            Controls.Add(cmbDataType);
            Controls.Add(label4);
            Controls.Add(txtPropertyName);
            Controls.Add(label3);
            Controls.Add(txtClassName);
            Controls.Add(btnGenerateClass);
            Controls.Add(txtGeneratedCode);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ctrlGenerateClass";
            Size = new Size(849, 739);
            Load += ctrlGenerateClass_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RichTextBox txtGeneratedCode;
        private Button btnGenerateClass;
        private TextBox txtClassName;
        private Label label3;
        private TextBox txtPropertyName;
        private Label label4;
        private ComboBox cmbDataType;
        private Button btnAddProperty;
        private DataGridView dgvProperties;
        private DataGridViewTextBoxColumn PropertyName;
        private DataGridViewTextBoxColumn DataType;
        private CheckBox chkGenerateConstructor;
        private CheckBox chkGenerateToString;
        private PictureBox pictureBox2;
        private Label label9;
        private Label label5;
        private Label label6;
    }
}
