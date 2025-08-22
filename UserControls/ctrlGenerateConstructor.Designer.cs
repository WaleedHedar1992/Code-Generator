namespace CodeGeneratore_0._1.UserControls
{
    partial class ctrlGenerateConstructor
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
            IncludeInConstructor = new DataGridViewCheckBoxColumn();
            btnAddProperty = new Button();
            cmbDataType = new ComboBox();
            label4 = new Label();
            txtPropertyName = new TextBox();
            label3 = new Label();
            txtClassName = new TextBox();
            btnGenerateConstructor = new Button();
            txtGeneratedCode = new RichTextBox();
            label2 = new Label();
            label1 = new Label();
            chkDefaultConstructor = new CheckBox();
            chkConstructorWithParameters = new CheckBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgvProperties
            // 
            dgvProperties.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProperties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProperties.Columns.AddRange(new DataGridViewColumn[] { PropertyName, DataType, IncludeInConstructor });
            dgvProperties.Location = new Point(543, 238);
            dgvProperties.Name = "dgvProperties";
            dgvProperties.Size = new Size(267, 385);
            dgvProperties.TabIndex = 24;
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
            // IncludeInConstructor
            // 
            IncludeInConstructor.HeaderText = "Include in constructor";
            IncludeInConstructor.Name = "IncludeInConstructor";
            // 
            // btnAddProperty
            // 
            btnAddProperty.BackColor = SystemColors.ControlLight;
            btnAddProperty.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddProperty.Image = Properties.Resources.Add_32;
            btnAddProperty.ImageAlign = ContentAlignment.MiddleRight;
            btnAddProperty.Location = new Point(427, 163);
            btnAddProperty.Name = "btnAddProperty";
            btnAddProperty.Size = new Size(145, 34);
            btnAddProperty.TabIndex = 23;
            btnAddProperty.Text = "Add ";
            btnAddProperty.TextAlign = ContentAlignment.MiddleLeft;
            btnAddProperty.UseVisualStyleBackColor = false;
            btnAddProperty.Click += btnAddProperty_Click;
            // 
            // cmbDataType
            // 
            cmbDataType.DisplayMember = "0";
            cmbDataType.FormattingEnabled = true;
            cmbDataType.Items.AddRange(new object[] { "int", "string", "double", "bool", "float", "short", "Decimal", "Long", "" });
            cmbDataType.Location = new Point(197, 131);
            cmbDataType.Name = "cmbDataType";
            cmbDataType.Size = new Size(192, 23);
            cmbDataType.TabIndex = 22;
            cmbDataType.ValueMember = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(45, 133);
            label4.Name = "label4";
            label4.Size = new Size(115, 16);
            label4.TabIndex = 21;
            label4.Text = "Data Type              :";
            // 
            // txtPropertyName
            // 
            txtPropertyName.Location = new Point(197, 172);
            txtPropertyName.Name = "txtPropertyName";
            txtPropertyName.Size = new Size(192, 23);
            txtPropertyName.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(46, 176);
            label3.Name = "label3";
            label3.Size = new Size(115, 16);
            label3.TabIndex = 19;
            label3.Text = "Property Name   :";
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(197, 91);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(192, 23);
            txtClassName.TabIndex = 18;
            // 
            // btnGenerateConstructor
            // 
            btnGenerateConstructor.BackColor = SystemColors.ControlLight;
            btnGenerateConstructor.Location = new Point(657, 129);
            btnGenerateConstructor.Name = "btnGenerateConstructor";
            btnGenerateConstructor.Size = new Size(111, 68);
            btnGenerateConstructor.TabIndex = 17;
            btnGenerateConstructor.Text = "Generate Constructor";
            btnGenerateConstructor.UseVisualStyleBackColor = false;
            btnGenerateConstructor.Click += btnGenerateConstructor_Click;
            // 
            // txtGeneratedCode
            // 
            txtGeneratedCode.BorderStyle = BorderStyle.FixedSingle;
            txtGeneratedCode.Location = new Point(46, 238);
            txtGeneratedCode.Name = "txtGeneratedCode";
            txtGeneratedCode.Size = new Size(491, 385);
            txtGeneratedCode.TabIndex = 16;
            txtGeneratedCode.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(46, 93);
            label2.Name = "label2";
            label2.Size = new Size(114, 16);
            label2.TabIndex = 15;
            label2.Text = "Class Name           :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Ink Free", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(230, 0);
            label1.Name = "label1";
            label1.Size = new Size(494, 62);
            label1.TabIndex = 14;
            label1.Text = "Generate Constructor";
            // 
            // chkDefaultConstructor
            // 
            chkDefaultConstructor.AutoSize = true;
            chkDefaultConstructor.Location = new Point(430, 130);
            chkDefaultConstructor.Name = "chkDefaultConstructor";
            chkDefaultConstructor.Size = new Size(130, 19);
            chkDefaultConstructor.TabIndex = 26;
            chkDefaultConstructor.Text = "Default Constructor";
            chkDefaultConstructor.UseVisualStyleBackColor = true;
            // 
            // chkConstructorWithParameters
            // 
            chkConstructorWithParameters.AutoSize = true;
            chkConstructorWithParameters.Location = new Point(428, 96);
            chkConstructorWithParameters.Name = "chkConstructorWithParameters";
            chkConstructorWithParameters.Size = new Size(179, 19);
            chkConstructorWithParameters.TabIndex = 25;
            chkConstructorWithParameters.Text = "Constructor With Parameters";
            chkConstructorWithParameters.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Generate_Code_0_1;
            pictureBox2.Location = new Point(125, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(99, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(43, 639);
            label5.Name = "label5";
            label5.Size = new Size(449, 14);
            label5.TabIndex = 58;
            label5.Text = " * The Constructor useing class name , you can make it with Paramters or without.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(46, 660);
            label6.Name = "label6";
            label6.Size = new Size(474, 14);
            label6.TabIndex = 59;
            label6.Text = "* Add The class name , then if you need with paramters add the paramters to the DGV";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(46, 681);
            label7.Name = "label7";
            label7.Size = new Size(489, 14);
            label7.TabIndex = 60;
            label7.Text = "* should click on check boxes  and check boxes inside the DGV . to generate Constructore";
            // 
            // ctrlGenerateConstructor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(dgvProperties);
            Controls.Add(btnAddProperty);
            Controls.Add(cmbDataType);
            Controls.Add(label4);
            Controls.Add(txtPropertyName);
            Controls.Add(label3);
            Controls.Add(txtClassName);
            Controls.Add(btnGenerateConstructor);
            Controls.Add(txtGeneratedCode);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chkDefaultConstructor);
            Controls.Add(chkConstructorWithParameters);
            Name = "ctrlGenerateConstructor";
            Size = new Size(849, 739);
            ((System.ComponentModel.ISupportInitialize)dgvProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProperties;
        private DataGridViewTextBoxColumn PropertyName;
        private DataGridViewTextBoxColumn DataType;
        private Button btnAddProperty;
        private ComboBox cmbDataType;
        private Label label4;
        private TextBox txtPropertyName;
        private Label label3;
        private TextBox txtClassName;
        private Button btnGenerateConstructor;
        private RichTextBox txtGeneratedCode;
        private Label label2;
        private Label label1;
        private CheckBox chkDefaultConstructor;
        private CheckBox chkConstructorWithParameters;
        private DataGridViewCheckBoxColumn IncludeInConstructor;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
