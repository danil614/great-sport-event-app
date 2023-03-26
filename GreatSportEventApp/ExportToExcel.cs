using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GreatSportEventApp
{
    public static class ExportToExcel
    {
        public static void Do(DataGridView dataGridView)
        {
            SaveFileDialog saveFileDialog = new();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            var dialogResult = saveFileDialog.ShowDialog();

            if (dialogResult != DialogResult.OK)
                return;

            // Получаем выбранный файл
            string filename = saveFileDialog.FileName;

            // Приложение
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;

            // Книга
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);

            // Таблица
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int j = 0; j < dataGridView.ColumnCount; j++)
            {
                ExcelApp.Cells[1, j + 1] = dataGridView.Columns[j].HeaderText.ToString();
            }

            for (int i = 1; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = dataGridView.Rows[i].Cells[j].Value;
                }
            }

            // Вызываем нашу созданную эксельку.
            // ExcelApp.Visible = true;
            // ExcelApp.UserControl = true;

            ExcelWorkBook.SaveAs(filename);
            ExcelWorkBook.Close();

            MessageBox.Show(@"Файл Excel сохранен!");
        }
    }
}
