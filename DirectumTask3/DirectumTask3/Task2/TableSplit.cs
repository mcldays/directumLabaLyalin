namespace DirectumTask3.Task2
{
    using System.Data;

    /// <summary>
    /// Defines the <see cref="TableSplit" />.
    /// </summary>
    internal class TableSplit
    {
        /// <summary>
        /// The Split.
        /// </summary>
        /// <param name="db">The db<see cref="System.Data.DataSet"/>.</param>
        /// <param name="splitterRow">The splitterRow<see cref="char"/>.</param>
        /// <param name="splitterColumn">The splitterColumn<see cref="char"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public string Split(System.Data.DataSet db, char splitterRow, char splitterColumn)
        {
            string data = string.Empty; // Лучше использовать StringBuilder.
            foreach (DataTable table in db.Tables)
            {
                foreach (DataColumn col in table.Columns)
                {
                    data += col.ColumnName + splitterColumn;

                    foreach (DataRow row in table.Rows)
                    {
                        var cells = row.ItemArray;
                        foreach (var cell in cells)
                        {
                            data += cell.ToString() + splitterRow;
                        }
                    }
                }
            }

            return data;
        }
    }
}
