namespace CodeGeneratore_0._1.UserControls
{
    partial class ctrlGenerateVlidatingFunctions
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
            label6 = new Label();
            pictureBox2 = new PictureBox();
            txtParameters = new TextBox();
            label4 = new Label();
            label3 = new Label();
            chkMinLength = new CheckBox();
            chkMaxLength = new CheckBox();
            chkPattern = new CheckBox();
            chkMaxValue = new CheckBox();
            label1 = new Label();
            chkMinValue = new CheckBox();
            chkEmail = new CheckBox();
            chkNumeric = new CheckBox();
            chkRequired = new CheckBox();
            txtFunctionName = new TextBox();
            btnGenerateAllFunctions = new Button();
            txtGeneratedCode = new RichTextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            txtRegexPattern = new TextBox();
            txtMinLength = new TextBox();
            txtMaxLength = new TextBox();
            txtMaxValue = new TextBox();
            txtMinValue = new TextBox();
            txtDataType = new TextBox();
            groupBox2 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            btngenrateFunction = new Button();
            errorProvider1 = new ErrorProvider(components);
            btnClearTxtBox = new Button();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(1, 30);
            label6.Name = "label6";
            label6.Size = new Size(270, 14);
            label6.TabIndex = 76;
            label6.Text = "* If you didn't need to make a specific Function  :";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Generate_Code_0_1;
            pictureBox2.Location = new Point(37, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(95, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 75;
            pictureBox2.TabStop = false;
            // 
            // txtParameters
            // 
            txtParameters.Location = new Point(517, 137);
            txtParameters.Name = "txtParameters";
            txtParameters.Size = new Size(240, 23);
            txtParameters.TabIndex = 73;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(390, 138);
            label4.Name = "label4";
            label4.Size = new Size(115, 16);
            label4.TabIndex = 72;
            label4.Text = "Parameters           :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(41, 135);
            label3.Name = "label3";
            label3.Size = new Size(118, 16);
            label3.TabIndex = 70;
            label3.Text = "Data Type               :";
            // 
            // chkMinLength
            // 
            chkMinLength.AutoSize = true;
            chkMinLength.Location = new Point(310, 61);
            chkMinLength.Name = "chkMinLength";
            chkMinLength.Size = new Size(87, 19);
            chkMinLength.TabIndex = 7;
            chkMinLength.Text = "Min Length";
            chkMinLength.UseVisualStyleBackColor = true;
            // 
            // chkMaxLength
            // 
            chkMaxLength.AutoSize = true;
            chkMaxLength.Location = new Point(310, 26);
            chkMaxLength.Name = "chkMaxLength";
            chkMaxLength.Size = new Size(88, 19);
            chkMaxLength.TabIndex = 6;
            chkMaxLength.Text = "Max Length";
            chkMaxLength.UseVisualStyleBackColor = true;
            // 
            // chkPattern
            // 
            chkPattern.AutoSize = true;
            chkPattern.Location = new Point(530, 61);
            chkPattern.Name = "chkPattern";
            chkPattern.Size = new Size(64, 19);
            chkPattern.TabIndex = 5;
            chkPattern.Text = "Pattern";
            chkPattern.UseVisualStyleBackColor = true;
            // 
            // chkMaxValue
            // 
            chkMaxValue.AutoSize = true;
            chkMaxValue.Location = new Point(111, 22);
            chkMaxValue.Name = "chkMaxValue";
            chkMaxValue.Size = new Size(79, 19);
            chkMaxValue.TabIndex = 4;
            chkMaxValue.Text = "Max Value";
            chkMaxValue.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Ink Free", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(135, 17);
            label1.Name = "label1";
            label1.Size = new Size(667, 62);
            label1.TabIndex = 63;
            label1.Text = "Generate Validating Functions";
            // 
            // chkMinValue
            // 
            chkMinValue.AutoSize = true;
            chkMinValue.Location = new Point(111, 57);
            chkMinValue.Name = "chkMinValue";
            chkMinValue.Size = new Size(78, 19);
            chkMinValue.TabIndex = 3;
            chkMinValue.Text = "Min Value";
            chkMinValue.UseVisualStyleBackColor = true;
            // 
            // chkEmail
            // 
            chkEmail.AutoSize = true;
            chkEmail.Location = new Point(530, 26);
            chkEmail.Name = "chkEmail";
            chkEmail.Size = new Size(55, 19);
            chkEmail.TabIndex = 2;
            chkEmail.Text = "Email";
            chkEmail.UseVisualStyleBackColor = true;
            // 
            // chkNumeric
            // 
            chkNumeric.AutoSize = true;
            chkNumeric.Location = new Point(8, 57);
            chkNumeric.Name = "chkNumeric";
            chkNumeric.Size = new Size(72, 19);
            chkNumeric.TabIndex = 1;
            chkNumeric.Text = "Numeric";
            chkNumeric.UseVisualStyleBackColor = true;
            // 
            // chkRequired
            // 
            chkRequired.AutoSize = true;
            chkRequired.Location = new Point(8, 22);
            chkRequired.Name = "chkRequired";
            chkRequired.Size = new Size(73, 19);
            chkRequired.TabIndex = 0;
            chkRequired.Text = "Required";
            chkRequired.UseVisualStyleBackColor = true;
            // 
            // txtFunctionName
            // 
            txtFunctionName.Location = new Point(166, 104);
            txtFunctionName.Name = "txtFunctionName";
            txtFunctionName.Size = new Size(192, 23);
            txtFunctionName.TabIndex = 67;
            // 
            // btnGenerateAllFunctions
            // 
            btnGenerateAllFunctions.BackColor = SystemColors.ControlLight;
            btnGenerateAllFunctions.Location = new Point(661, 274);
            btnGenerateAllFunctions.Name = "btnGenerateAllFunctions";
            btnGenerateAllFunctions.Size = new Size(141, 90);
            btnGenerateAllFunctions.TabIndex = 66;
            btnGenerateAllFunctions.Text = "Generate All Functions";
            btnGenerateAllFunctions.UseVisualStyleBackColor = false;
            btnGenerateAllFunctions.Click += btnGenerateAllFunctions_Click;
            // 
            // txtGeneratedCode
            // 
            txtGeneratedCode.BorderStyle = BorderStyle.FixedSingle;
            txtGeneratedCode.Location = new Point(40, 274);
            txtGeneratedCode.Name = "txtGeneratedCode";
            txtGeneratedCode.Size = new Size(454, 385);
            txtGeneratedCode.TabIndex = 65;
            txtGeneratedCode.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(40, 107);
            label2.Name = "label2";
            label2.Size = new Size(120, 16);
            label2.TabIndex = 64;
            label2.Text = "function Name      :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtRegexPattern);
            groupBox1.Controls.Add(chkPattern);
            groupBox1.Controls.Add(chkEmail);
            groupBox1.Controls.Add(chkNumeric);
            groupBox1.Controls.Add(chkMinValue);
            groupBox1.Controls.Add(txtMinLength);
            groupBox1.Controls.Add(chkMinLength);
            groupBox1.Controls.Add(txtMaxLength);
            groupBox1.Controls.Add(chkRequired);
            groupBox1.Controls.Add(chkMaxValue);
            groupBox1.Controls.Add(chkMaxLength);
            groupBox1.Controls.Add(txtMaxValue);
            groupBox1.Controls.Add(txtMinValue);
            groupBox1.Location = new Point(40, 165);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(764, 94);
            groupBox1.TabIndex = 69;
            groupBox1.TabStop = false;
            groupBox1.Text = "Validation Options";
            // 
            // txtRegexPattern
            // 
            txtRegexPattern.Location = new Point(600, 55);
            txtRegexPattern.Name = "txtRegexPattern";
            txtRegexPattern.Size = new Size(144, 23);
            txtRegexPattern.TabIndex = 88;
            // 
            // txtMinLength
            // 
            txtMinLength.Location = new Point(401, 57);
            txtMinLength.Name = "txtMinLength";
            txtMinLength.Size = new Size(87, 23);
            txtMinLength.TabIndex = 87;
            // 
            // txtMaxLength
            // 
            txtMaxLength.Location = new Point(402, 24);
            txtMaxLength.Name = "txtMaxLength";
            txtMaxLength.Size = new Size(87, 23);
            txtMaxLength.TabIndex = 85;
            // 
            // txtMaxValue
            // 
            txtMaxValue.Location = new Point(196, 22);
            txtMaxValue.Name = "txtMaxValue";
            txtMaxValue.Size = new Size(87, 23);
            txtMaxValue.TabIndex = 81;
            // 
            // txtMinValue
            // 
            txtMinValue.Location = new Point(195, 57);
            txtMinValue.Name = "txtMinValue";
            txtMinValue.Size = new Size(87, 23);
            txtMinValue.TabIndex = 83;
            // 
            // txtDataType
            // 
            txtDataType.Location = new Point(166, 132);
            txtDataType.Name = "txtDataType";
            txtDataType.Size = new Size(192, 23);
            txtDataType.TabIndex = 79;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(500, 434);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(304, 224);
            groupBox2.TabIndex = 89;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informations";
            // 
            // label9
            // 
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Maroon;
            label9.Location = new Point(17, 132);
            label9.Name = "label9";
            label9.Size = new Size(270, 30);
            label9.TabIndex = 80;
            label9.Text = "- choose what you want of tools above to Generate Function";
            label9.UseWaitCursor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(4, 105);
            label8.Name = "label8";
            label8.Size = new Size(238, 14);
            label8.TabIndex = 79;
            label8.Text = "* If you  need to make a specific Function  :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(17, 67);
            label7.Name = "label7";
            label7.Size = new Size(271, 14);
            label7.TabIndex = 78;
            label7.Text = "- Will generate all validating functions one time.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(19, 49);
            label5.Name = "label5";
            label5.Size = new Size(141, 14);
            label5.TabIndex = 77;
            label5.Text = "- Press genrate function .";
            // 
            // btngenrateFunction
            // 
            btngenrateFunction.BackColor = SystemColors.ControlLight;
            btngenrateFunction.Location = new Point(503, 274);
            btngenrateFunction.Name = "btngenrateFunction";
            btngenrateFunction.Size = new Size(141, 90);
            btngenrateFunction.TabIndex = 90;
            btngenrateFunction.Text = "Genrate Function";
            btngenrateFunction.UseVisualStyleBackColor = false;
            btngenrateFunction.Click += btngenrateFunction_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnClearTxtBox
            // 
            btnClearTxtBox.BackColor = SystemColors.ControlLight;
            btnClearTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearTxtBox.Location = new Point(504, 374);
            btnClearTxtBox.Name = "btnClearTxtBox";
            btnClearTxtBox.Size = new Size(298, 48);
            btnClearTxtBox.TabIndex = 91;
            btnClearTxtBox.Text = "Clear Text Box";
            btnClearTxtBox.UseVisualStyleBackColor = false;
            btnClearTxtBox.Click += btnClearTxtBox_Click;
            // 
            // label10
            // 
            label10.BackColor = SystemColors.Control;
            label10.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(37, 668);
            label10.Name = "label10";
            label10.Size = new Size(767, 46);
            label10.TabIndex = 81;
            label10.Text = "** it's Better to Generate All functions one time and put all in one class in your project and use what you want one by one.";
            label10.UseWaitCursor = true;
            // 
            // ctrlGenerateVlidatingFunctions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label10);
            Controls.Add(btnClearTxtBox);
            Controls.Add(btngenrateFunction);
            Controls.Add(groupBox2);
            Controls.Add(txtDataType);
            Controls.Add(pictureBox2);
            Controls.Add(txtParameters);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtFunctionName);
            Controls.Add(btnGenerateAllFunctions);
            Controls.Add(txtGeneratedCode);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Name = "ctrlGenerateVlidatingFunctions";
            Size = new Size(849, 739);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private PictureBox pictureBox2;
        private TextBox txtParameters;
        private Label label4;
        private Label label3;
        private CheckBox chkMinLength;
        private CheckBox chkMaxLength;
        private CheckBox chkPattern;
        private CheckBox chkMaxValue;
        private Label label1;
        private CheckBox chkMinValue;
        private CheckBox chkEmail;
        private CheckBox chkNumeric;
        private CheckBox chkRequired;
        private TextBox txtFunctionName;
        private Button btnGenerateAllFunctions;
        private RichTextBox txtGeneratedCode;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txtDataType;
        private TextBox txtMinValue;
        private TextBox txtMaxValue;
        private TextBox txtMinLength;
        private TextBox txtMaxLength;
        private TextBox txtRegexPattern;
        private GroupBox groupBox2;
        private Button btngenrateFunction;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private ErrorProvider errorProvider1;
        private Button btnClearTxtBox;
        private Label label10;
    }
}
