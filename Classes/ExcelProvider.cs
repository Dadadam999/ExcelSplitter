using System;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelSplitter
{
    public class ExcelProvider
    {
        private Excel.Application _excelApplication = new Excel.Application();
        private Excel.Workbook _workbook;
        private Excel.Worksheet _worksheet;
        private ExcelLetter _excelLetter = new ExcelLetter();
        private List<ExcelCell> _range = new List<ExcelCell>();

        public ExcelProvider() => _excelApplication.Visible = false;
        public void SelectWorksheet(int numberSheet) => _worksheet = (Excel.Worksheet)_workbook.Sheets[numberSheet];
        public void CloseFile() => _workbook.Close(false, Type.Missing, Type.Missing);
        public void CloseExcel() => _excelApplication.Quit();
        public void OpenExcel() => _excelApplication = new Excel.Application();

        public void OpenFile(string filePath)
        {
            _workbook = _excelApplication.Workbooks.Open(filePath, 0, false, 5, "", "", false, Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            SelectWorksheet(1);
        }

        public List<ExcelCell> GetRange(ExcelCell startRange, ExcelCell endRange)
        {
            _range.Clear();

            if (_workbook != null && _worksheet != null)
            {
                for (int column = _excelLetter.GetNumber(startRange.Letter); column <= _excelLetter.GetNumber(endRange.Letter); column++)
                    for (int row = startRange.Number; row <= endRange.Number; row++)
                        _range.Add(new ExcelCell
                        {
                            Letter = _excelLetter.GetLetter(column),
                            Number = row,
                            Value = _worksheet.get_Range(_excelLetter.GetLetter(column) + row.ToString(), _excelLetter.GetLetter(column) + row.ToString()).Text
                        });
            }

            return _range;
        }
    }
}
