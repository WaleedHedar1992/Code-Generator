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
    public partial class ctrlCreateQuery : UserControl
    {
        public ctrlCreateQuery()
        {
            InitializeComponent();
        }

        private void btnGenerateQuery_Click(object sender, EventArgs e)
        {
            string dbName = txtDBName.Text.Trim();
            string tableName1 = txtTableName1.Text.Trim();
            string tableName2 = txtTableName2.Text.Trim();
            string fkName = txtFKName.Text.Trim();
            string whereCondition = txtWhereCondition.Text.Trim();
            string? tableType = cmbTableType.SelectedItem?.ToString();
         

            if (string.IsNullOrEmpty(tableType))
            {
                MessageBox.Show("Please select a table/query type.");
                return;
            }


            string query = "";

            switch (tableType.ToUpper())
            {
                case "CREATE DATABASE":

                    if (!AreAllDataTypesSelected())
                    {
                        MessageBox.Show("Please select data type for all columns.");
                        return;
                    }

                    query = $"CREATE DATABASE [{dbName}];";
                    break;

                case "CREATE TABLE":
                    query = GenerateCreateTableQuery(tableName1);
                    break;

                case "INSERT":

                    if (!AreAllDataTypesSelected())
                    {
                        MessageBox.Show("Please select data type for all columns.");
                        return;
                    }

                    query = $"INSERT INTO {tableName1} ({GetColumnNames()}) VALUES ({GetColumnParams()});";
                    break;

                case "UPDATE":

                    if (!AreAllDataTypesSelected())
                    {
                        MessageBox.Show("Please select data type for all columns.");
                        return;
                    }
                    query = $"UPDATE {tableName1} SET {GetUpdateSetClause()} WHERE {whereCondition};";
                    break;

                case "DELETE":
                    query = $"DELETE FROM {tableName1} WHERE {whereCondition};";
                    break;

                case "SELECT *":
                    query = $"SELECT * FROM {tableName1};";
                    break;

                case "SELECT * (WHERE)":
                    query = $"SELECT * FROM {tableName1} WHERE {whereCondition};";
                    break;

                case "INNER JOIN":
                    query = $"SELECT * FROM {tableName1} INNER JOIN {tableName2} ON {tableName1}.{fkName} = {tableName2}.{fkName};";
                    break;

                case "LEFT JOIN":
                    query = $"SELECT * FROM {tableName1} LEFT JOIN {tableName2} ON {tableName1}.{fkName} = {tableName2}.{fkName};";
                    break;

                case "CREATE VIEW":
                    query = $"CREATE VIEW MyView AS SELECT * FROM {tableName1};";
                    break;

                default:
                    MessageBox.Show("Unsupported query type selected.");
                    return;
            }

            
            txtGeneratedSQLCode.Text = query;
        }

        // this method collects column names from the DataGridView
        private string GetColumnNames()
        {
            List<string> cols = new List<string>();

            foreach (DataGridViewRow row in dgvColumns.Rows)
            {
                if (row.IsNewRow) continue;
                var cellValue = row.Cells["ColumnName"].Value;
                string? colName = cellValue as string;
                if (!string.IsNullOrEmpty(colName))
                    cols.Add(colName);
            }
            return string.Join(", ", cols);
        }

        private string GetColumnParams()
        {
            List<string> cols = new List<string>();
            foreach (DataGridViewRow row in dgvColumns.Rows)
            {
                if (row.IsNewRow) continue;
                cols.Add("@" + row.Cells["ColumnName"].Value?.ToString());
            }
            return string.Join(", ", cols);
        }

        private string GetUpdateSetClause()
        {
            List<string> sets = new List<string>();
            foreach (DataGridViewRow row in dgvColumns.Rows)
            {
                if (row.IsNewRow) continue;
                string? colName = row.Cells["ColumnName"].Value?.ToString();
                if (!string.IsNullOrEmpty(colName))
                    sets.Add($"{colName} = @" + colName);
            }

            return string.Join(", ", sets);
        }

        private string GenerateCreateTableQuery(string tableName)
        {
            List<string> columnDefs = new List<string>();
            List<string> primaryKeys = new List<string>();
            List<string> foreignKeys = new List<string>();

            foreach (DataGridViewRow row in dgvColumns.Rows)
            {
                if (row.IsNewRow) continue;

                string? colName = row.Cells["ColumnName"].Value?.ToString();
                string? dataType = row.Cells["DataType"].Value?.ToString();
                bool allowNull = Convert.ToBoolean(row.Cells["AllowNull"].Value ?? false);
                bool primaryKey = Convert.ToBoolean(row.Cells["PrimaryKey"].Value ?? false);
                bool foreignKey = Convert.ToBoolean(row.Cells["ForeignKey"].Value ?? false);
                bool identity = Convert.ToBoolean(row.Cells["Identity"].Value ?? false);

                string fkTable = txtFKName.Text ?? string.Empty;
                string fkColumn = row.Cells["ForeignKey"]?.Value?.ToString() ?? string.Empty;

                if (string.IsNullOrWhiteSpace(colName) || string.IsNullOrWhiteSpace(dataType))
                    continue;

                // defining the column definition
                string colDef = $"[{colName}] {dataType}";

                if (identity)
                    colDef += " IDENTITY(1,1)";

                colDef += allowNull ? " NULL" : " NOT NULL";

                columnDefs.Add(colDef);

                if (primaryKey)
                    primaryKeys.Add(colName);

                if (foreignKey && !string.IsNullOrEmpty(fkTable) && !string.IsNullOrEmpty(fkColumn))
                    foreignKeys.Add($"FOREIGN KEY ([{colName}]) REFERENCES [{fkTable}]([{fkColumn}])");
            }

            // building the primary key clause
            string pkClause = "";
            if (primaryKeys.Count > 0)
                pkClause = $", PRIMARY KEY ({string.Join(", ", primaryKeys.Select(c => $"[{c}]"))})";

            // collecting foreign key clauses
            string fkClauses = "";
            if (foreignKeys.Count > 0)
                fkClauses = ", " + string.Join(", ", foreignKeys);

            string createTableSql = $"CREATE TABLE [{tableName}] (\n    {string.Join(",\n    ", columnDefs)}{pkClause}{fkClauses}\n);";

            return createTableSql;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDBName.Clear();
            txtTableName1.Clear();
            txtTableName2.Clear();
            txtFKName.Clear();
            txtWhereCondition.Clear();
            cmbTableType.SelectedIndex = 1;
            dgvColumns.Rows.Clear();
            txtGeneratedSQLCode.Clear();

        }

        private void ctrlCreateQuery_Load(object sender, EventArgs e)
        {
            cmbTableType.SelectedIndex = 1;
        }

        private bool AreAllDataTypesSelected()
        {
            foreach (DataGridViewRow row in dgvColumns.Rows)
            {
                if (row.IsNewRow) continue;
                var dataType = row.Cells["DataType"].Value?.ToString();
                if (string.IsNullOrWhiteSpace(dataType))
                    return false;
            }
            return true;
        }

    }
}
