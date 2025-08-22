namespace CodeGeneratore_0._1.UserControls
{
    partial class ctrlCreateDataBase
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
            btnAddTable = new Button();
            cmbDataType = new ComboBox();
            label4 = new Label();
            txtTableName = new TextBox();
            label3 = new Label();
            txtDBName = new TextBox();
            btnGenerateClass = new Button();
            txtGeneratedSQLCode = new RichTextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            chkIdentity = new CheckBox();
            chkPrimaryKey = new CheckBox();
            dgvColumns = new DataGridView();
            ColumnName = new DataGridViewTextBoxColumn();
            DataType = new DataGridViewTextBoxColumn();
            AllowNull = new DataGridViewTextBoxColumn();
            PrimaryKey = new DataGridViewTextBoxColumn();
            ForeignKey = new DataGridViewTextBoxColumn();
            Identity = new DataGridViewTextBoxColumn();
            DefaultValue = new DataGridViewTextBoxColumn();
            txtColumnName = new TextBox();
            label5 = new Label();
            chkAllowNULL = new CheckBox();
            groupBox1 = new GroupBox();
            txtForeinKey = new TextBox();
            label6 = new Label();
            txtFKTable = new TextBox();
            label7 = new Label();
            chkForeignKey = new CheckBox();
            dgvTables = new DataGridView();
            TableName = new DataGridViewTextBoxColumn();
            btnAddColumn = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvColumns).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTables).BeginInit();
            SuspendLayout();
            // 
            // btnAddTable
            // 
            btnAddTable.BackColor = SystemColors.ControlLight;
            btnAddTable.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddTable.Image = Properties.Resources.Add_32;
            btnAddTable.ImageAlign = ContentAlignment.MiddleRight;
            btnAddTable.Location = new Point(347, 274);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(145, 34);
            btnAddTable.TabIndex = 12;
            btnAddTable.Text = "Add  Table";
            btnAddTable.TextAlign = ContentAlignment.MiddleLeft;
            btnAddTable.UseVisualStyleBackColor = false;
            btnAddTable.Click += btnAddTable_Click;
            // 
            // cmbDataType
            // 
            cmbDataType.DisplayMember = "0";
            cmbDataType.FormattingEnabled = true;
            cmbDataType.Items.AddRange(new object[] { "BIT", "TINYINT", "SMALLINT", "INT", "BIGINT", "DECIMAL(18,2)", "DECIMAL(18,3)", "NUMERIC(18,2)", "FLOAT", "REAL", "MONEY", "SMALLMONEY", "CHAR(50)", "VARCHAR(50)", "VARCHAR(100)", "VARCHAR(150)", "VARCHAR(200)", "VARCHAR(MAX)", "TEXT", "NCHAR(50)", "NVARCHAR(50)", "NVARCHAR(MAX)", "NTEXT", "DATE", "DATETIME", "DATETIME2", "SMALLDATETIME", "TIME", "DATETIMEOFFSET", "BINARY(50)", "VARBINARY(50)", "VARBINARY(MAX)", "IMAGE", "UNIQUEIDENTIFIER", "XML", "SQL_VARIANT", "GEOGRAPHY", "GEOMETRY" });
            cmbDataType.Location = new Point(170, 24);
            cmbDataType.Name = "cmbDataType";
            cmbDataType.Size = new Size(192, 23);
            cmbDataType.TabIndex = 3;
            cmbDataType.ValueMember = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(43, 26);
            label4.Name = "label4";
            label4.Size = new Size(111, 16);
            label4.TabIndex = 22;
            label4.Text = "Column Type      :";
            // 
            // txtTableName
            // 
            txtTableName.Location = new Point(585, 92);
            txtTableName.Name = "txtTableName";
            txtTableName.Size = new Size(192, 23);
            txtTableName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(448, 94);
            label3.Name = "label3";
            label3.Size = new Size(111, 16);
            label3.TabIndex = 20;
            label3.Text = "Table Name         :";
            // 
            // txtDBName
            // 
            txtDBName.Location = new Point(215, 90);
            txtDBName.Name = "txtDBName";
            txtDBName.Size = new Size(192, 23);
            txtDBName.TabIndex = 0;
            // 
            // btnGenerateClass
            // 
            btnGenerateClass.BackColor = SystemColors.ControlLight;
            btnGenerateClass.Location = new Point(523, 274);
            btnGenerateClass.Name = "btnGenerateClass";
            btnGenerateClass.Size = new Size(145, 34);
            btnGenerateClass.TabIndex = 13;
            btnGenerateClass.Text = "Create DB";
            btnGenerateClass.UseVisualStyleBackColor = false;
            btnGenerateClass.Click += btnCreateDB_Click;
            // 
            // txtGeneratedSQLCode
            // 
            txtGeneratedSQLCode.BorderStyle = BorderStyle.FixedSingle;
            txtGeneratedSQLCode.Location = new Point(214, 323);
            txtGeneratedSQLCode.Name = "txtGeneratedSQLCode";
            txtGeneratedSQLCode.Size = new Size(257, 300);
            txtGeneratedSQLCode.TabIndex = 17;
            txtGeneratedSQLCode.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(87, 92);
            label2.Name = "label2";
            label2.Size = new Size(109, 16);
            label2.TabIndex = 16;
            label2.Text = "DB Name              :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Ink Free", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(269, 10);
            label1.Name = "label1";
            label1.Size = new Size(416, 62);
            label1.TabIndex = 15;
            label1.Text = "Create Data Base";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Generate_Code_0_1;
            pictureBox2.Location = new Point(164, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(99, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // chkIdentity
            // 
            chkIdentity.AutoSize = true;
            chkIdentity.Location = new Point(369, 109);
            chkIdentity.Name = "chkIdentity";
            chkIdentity.Size = new Size(157, 19);
            chkIdentity.TabIndex = 9;
            chkIdentity.Text = "Idintity (Auto Increment)";
            chkIdentity.UseVisualStyleBackColor = true;
            // 
            // chkPrimaryKey
            // 
            chkPrimaryKey.AutoSize = true;
            chkPrimaryKey.Location = new Point(76, 109);
            chkPrimaryKey.Name = "chkPrimaryKey";
            chkPrimaryKey.Size = new Size(89, 19);
            chkPrimaryKey.TabIndex = 7;
            chkPrimaryKey.Text = "Primary Key";
            chkPrimaryKey.UseVisualStyleBackColor = true;
            // 
            // dgvColumns
            // 
            dgvColumns.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvColumns.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvColumns.Columns.AddRange(new DataGridViewColumn[] { ColumnName, DataType, AllowNull, PrimaryKey, ForeignKey, Identity, DefaultValue });
            dgvColumns.Location = new Point(477, 323);
            dgvColumns.Name = "dgvColumns";
            dgvColumns.Size = new Size(357, 300);
            dgvColumns.TabIndex = 25;
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Column Name";
            ColumnName.Name = "ColumnName";
            // 
            // DataType
            // 
            DataType.HeaderText = "Data Type";
            DataType.Name = "DataType";
            // 
            // AllowNull
            // 
            AllowNull.HeaderText = "Allow NULL";
            AllowNull.Name = "AllowNull";
            // 
            // PrimaryKey
            // 
            PrimaryKey.HeaderText = "Primary Key";
            PrimaryKey.Name = "PrimaryKey";
            // 
            // ForeignKey
            // 
            ForeignKey.HeaderText = "Foreign Key";
            ForeignKey.Name = "ForeignKey";
            // 
            // Identity
            // 
            Identity.HeaderText = "Identity";
            Identity.Name = "Identity";
            // 
            // DefaultValue
            // 
            DefaultValue.HeaderText = "Default Value";
            DefaultValue.Name = "DefaultValue";
            // 
            // txtColumnName
            // 
            txtColumnName.Location = new Point(543, 26);
            txtColumnName.Name = "txtColumnName";
            txtColumnName.Size = new Size(192, 23);
            txtColumnName.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(408, 31);
            label5.Name = "label5";
            label5.Size = new Size(110, 16);
            label5.TabIndex = 29;
            label5.Text = "Column Name    :";
            // 
            // chkAllowNULL
            // 
            chkAllowNULL.AutoSize = true;
            chkAllowNULL.Location = new Point(584, 109);
            chkAllowNULL.Name = "chkAllowNULL";
            chkAllowNULL.Size = new Size(88, 19);
            chkAllowNULL.TabIndex = 10;
            chkAllowNULL.Text = "Allow NULL";
            chkAllowNULL.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtForeinKey);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtFKTable);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(chkForeignKey);
            groupBox1.Controls.Add(chkAllowNULL);
            groupBox1.Controls.Add(cmbDataType);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtColumnName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(chkPrimaryKey);
            groupBox1.Controls.Add(chkIdentity);
            groupBox1.Location = new Point(43, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(762, 142);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Column Specifications";
            // 
            // txtForeinKey
            // 
            txtForeinKey.Location = new Point(172, 60);
            txtForeinKey.Name = "txtForeinKey";
            txtForeinKey.Size = new Size(192, 23);
            txtForeinKey.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.FlatStyle = FlatStyle.Popup;
            label6.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(408, 67);
            label6.Name = "label6";
            label6.Size = new Size(110, 16);
            label6.TabIndex = 34;
            label6.Text = "FK Table               :";
            // 
            // txtFKTable
            // 
            txtFKTable.Location = new Point(543, 62);
            txtFKTable.Name = "txtFKTable";
            txtFKTable.Size = new Size(192, 23);
            txtFKTable.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(43, 62);
            label7.Name = "label7";
            label7.Size = new Size(110, 16);
            label7.TabIndex = 33;
            label7.Text = "Foreign Key        :";
            // 
            // chkForeignKey
            // 
            chkForeignKey.AutoSize = true;
            chkForeignKey.Location = new Point(223, 109);
            chkForeignKey.Name = "chkForeignKey";
            chkForeignKey.Size = new Size(88, 19);
            chkForeignKey.TabIndex = 8;
            chkForeignKey.Text = "Foreign Key";
            chkForeignKey.UseVisualStyleBackColor = true;
            // 
            // dgvTables
            // 
            dgvTables.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTables.Columns.AddRange(new DataGridViewColumn[] { TableName });
            dgvTables.Location = new Point(15, 323);
            dgvTables.Name = "dgvTables";
            dgvTables.Size = new Size(193, 300);
            dgvTables.TabIndex = 29;
            // 
            // TableName
            // 
            TableName.HeaderText = "Table Name";
            TableName.Name = "TableName";
            // 
            // btnAddColumn
            // 
            btnAddColumn.BackColor = SystemColors.ControlLight;
            btnAddColumn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddColumn.Image = Properties.Resources.Add_32;
            btnAddColumn.ImageAlign = ContentAlignment.MiddleRight;
            btnAddColumn.Location = new Point(180, 274);
            btnAddColumn.Name = "btnAddColumn";
            btnAddColumn.Size = new Size(145, 34);
            btnAddColumn.TabIndex = 11;
            btnAddColumn.Text = "Add  Column";
            btnAddColumn.TextAlign = ContentAlignment.MiddleLeft;
            btnAddColumn.UseVisualStyleBackColor = false;
            btnAddColumn.Click += btnAddColumn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(43, 633);
            label8.Name = "label8";
            label8.Size = new Size(534, 14);
            label8.TabIndex = 53;
            label8.Text = "* To Create Data Base Add DB Name and Create DB , will give you only query for create data base.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Maroon;
            label9.Location = new Point(43, 656);
            label9.Name = "label9";
            label9.Size = new Size(270, 14);
            label9.TabIndex = 54;
            label9.Text = "* if you need to make tables inside data base :  ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.Control;
            label10.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Maroon;
            label10.Location = new Point(75, 679);
            label10.Name = "label10";
            label10.Size = new Size(627, 14);
            label10.TabIndex = 55;
            label10.Text = "- fill table name and add column specifications and press Add column after finish the all columns press add table.";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.Control;
            label11.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Maroon;
            label11.Location = new Point(43, 702);
            label11.Name = "label11";
            label11.Size = new Size(461, 14);
            label11.TabIndex = 56;
            label11.Text = "* After That Press Generate DB , Will Generate DB with all tables that  you inserted.";
            // 
            // ctrlCreateDataBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(btnAddColumn);
            Controls.Add(dgvTables);
            Controls.Add(dgvColumns);
            Controls.Add(btnAddTable);
            Controls.Add(txtTableName);
            Controls.Add(label3);
            Controls.Add(txtDBName);
            Controls.Add(btnGenerateClass);
            Controls.Add(txtGeneratedSQLCode);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(groupBox1);
            Name = "ctrlCreateDataBase";
            Size = new Size(849, 739);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvColumns).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTables).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddTable;
        private ComboBox cmbDataType;
        private Label label4;
        private TextBox txtTableName;
        private Label label3;
        private TextBox txtDBName;
        private Button btnGenerateClass;
        private RichTextBox txtGeneratedSQLCode;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private CheckBox chkIdentity;
        private CheckBox chkPrimaryKey;
        private DataGridView dgvColumns;
        private TextBox txtColumnName;
        private Label label5;
        private CheckBox chkAllowNULL;
        private GroupBox groupBox1;
        private DataGridView dgvTables;
        private Button btnAddColumn;
        private DataGridViewTextBoxColumn TableName;
        private TextBox txtForeinKey;
        private Label label6;
        private TextBox txtFKTable;
        private Label label7;
        private CheckBox chkForeignKey;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn DataType;
        private DataGridViewTextBoxColumn AllowNull;
        private DataGridViewTextBoxColumn PrimaryKey;
        private DataGridViewTextBoxColumn ForeignKey;
        private DataGridViewTextBoxColumn Identity;
        private DataGridViewTextBoxColumn DefaultValue;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}
