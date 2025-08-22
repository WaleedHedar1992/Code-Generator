using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGeneratore_0._1.UserControls
{
    public partial class ctrlCreateDataBase : UserControl
    {
        public ctrlCreateDataBase()
        {
            InitializeComponent();
        }

        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtColumnName.Text) || cmbDataType.SelectedItem == null)
            {
                MessageBox.Show("Please enter column name and select data type.");
                return;
            }

            // the default value can be set to a specific value or left empty
            string defaultValue = ""; // to collect from a TextBox or similar control if needed

            dgvColumns.Rows.Add(
                txtColumnName.Text.Trim(),
                cmbDataType.SelectedItem.ToString(),
                chkAllowNULL.Checked,
                chkPrimaryKey.Checked,
                chkForeignKey.Checked,
                chkIdentity.Checked,
                defaultValue
            );

            // you can also add logic to handle foreign key and identity columns if needed

            // clear the input fields after adding the column
            txtColumnName.Clear();
            chkAllowNULL.Checked = false;
            chkPrimaryKey.Checked = false;
            chkForeignKey.Checked = false;
            chkIdentity.Checked = false;
        }


        Dictionary<string, List<DataGridViewRow>> tablesColumns = new Dictionary<string, List<DataGridViewRow>>();

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTableName.Text))
            {
                MessageBox.Show("Please enter table name.");
                return;
            }

            string tableName = txtTableName.Text.Trim();

            if (tablesColumns.ContainsKey(tableName))
            {
                MessageBox.Show("Table already exists.");
                return;
            }

            // copy the columns from dgvColumns to a list
            var columnsList = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dgvColumns.Rows)
            {
                if (!row.IsNewRow)
                {
                    columnsList.Add(row);
                }
            }

            if (columnsList.Count == 0)
            {
                MessageBox.Show("Please add columns for the table first.");
                return;
            }

            tablesColumns.Add(tableName, columnsList);

            // add the table to the DataGridView
            dgvTables.Rows.Add(tableName);

            // clear the input fields after adding the table
            txtTableName.Clear();
            dgvColumns.Rows.Clear();
        }


        private void btnCreateDB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDBName.Text))
            {
                MessageBox.Show("Please enter database name.");
                return;
            }

            if (tablesColumns.Count == 0)
            {
                MessageBox.Show("Please add at least one table.");
                return;
            }

            StringBuilder sql = new StringBuilder();

            string dbName = txtDBName.Text.Trim();

            sql.AppendLine($"CREATE DATABASE [{dbName}];");
            sql.AppendLine($"USE [{dbName}];");
            sql.AppendLine();

            foreach (var tableEntry in tablesColumns)
            {
                string tableName = tableEntry.Key;
                var columns = tableEntry.Value;

                sql.AppendLine($"CREATE TABLE [{tableName}] (");

                List<string> columnDefs = new List<string>();
                List<string> primaryKeys = new List<string>();
                List<string> foreignKeys = new List<string>();

                foreach (DataGridViewRow colRow in columns)
                {
                    string? colName = colRow.Cells["ColumnName"].Value?.ToString();
                    string? dataType = colRow.Cells["DataType"].Value?.ToString();
                    bool allowNull = Convert.ToBoolean(colRow.Cells["AllowNULL"].Value ?? false);
                    bool primaryKey = Convert.ToBoolean(colRow.Cells["PrimaryKey"].Value ?? false);
                    bool foreignKey = Convert.ToBoolean(colRow.Cells["ForeignKey"].Value ?? false);
                    bool identity = Convert.ToBoolean(colRow.Cells["Identity"].Value ?? false);
                    string defaultValue = colRow.Cells["Default Value"].Value?.ToString() ?? string.Empty;



                    if (string.IsNullOrWhiteSpace(colName) || string.IsNullOrWhiteSpace(dataType))
                        continue;

                    StringBuilder colDef = new StringBuilder();
                    colDef.Append($"[{colName}] {dataType}");

                    if (identity)
                        colDef.Append(" IDENTITY(1,1)");

                    colDef.Append(allowNull ? " NULL" : " NOT NULL");

                    if (!string.IsNullOrWhiteSpace(defaultValue))
                        colDef.Append($" DEFAULT {defaultValue}");

                    columnDefs.Add(colDef.ToString());

                    if (primaryKey)
                        primaryKeys.Add(colName);

                    if (foreignKey)
                    {
                        // you can add logic to handle foreign keys here
                        // or add additional columns for FKTable and FKColumn

                        string fkTable = ""; // like from a cell FKTable
                        string fkColumn = ""; // or FKColumn

                        // take FKTable and FKColumn from the DataGridView if they exist
                        if (dgvColumns.Columns.Contains("FKTable") && dgvColumns.Columns.Contains("FKColumn"))
                        {
                            fkTable = colRow.Cells["FKTable"].Value?.ToString() ?? "";
                            fkColumn = colRow.Cells["FKColumn"].Value?.ToString() ?? "";
                        }

                        if (!string.IsNullOrWhiteSpace(fkTable) && !string.IsNullOrWhiteSpace(fkColumn))
                        {
                            string fkName = $"FK_{tableName}_{colName}_{fkTable}_{fkColumn}";
                            foreignKeys.Add(
                                $"ALTER TABLE [{tableName}] ADD CONSTRAINT [{fkName}] FOREIGN KEY ([{colName}]) REFERENCES [{fkTable}]([{fkColumn}]);"
                            );
                        }
                    }
                }

                sql.AppendLine(string.Join(",\n", columnDefs));

                if (primaryKeys.Count > 0)
                {
                    string pkConstraint = $"CONSTRAINT [PK_{tableName}] PRIMARY KEY ({string.Join(", ", primaryKeys.Select(c => $"[{c}]"))})";
                    sql.AppendLine($",\n{pkConstraint}");
                }

                sql.AppendLine(");");
                sql.AppendLine();

                // Add foreign key constraints if it's exist
                foreach (var fk in foreignKeys)
                {
                    sql.AppendLine(fk);
                }

                sql.AppendLine();
            }

            txtGeneratedSQLCode.Text = sql.ToString();
        }




    }
}
