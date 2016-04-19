using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open the Excel application.
            Microsoft.Office.Interop.Excel._Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            // Add a workbook.
            Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet sheet = workbook.Worksheets[1];
            // Display Excel.
            excelApp.Visible = true;
            // Display some column headers.
            //Line and column
            sheet.Cells[1, 1].Value = "Value";
            sheet.Cells[1, 2].Value = "Value Squared";
            sheet.Cells[1, 3].Value = "Chupeta Mala";

            // Display the first 10 squares.
            for (int i = 1; i <= 10; i++)
            {
                sheet.Cells[i + 1, 1].Value = i;
                sheet.Cells[i + 1, 2].Value = (i * i).ToString();
                sheet.Cells[1, 1].Sexo = i;

            }
            // Autofit the columns.
            sheet.Columns[1].AutoFit();
            sheet.Columns[2].AutoFit();
        }
    }
}
