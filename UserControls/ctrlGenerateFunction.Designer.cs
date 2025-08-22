namespace CodeGeneratore_0._1.UserControls
{
    partial class ctrlGenerateFunction
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
            txtProperties = new TextBox();
            label4 = new Label();
            cmbDataType = new ComboBox();
            label3 = new Label();
            txtFunctionName = new TextBox();
            btnGenerateFunction = new Button();
            txtGeneratedCode = new RichTextBox();
            label2 = new Label();
            label1 = new Label();
            chkWithParameters = new CheckBox();
            dgvProperties = new DataGridView();
            PropertyName = new DataGridViewTextBoxColumn();
            DataType = new DataGridViewTextBoxColumn();
            WithReference = new DataGridViewCheckBoxColumn();
            btnAddProperty = new Button();
            groupBox1 = new GroupBox();
            label5 = new Label();
            txtFunctionType = new TextBox();
            pictureBox1 = new PictureBox();
            richtxtAdditionalThings = new RichTextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProperties).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtProperties
            // 
            txtProperties.Location = new Point(151, 100);
            txtProperties.Name = "txtProperties";
            txtProperties.Size = new Size(190, 23);
            txtProperties.TabIndex = 51;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(22, 102);
            label4.Name = "label4";
            label4.Size = new Size(109, 16);
            label4.TabIndex = 50;
            label4.Text = "Properties           :";
            // 
            // cmbDataType
            // 
            cmbDataType.FormattingEnabled = true;
            cmbDataType.Items.AddRange(new object[] { "int", "string", "float", "double", "bool", "decimal", "short", "long" });
            cmbDataType.Location = new Point(151, 61);
            cmbDataType.Name = "cmbDataType";
            cmbDataType.Size = new Size(192, 23);
            cmbDataType.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(22, 63);
            label3.Name = "label3";
            label3.Size = new Size(109, 16);
            label3.TabIndex = 48;
            label3.Text = "DataType             :";
            // 
            // txtFunctionName
            // 
            txtFunctionName.Location = new Point(151, 22);
            txtFunctionName.Name = "txtFunctionName";
            txtFunctionName.Size = new Size(192, 23);
            txtFunctionName.TabIndex = 0;
            // 
            // btnGenerateFunction
            // 
            btnGenerateFunction.BackColor = SystemColors.ControlLight;
            btnGenerateFunction.BackgroundImageLayout = ImageLayout.Zoom;
            btnGenerateFunction.Location = new Point(628, 49);
            btnGenerateFunction.Name = "btnGenerateFunction";
            btnGenerateFunction.Size = new Size(144, 87);
            btnGenerateFunction.TabIndex = 6;
            btnGenerateFunction.Text = "Generate Function";
            btnGenerateFunction.UseVisualStyleBackColor = false;
            btnGenerateFunction.Click += btnGenerateFunction_Click;
            // 
            // txtGeneratedCode
            // 
            txtGeneratedCode.BorderStyle = BorderStyle.FixedSingle;
            txtGeneratedCode.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGeneratedCode.Location = new Point(37, 445);
            txtGeneratedCode.Name = "txtGeneratedCode";
            txtGeneratedCode.Size = new Size(491, 202);
            txtGeneratedCode.TabIndex = 45;
            txtGeneratedCode.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(22, 24);
            label2.Name = "label2";
            label2.Size = new Size(109, 16);
            label2.TabIndex = 44;
            label2.Text = "Function Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Ink Free", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(266, 5);
            label1.Name = "label1";
            label1.Size = new Size(419, 62);
            label1.TabIndex = 43;
            label1.Text = "Generate Function";
            // 
            // chkWithParameters
            // 
            chkWithParameters.AutoSize = true;
            chkWithParameters.Location = new Point(453, 64);
            chkWithParameters.Name = "chkWithParameters";
            chkWithParameters.Size = new Size(163, 19);
            chkWithParameters.TabIndex = 5;
            chkWithParameters.Text = "Function With Parameters";
            chkWithParameters.UseVisualStyleBackColor = true;
            // 
            // dgvProperties
            // 
            dgvProperties.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProperties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProperties.Columns.AddRange(new DataGridViewColumn[] { PropertyName, DataType, WithReference });
            dgvProperties.Location = new Point(550, 262);
            dgvProperties.Name = "dgvProperties";
            dgvProperties.Size = new Size(267, 385);
            dgvProperties.TabIndex = 54;
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
            // WithReference
            // 
            WithReference.HeaderText = "With Reference";
            WithReference.Name = "WithReference";
            // 
            // btnAddProperty
            // 
            btnAddProperty.BackColor = SystemColors.ControlLight;
            btnAddProperty.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddProperty.Image = Properties.Resources.Add_32;
            btnAddProperty.ImageAlign = ContentAlignment.MiddleRight;
            btnAddProperty.Location = new Point(454, 93);
            btnAddProperty.Name = "btnAddProperty";
            btnAddProperty.Size = new Size(114, 34);
            btnAddProperty.TabIndex = 4;
            btnAddProperty.Text = "Add ";
            btnAddProperty.TextAlign = ContentAlignment.MiddleLeft;
            btnAddProperty.UseVisualStyleBackColor = false;
            btnAddProperty.Click += btnAddProperty_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtFunctionType);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(chkWithParameters);
            groupBox1.Controls.Add(txtFunctionName);
            groupBox1.Controls.Add(btnAddProperty);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnGenerateFunction);
            groupBox1.Controls.Add(cmbDataType);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtProperties);
            groupBox1.Location = new Point(35, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(782, 147);
            groupBox1.TabIndex = 56;
            groupBox1.TabStop = false;
            groupBox1.Text = "Build Function";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(452, 27);
            label5.Name = "label5";
            label5.Size = new Size(116, 16);
            label5.TabIndex = 56;
            label5.Text = "Function Type     :";
            // 
            // txtFunctionType
            // 
            txtFunctionType.Location = new Point(578, 23);
            txtFunctionType.Name = "txtFunctionType";
            txtFunctionType.Size = new Size(192, 23);
            txtFunctionType.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Generate_Code_0_1;
            pictureBox1.Location = new Point(164, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 57;
            pictureBox1.TabStop = false;
            // 
            // richtxtAdditionalThings
            // 
            richtxtAdditionalThings.BorderStyle = BorderStyle.FixedSingle;
            richtxtAdditionalThings.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richtxtAdditionalThings.Location = new Point(39, 263);
            richtxtAdditionalThings.Name = "richtxtAdditionalThings";
            richtxtAdditionalThings.Size = new Size(489, 167);
            richtxtAdditionalThings.TabIndex = 58;
            richtxtAdditionalThings.Text = "Here you will add the function logic.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(37, 659);
            label6.Name = "label6";
            label6.Size = new Size(389, 14);
            label6.TabIndex = 61;
            label6.Text = "* Add the function name , and function type like void or another thing .";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(37, 678);
            label7.Name = "label7";
            label7.Size = new Size(392, 14);
            label7.TabIndex = 62;
            label7.Text = "* Add the Pramaeters from Data type and Properties , then add to DGV .";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(35, 697);
            label8.Name = "label8";
            label8.Size = new Size(625, 14);
            label8.TabIndex = 63;
            label8.Text = "* After That Generate Function , if you need to add referance to the function check the check boxes inside the DGV.";
            // 
            // ctrlGenerateFunction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(richtxtAdditionalThings);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(dgvProperties);
            Controls.Add(txtGeneratedCode);
            Controls.Add(label1);
            Name = "ctrlGenerateFunction";
            Size = new Size(849, 739);
            ((System.ComponentModel.ISupportInitialize)dgvProperties).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProperties;
        private Label label4;
        private ComboBox cmbDataType;
        private Label label3;
        private TextBox txtFunctionName;
        private Button btnGenerateFunction;
        private RichTextBox txtGeneratedCode;
        private Label label2;
        private Label label1;
        private CheckBox chkWithParameters;
        
        private DataGridView dgvProperties;
        private Button btnAddProperty;
        private DataGridViewTextBoxColumn PropertyName;
        private DataGridViewTextBoxColumn DataType;
        private DataGridViewCheckBoxColumn WithReference;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label label5;
        private TextBox txtFunctionType;
        private RichTextBox richtxtAdditionalThings;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
