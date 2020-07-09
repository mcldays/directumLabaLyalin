namespace DirectumTask10
{
    using Microsoft.Office.Interop.Excel;
    using System;

    /// <summary>
    /// Defines the <see cref="EarlyBind" />.
    /// </summary>
    public class EarlyBind
    {
        /// <summary>
        /// The Draw.
        /// </summary>
        /// <param name="path">The path<see cref="string"/>.</param>
        public static void Draw(string path)
        {
            var excel = new Application();
            excel.DisplayAlerts = false;
            excel.Visible = true;
            excel.SheetsInNewWorkbook = 1;
            excel.Workbooks.Add(Type.Missing);

            Worksheet worksheet = excel.Worksheets[1];
            worksheet.Name = "Таблица умножения";

            for (int i = 2; i <= 10; i++)      // Кажется было бы более понятно, если бы i был с 1 до 10
            {
                worksheet.Cells[i, 1] = i - 1;
                worksheet.Cells[1, i] = i - 1;
                for (int j = 2; j <= 10; j++)
                {
                    worksheet.Cells[i, j] = (i - 1) * (j - 1);
                }
            }

            Range valueRow = worksheet.get_Range("A1", "J1");
            Range valueColumn = worksheet.get_Range("A2", "A10");
            valueRow.Cells.Font.Bold = true;
            valueColumn.Cells.Font.Bold = true;

            Range allCells = worksheet.get_Range("A1", "J10");
            allCells.HorizontalAlignment = XlVAlign.xlVAlignCenter;
            allCells.Borders.LineStyle = XlLineStyle.xlContinuous;

            excel.Application.ActiveWorkbook.SaveAs(
                path,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                XlSaveAsAccessMode.xlNoChange,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing);
        }
    }
}
