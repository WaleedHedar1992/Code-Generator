namespace CodeGeneratore_0._1.UserControls
{
    partial class ctrlGenerateBLFunctionsToCallDALFunctions
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
            pictureBox2 = new PictureBox();
            btnAddParameters = new Button();
            txtParameterName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btnGenerateFunction = new Button();
            txtGeneratedCode = new RichTextBox();
            label2 = new Label();
            txtDALClassName = new TextBox();
            dgvParameters = new DataGridView();
            PropertyName = new DataGridViewTextBoxColumn();
            DataType = new DataGridViewTextBoxColumn();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label10 = new Label();
            txtFunctionDataType = new TextBox();
            label9 = new Label();
            txtDataType = new TextBox();
            label8 = new Label();
            txtBLFunctionName = new TextBox();
            label6 = new Label();
            txtDALFunctionName = new TextBox();
            label7 = new Label();
            txtBLClassName = new TextBox();
            label5 = new Label();
            btnAddFunction = new Button();
            dgvFunctions = new DataGridView();
            ColBLClass = new DataGridViewTextBoxColumn();
            ColBLFunction = new DataGridViewTextBoxColumn();
            ColDALClass = new DataGridViewTextBoxColumn();
            ColDALFunction = new DataGridViewTextBoxColumn();
            ColParameters = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvParameters).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFunctions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Generate_Code_0_1;
            pictureBox2.Location = new Point(11, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(95, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 57;
            pictureBox2.TabStop = false;
            // 
            // btnAddParameters
            // 
            btnAddParameters.BackColor = SystemColors.ControlLight;
            btnAddParameters.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddParameters.ImageAlign = ContentAlignment.MiddleRight;
            btnAddParameters.Location = new Point(167, 279);
            btnAddParameters.Name = "btnAddParameters";
            btnAddParameters.Size = new Size(114, 34);
            btnAddParameters.TabIndex = 6;
            btnAddParameters.Text = "Add  Parameters";
            btnAddParameters.TextAlign = ContentAlignment.MiddleLeft;
            btnAddParameters.UseVisualStyleBackColor = false;
            btnAddParameters.Click += btnAddParameter_Click;
            // 
            // txtParameterName
            // 
            txtParameterName.Location = new Point(544, 105);
            txtParameterName.Name = "txtParameterName";
            txtParameterName.Size = new Size(192, 23);
            txtParameterName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(409, 110);
            label4.Name = "label4";
            label4.Size = new Size(124, 16);
            label4.TabIndex = 54;
            label4.Text = "Parameter Name   :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(16, 107);
            label3.Name = "label3";
            label3.Size = new Size(128, 16);
            label3.TabIndex = 52;
            label3.Text = "Param DataType     :";
            // 
            // btnGenerateFunction
            // 
            btnGenerateFunction.BackColor = SystemColors.ControlLight;
            btnGenerateFunction.Location = new Point(589, 279);
            btnGenerateFunction.Name = "btnGenerateFunction";
            btnGenerateFunction.Size = new Size(114, 34);
            btnGenerateFunction.TabIndex = 8;
            btnGenerateFunction.Text = "Generate Function";
            btnGenerateFunction.UseVisualStyleBackColor = false;
            btnGenerateFunction.Click += btnGenerateCode_Click;
            // 
            // txtGeneratedCode
            // 
            txtGeneratedCode.BorderStyle = BorderStyle.FixedSingle;
            txtGeneratedCode.Location = new Point(630, 323);
            txtGeneratedCode.Name = "txtGeneratedCode";
            txtGeneratedCode.Size = new Size(199, 337);
            txtGeneratedCode.TabIndex = 47;
            txtGeneratedCode.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(16, 30);
            label2.Name = "label2";
            label2.Size = new Size(129, 16);
            label2.TabIndex = 46;
            label2.Text = "DAL Class Name      :";
            // 
            // txtDALClassName
            // 
            txtDALClassName.Location = new Point(151, 27);
            txtDALClassName.Name = "txtDALClassName";
            txtDALClassName.Size = new Size(192, 23);
            txtDALClassName.TabIndex = 1;
            // 
            // dgvParameters
            // 
            dgvParameters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvParameters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParameters.Columns.AddRange(new DataGridViewColumn[] { PropertyName, DataType });
            dgvParameters.Location = new Point(19, 322);
            dgvParameters.Name = "dgvParameters";
            dgvParameters.Size = new Size(216, 337);
            dgvParameters.TabIndex = 50;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Ink Free", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(112, 8);
            label1.Name = "label1";
            label1.Size = new Size(726, 48);
            label1.TabIndex = 45;
            label1.Text = "Generate BL Functions Call DAL Functions";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtFunctionDataType);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtDataType);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtBLFunctionName);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtDALFunctionName);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtParameterName);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtBLClassName);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtDALClassName);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(43, 82);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(760, 188);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "BL Function Requerments";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.Control;
            label10.FlatStyle = FlatStyle.Popup;
            label10.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Maroon;
            label10.Location = new Point(363, 162);
            label10.Name = "label10";
            label10.Size = new Size(283, 14);
            label10.TabIndex = 59;
            label10.Text = "* The Data Type for functions to be more specified .";
            // 
            // txtFunctionDataType
            // 
            txtFunctionDataType.Location = new Point(151, 159);
            txtFunctionDataType.Name = "txtFunctionDataType";
            txtFunctionDataType.Size = new Size(192, 23);
            txtFunctionDataType.TabIndex = 57;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.FlatStyle = FlatStyle.Popup;
            label9.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(16, 162);
            label9.Name = "label9";
            label9.Size = new Size(126, 15);
            label9.TabIndex = 58;
            label9.Text = "Function DataType :";
            // 
            // txtDataType
            // 
            txtDataType.Location = new Point(151, 104);
            txtDataType.Name = "txtDataType";
            txtDataType.Size = new Size(192, 23);
            txtDataType.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.FlatStyle = FlatStyle.Popup;
            label8.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(20, 137);
            label8.Name = "label8";
            label8.Size = new Size(627, 14);
            label8.TabIndex = 56;
            label8.Text = "* Text box Data Type and Text box Properties are requried if function need to parameters like Update , Delete ...etc.";
            // 
            // txtBLFunctionName
            // 
            txtBLFunctionName.Location = new Point(544, 66);
            txtBLFunctionName.Name = "txtBLFunctionName";
            txtBLFunctionName.Size = new Size(192, 23);
            txtBLFunctionName.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.FlatStyle = FlatStyle.Popup;
            label6.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(409, 70);
            label6.Name = "label6";
            label6.Size = new Size(125, 16);
            label6.TabIndex = 54;
            label6.Text = "BL Function Name:";
            // 
            // txtDALFunctionName
            // 
            txtDALFunctionName.Location = new Point(151, 66);
            txtDALFunctionName.Name = "txtDALFunctionName";
            txtDALFunctionName.Size = new Size(192, 23);
            txtDALFunctionName.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(16, 69);
            label7.Name = "label7";
            label7.Size = new Size(129, 15);
            label7.TabIndex = 52;
            label7.Text = "DAL Function Name:";
            // 
            // txtBLClassName
            // 
            txtBLClassName.Location = new Point(544, 27);
            txtBLClassName.Name = "txtBLClassName";
            txtBLClassName.Size = new Size(192, 23);
            txtBLClassName.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(409, 30);
            label5.Name = "label5";
            label5.Size = new Size(124, 16);
            label5.TabIndex = 50;
            label5.Text = "BL Class Name        :";
            // 
            // btnAddFunction
            // 
            btnAddFunction.BackColor = SystemColors.ControlLight;
            btnAddFunction.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddFunction.Location = new Point(369, 279);
            btnAddFunction.Name = "btnAddFunction";
            btnAddFunction.Size = new Size(114, 34);
            btnAddFunction.TabIndex = 7;
            btnAddFunction.Text = "Add Functions";
            btnAddFunction.UseVisualStyleBackColor = false;
            btnAddFunction.Click += btnAddFunction_Click;
            // 
            // dgvFunctions
            // 
            dgvFunctions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFunctions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFunctions.Columns.AddRange(new DataGridViewColumn[] { ColBLClass, ColBLFunction, ColDALClass, ColDALFunction, ColParameters });
            dgvFunctions.Location = new Point(242, 323);
            dgvFunctions.Name = "dgvFunctions";
            dgvFunctions.Size = new Size(378, 337);
            dgvFunctions.TabIndex = 60;
            // 
            // ColBLClass
            // 
            ColBLClass.HeaderText = "BL Class";
            ColBLClass.Name = "ColBLClass";
            // 
            // ColBLFunction
            // 
            ColBLFunction.HeaderText = "BL Function";
            ColBLFunction.Name = "ColBLFunction";
            // 
            // ColDALClass
            // 
            ColDALClass.HeaderText = "DAL Class";
            ColDALClass.Name = "ColDALClass";
            // 
            // ColDALFunction
            // 
            ColDALFunction.HeaderText = "DAL Function";
            ColDALFunction.Name = "ColDALFunction";
            // 
            // ColParameters
            // 
            ColParameters.HeaderText = "Parameters";
            ColParameters.Name = "ColParameters";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            errorProvider1.RightToLeftChanged += btnAddFunction_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.Control;
            label11.FlatStyle = FlatStyle.Popup;
            label11.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Maroon;
            label11.Location = new Point(145, 290);
            label11.Name = "label11";
            label11.Size = new Size(22, 14);
            label11.TabIndex = 60;
            label11.Text = "* 1";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.Control;
            label12.FlatStyle = FlatStyle.Popup;
            label12.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Maroon;
            label12.Location = new Point(567, 289);
            label12.Name = "label12";
            label12.Size = new Size(22, 14);
            label12.TabIndex = 61;
            label12.Text = "* 3";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.Control;
            label13.FlatStyle = FlatStyle.Popup;
            label13.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Maroon;
            label13.Location = new Point(346, 289);
            label13.Name = "label13";
            label13.Size = new Size(22, 14);
            label13.TabIndex = 62;
            label13.Text = "* 2";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.Control;
            label14.FlatStyle = FlatStyle.Popup;
            label14.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Maroon;
            label14.Location = new Point(21, 672);
            label14.Name = "label14";
            label14.Size = new Size(348, 14);
            label14.TabIndex = 60;
            label14.Text = "* If you need function without parameters , Generated Directly.";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = SystemColors.Control;
            label15.FlatStyle = FlatStyle.Popup;
            label15.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Maroon;
            label15.Location = new Point(19, 695);
            label15.Name = "label15";
            label15.Size = new Size(536, 14);
            label15.TabIndex = 63;
            label15.Text = "* If you need function with parameters , add parameters thin add function thin generate function.";
            // 
            // ctrlGenerateBLFunctionsToCallDALFunctions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(dgvFunctions);
            Controls.Add(btnAddFunction);
            Controls.Add(pictureBox2);
            Controls.Add(btnAddParameters);
            Controls.Add(btnGenerateFunction);
            Controls.Add(txtGeneratedCode);
            Controls.Add(dgvParameters);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Name = "ctrlGenerateBLFunctionsToCallDALFunctions";
            Size = new Size(849, 739);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvParameters).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFunctions).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Button btnAddParameters;
        private TextBox txtParameterName;
        private Label label4;
        private Label label3;
        private Button btnGenerateFunction;
        private RichTextBox txtGeneratedCode;
        private Label label2;
        private TextBox txtDALClassName;
        private DataGridView dgvParameters;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn PropertyName;
        private DataGridViewTextBoxColumn DataType;
        private TextBox txtBLFunctionName;
        private Label label6;
        private TextBox txtDALFunctionName;
        private Label label7;
        private TextBox txtBLClassName;
        private Label label5;
        private Button btnAddFunction;
        private Label label8;
        private TextBox txtDataType;
        private DataGridView dgvFunctions;
        private DataGridViewTextBoxColumn ColBLClass;
        private DataGridViewTextBoxColumn ColBLFunction;
        private DataGridViewTextBoxColumn ColDALClass;
        private DataGridViewTextBoxColumn ColDALFunction;
        private DataGridViewTextBoxColumn ColParameters;
        private ErrorProvider errorProvider1;
        private TextBox txtFunctionDataType;
        private Label label9;
        private Label label10;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label15;
    }
}
