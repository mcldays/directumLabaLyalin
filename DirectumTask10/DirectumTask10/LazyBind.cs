namespace DirectumTask10
{
    using System;

    /// <summary>
    /// Defines the <see cref="LazyBind" />.
    /// </summary>
    internal class LazyBind
    {
        /// <summary>
        /// The Draw.
        /// </summary>
        /// <param name="path">The path<see cref="string"/>.</param>
        public static void Draw(string path)
        {
            dynamic excel = Activator.CreateInstance(Type.GetTypeFromProgID("Excel.Application"));

            excel.DisplayAlerts = false;
            excel.Visible = true;
            excel.SheetsInNewWorkbook = 1;
            excel.Workbooks.Add(Type.Missing);

            dynamic worksheet = excel.Worksheets[1];
            worksheet.Name = "Таблица умножения";

            for (int i = 2; i <= 10; i++)
            {
                worksheet.Cells[i, 1] = i - 1;
                worksheet.Cells[1, i] = i - 1;
                for (int j = 2; j <= 10; j++)
                {
                    worksheet.Cells[i, j] = (i - 1) * (j - 1);
                }
            }

            dynamic valueRow = worksheet.Range("A1", "J1");
            dynamic valueColumn = worksheet.Range("A2", "A10");
            valueRow.Cells.Font.Bold = true;
            valueColumn.Cells.Font.Bold = true;

            dynamic allCells = worksheet.Range("A1", "J10");
            dynamic align = Type.GetType("Microsoft.Office.Interop.Excel.XlVAlign");
            dynamic center = align.GetField("xlVAlignCenter").GetValue(align);
            allCells.HorizontalAlignment = center;
            dynamic lineStyle = Type.GetType("Microsoft.Office.Interop.Excel.XlLineStyle");
            dynamic сontinousValue = lineStyle.GetField("xlContinuous").GetValue(lineStyle);
            allCells.Borders.LineStyle = сontinousValue;

            dynamic accessMode = Type.GetType("Microsoft.Office.Interop.Excel.XlSaveAsAccessMode");
            dynamic noChange = accessMode.GetField("xlNoChange").GetValue(accessMode);
            excel.Application.ActiveWorkbook.SaveAs(
                path,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                noChange,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing);
        }
    }
}
