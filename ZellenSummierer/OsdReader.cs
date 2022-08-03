using GemBox.Spreadsheet;

namespace ZellenSummierer
{
    internal class OsdReader
    {

        public static double zellenValue(string path,string column, int _cell)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            var workbook = ExcelFile.Load(path);
            ExcelWorksheet worksheet = workbook.Worksheets[0];
            ExcelCell cell = worksheet.Cells[$"{column}{_cell}"];
            var val = cell.Value;
            double value = Math.Round(Convert.ToDouble(val),2);
            return value;
        }
        public static double TotalBruto(string path)
        {
            double value = 0.00;

            for (int i = 20; i <40; i++)
            { 
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            var workbook = ExcelFile.Load(path);
            ExcelWorksheet worksheet = workbook.Worksheets[0];
            ExcelCell cell = worksheet.Cells["D" + i];
                try { 
                var val = cell.Value;
                if (val != null && val.ToString().Contains("Brutto"))
                {
                        value = Math.Round(Convert.ToDouble(zellenValue(path, "E", i)),2);
                }
                }
                catch {
                    continue;
                }
            }
            return value;
        }

    }

}
