namespace CodeGeneratore_0._1.UserControls
{
    partial class ctrlCreateQuery
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
            txtTableName2 = new TextBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            txtTableName1 = new TextBox();
            label6 = new Label();
            txtFKName = new TextBox();
            label2 = new Label();
            label5 = new Label();
            txtWhereCondition = new TextBox();
            cmbTableType = new ComboBox();
            txtDBName = new TextBox();
            label4 = new Label();
            dgvColumns = new DataGridView();
            ColumnName = new DataGridViewTextBoxColumn();
            DataType = new DataGridViewComboBoxColumn();
            AllowNull = new DataGridViewCheckBoxColumn();
            PrimaryKey = new DataGridViewCheckBoxColumn();
            ForeignKey = new DataGridViewCheckBoxColumn();
            Identity = new DataGridViewCheckBoxColumn();
            DefaultValue = new DataGridViewTextBoxColumn();
            btnGenerateQuery = new Button();
            txtGeneratedSQLCode = new RichTextBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            btnClear = new Button();
            label9 = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvColumns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtTableName2
            // 
            txtTableName2.Location = new Point(521, 60);
            txtTableName2.Name = "txtTableName2";
            txtTableName2.Size = new Size(192, 23);
            txtTableName2.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(388, 60);
            label7.Name = "label7";
            label7.Size = new Size(104, 16);
            label7.TabIndex = 33;
            label7.Text = "Table Name 2   :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTableName2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTableName1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtFKName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtWhereCondition);
            groupBox1.Controls.Add(cmbTableType);
            groupBox1.Controls.Add(txtDBName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(41, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(762, 182);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Query Specifications";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(388, 30);
            label3.Name = "label3";
            label3.Size = new Size(103, 16);
            label3.TabIndex = 39;
            label3.Text = "Table Name 1   :";
            // 
            // txtTableName1
            // 
            txtTableName1.Location = new Point(521, 23);
            txtTableName1.Name = "txtTableName1";
            txtTableName1.Size = new Size(192, 23);
            txtTableName1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.FlatStyle = FlatStyle.Popup;
            label6.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(21, 152);
            label6.Name = "label6";
            label6.Size = new Size(107, 16);
            label6.TabIndex = 34;
            label6.Text = "FK Table              :";
            // 
            // txtFKName
            // 
            txtFKName.Location = new Point(148, 151);
            txtFKName.Name = "txtFKName";
            txtFKName.Size = new Size(192, 23);
            txtFKName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(21, 62);
            label2.Name = "label2";
            label2.Size = new Size(109, 16);
            label2.TabIndex = 37;
            label2.Text = "DB Name              :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(21, 97);
            label5.Name = "label5";
            label5.Size = new Size(118, 16);
            label5.TabIndex = 29;
            label5.Text = "Where Condition :";
            // 
            // txtWhereCondition
            // 
            txtWhereCondition.Location = new Point(148, 98);
            txtWhereCondition.Multiline = true;
            txtWhereCondition.Name = "txtWhereCondition";
            txtWhereCondition.Size = new Size(565, 42);
            txtWhereCondition.TabIndex = 4;
            // 
            // cmbTableType
            // 
            cmbTableType.DisplayMember = "0";
            cmbTableType.FormattingEnabled = true;
            cmbTableType.Items.AddRange(new object[] { "Create DataBase", "Create Table", "Insert", "Update", "Delete", "Select *", "Select * (Where)", "Inner Join", "Left Join", "Create View" });
            cmbTableType.Location = new Point(148, 28);
            cmbTableType.Name = "cmbTableType";
            cmbTableType.Size = new Size(192, 23);
            cmbTableType.TabIndex = 0;
            cmbTableType.ValueMember = "0";
            // 
            // txtDBName
            // 
            txtDBName.Location = new Point(148, 61);
            txtDBName.Name = "txtDBName";
            txtDBName.Size = new Size(192, 23);
            txtDBName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(19, 30);
            label4.Name = "label4";
            label4.Size = new Size(109, 16);
            label4.TabIndex = 22;
            label4.Text = "Table Type          :";
            // 
            // dgvColumns
            // 
            dgvColumns.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvColumns.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvColumns.Columns.AddRange(new DataGridViewColumn[] { ColumnName, DataType, AllowNull, PrimaryKey, ForeignKey, Identity, DefaultValue });
            dgvColumns.Location = new Point(297, 329);
            dgvColumns.Name = "dgvColumns";
            dgvColumns.Size = new Size(531, 300);
            dgvColumns.TabIndex = 40;
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Column Name";
            ColumnName.Name = "ColumnName";
            ColumnName.Resizable = DataGridViewTriState.True;
            // 
            // DataType
            // 
            DataType.HeaderText = "Data Type";
            DataType.Items.AddRange(new object[] { "INT", "BIGINT", "DECIMAL(18,3)", "SMALLMONEY", "NVARCHAR(50)", "NVARCHAR(150)", "NVARCHAR(200)", "NVARCHAR(MAX)", "DATE", "DATETIME", "DATETIME2", "SMALLDATETIME" });
            DataType.Name = "DataType";
            DataType.Resizable = DataGridViewTriState.True;
            DataType.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // AllowNull
            // 
            AllowNull.HeaderText = "Allow NULL";
            AllowNull.Name = "AllowNull";
            AllowNull.Resizable = DataGridViewTriState.True;
            AllowNull.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // PrimaryKey
            // 
            PrimaryKey.HeaderText = "Primary Key";
            PrimaryKey.Name = "PrimaryKey";
            PrimaryKey.Resizable = DataGridViewTriState.True;
            PrimaryKey.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // ForeignKey
            // 
            ForeignKey.HeaderText = "Foreign Key";
            ForeignKey.Name = "ForeignKey";
            ForeignKey.Resizable = DataGridViewTriState.True;
            ForeignKey.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Identity
            // 
            Identity.HeaderText = "Identity";
            Identity.Name = "Identity";
            Identity.Resizable = DataGridViewTriState.True;
            Identity.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // DefaultValue
            // 
            DefaultValue.HeaderText = "Default Value";
            DefaultValue.Name = "DefaultValue";
            // 
            // btnGenerateQuery
            // 
            btnGenerateQuery.BackColor = SystemColors.ControlLight;
            btnGenerateQuery.Location = new Point(239, 283);
            btnGenerateQuery.Name = "btnGenerateQuery";
            btnGenerateQuery.Size = new Size(371, 34);
            btnGenerateQuery.TabIndex = 6;
            btnGenerateQuery.Text = "Generate Query";
            btnGenerateQuery.UseVisualStyleBackColor = false;
            btnGenerateQuery.Click += btnGenerateQuery_Click;
            // 
            // txtGeneratedSQLCode
            // 
            txtGeneratedSQLCode.BorderStyle = BorderStyle.FixedSingle;
            txtGeneratedSQLCode.Location = new Point(23, 328);
            txtGeneratedSQLCode.Name = "txtGeneratedSQLCode";
            txtGeneratedSQLCode.Size = new Size(268, 300);
            txtGeneratedSQLCode.TabIndex = 38;
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
            label1.Location = new Point(321, 6);
            label1.Name = "label1";
            label1.Size = new Size(312, 62);
            label1.TabIndex = 36;
            label1.Text = "Create Query";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Generate_Code_0_1;
            pictureBox2.Location = new Point(216, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(99, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 41;
            pictureBox2.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ControlLight;
            btnClear.Location = new Point(699, 283);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(104, 34);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Maroon;
            label9.Location = new Point(45, 648);
            label9.Name = "label9";
            label9.Size = new Size(525, 14);
            label9.TabIndex = 55;
            label9.Text = "* To Create Query you need to table type , DB name , table name 1 , table name 2 if you have FK.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(45, 675);
            label8.Name = "label8";
            label8.Size = new Size(492, 14);
            label8.TabIndex = 56;
            label8.Text = "* if you need to add where condition , write the condition in the text box where condition.";
            // 
            // ctrlCreateQuery
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(btnClear);
            Controls.Add(dgvColumns);
            Controls.Add(btnGenerateQuery);
            Controls.Add(txtGeneratedSQLCode);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(groupBox1);
            Name = "ctrlCreateQuery";
            Size = new Size(849, 739);
            Load += ctrlCreateQuery_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvColumns).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTableName2;
        private Label label7;
        private GroupBox groupBox1;
        private ComboBox cmbTableType;
        private Label label5;
        private TextBox txtWhereCondition;
        private Label label4;
        private DataGridView dgvColumns;
        private TextBox txtTableName1;
        private Label label3;
        private TextBox txtDBName;
        private Button btnGenerateQuery;
        private RichTextBox txtGeneratedSQLCode;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label6;
        private TextBox txtFKName;
        private Button btnClear;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewComboBoxColumn DataType;
        private DataGridViewCheckBoxColumn AllowNull;
        private DataGridViewCheckBoxColumn PrimaryKey;
        private DataGridViewCheckBoxColumn ForeignKey;
        private DataGridViewCheckBoxColumn Identity;
        private DataGridViewTextBoxColumn DefaultValue;
        private Label label9;
        private Label label8;
    }
}
