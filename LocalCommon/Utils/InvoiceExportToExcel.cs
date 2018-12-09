using Common.Model;
using Common.ModelToBlClient.Invoice;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalCommon.Utils
{
    public class InvoiceExcportToExcel :IInvoiceExport
    {
        public string FilePath { get; set; }

        public void Export(ClientInvoice clientInvoice)
        {
            ExcelPackage excel = new ExcelPackage();
            excel.Workbook.Worksheets.Add("Client");
            GetExcelClient(excel, clientInvoice);

            foreach (var item in clientInvoice.LineInvoices)
            {
                GetExcelLine(excel, item);
            }

            SaveAsExcel(excel, FilePath);
        }


        private void SaveAsExcel(ExcelPackage excel, string filePath)
        {
            using (excel)
            {
                
                FileInfo excelFile = new FileInfo(filePath);
                excel.SaveAs(excelFile);
                
            }
        }

        private void GetExcelClient(ExcelPackage excel, ClientInvoice clientInvoice)
        {
            var headerRow = new List<string[]>()
  {
    new string[] { "Client Name", "Month","Year", "Total Price","",}
  };
            // Determine the header range (e.g. A1:D1)
            string headerRange = "A1:" + Char.ConvertFromUtf32(headerRow[0].Length + 64) + "1";
            // Target a worksheet
            var worksheet = excel.Workbook.Worksheets["Client"];
            // Populate header row data
            worksheet.Cells[headerRange].LoadFromArrays(headerRow);
            worksheet.Cells[headerRange].Style.Font.Bold = true;
            worksheet.Cells[headerRange].Style.Font.Size = 14;
            worksheet.Cells[headerRange].Style.Font.Color.SetColor(System.Drawing.Color.Blue);

            var headerRowData = new List<string[]>()
  {
    new string[] { clientInvoice.ClientName, clientInvoice.Month.ToString(), clientInvoice.Year.ToString(), clientInvoice.TotalPrice.ToString(),"",}
  };
            string headerRangeData = "A2:" + Char.ConvertFromUtf32(headerRowData[0].Length + 64) + "2";
            worksheet.Cells[headerRangeData].LoadFromArrays(headerRowData);
            var cellData = new List<object[]>()
           ;
            cellData.Add(new object[] { "Line", "Package Price", "Out Of Package Total Price", "Total Price" });
            foreach (var item in clientInvoice.LineInvoices)
            {
                cellData.Add(new object[] { item.LineNumber, item.PackagePrice, item.OutOfPackageTotalPrice, item.TotalPrice });
            }
            worksheet.Cells[5, 2].LoadFromArrays(cellData);
            worksheet.Cells["A2:E2"].Style.Font.Bold = true;
            worksheet.Cells["B5:E5"].Style.Font.Bold = true;
            worksheet.DefaultColWidth = 25;

        }

        private void GetExcelLine(ExcelPackage excel, LineInvoice lineInvoice)
        {
            string nameWorksheets = "Line ";
            nameWorksheets += lineInvoice.LineNumber;
            excel.Workbook.Worksheets.Add(nameWorksheets);

            var worksheet = excel.Workbook.Worksheets[nameWorksheets];
            worksheet.Cells[2, 2].Value = "Line Number";
            worksheet.Cells[2, 2].Style.Font.Bold = true;
            worksheet.Cells[2, 3].Style.Font.Bold = true;
            worksheet.Cells[2, 3].Value = lineInvoice.LineNumber;


            var headerRowData = new List<string[]>()
  {
    new string[] { "Price",Math.Round( lineInvoice.TotalPrice,2).ToString(), "Package info", lineInvoice.PackageInfo,""
       }
  };
            string headerRangeData = "B3:" + Char.ConvertFromUtf32(headerRowData[0].Length + 64) + "3";
            worksheet.Cells[headerRangeData].LoadFromArrays(headerRowData);
            worksheet.Cells[headerRangeData].Style.Font.Bold = true;
            worksheet.Cells[headerRangeData].Style.Font.Size = 12;
            
            worksheet.Cells[2, 2, 3, 3].Style.Font.Color.SetColor(System.Drawing.Color.Blue);

            worksheet.Cells[5, 2].Value = "Package";
            worksheet.Cells[5, 2].Style.Font.Bold = true;
            worksheet.Cells[5, 2].Style.Font.Size = 12;
            worksheet.Cells[5, 2].Style.Font.UnderLine = true;
            headerRowData = new List<string[]>()
  {
    new string[] { "Minutes",lineInvoice.Minutes.ToString(), "Minutes Left In Package", lineInvoice.MinutesLeftInPackage.ToString(),
        "Package % Usage", lineInvoice.PackagePercentUsage.ToString()+"%"}
  };
            headerRangeData = "B6:" + Char.ConvertFromUtf32(headerRowData[0].Length + 64) + "6";
            worksheet.Cells[headerRangeData].LoadFromArrays(headerRowData);

            headerRowData = new List<string[]>()
  {
    new string[] { "Package Price","", "", "",
       "", lineInvoice.PackagePrice.ToString()}
  };
            headerRangeData = "B7:" + Char.ConvertFromUtf32(headerRowData[0].Length + 64) + "7";
            worksheet.Cells[headerRangeData].LoadFromArrays(headerRowData);
            worksheet.Cells[headerRangeData].Style.Font.Bold = true;

            worksheet.Cells[9, 2].Value = "Out of Package";
            worksheet.Cells[9, 2].Style.Font.Bold = true;
            worksheet.Cells[9, 2].Style.Font.Size = 12;
            worksheet.Cells[9, 2].Style.Font.UnderLine = true;

            headerRowData = new List<string[]>()
  {
    new string[] { "Minutes Beyond Package Limit",Math.Round(lineInvoice.MinutesBeyondPackageLimit,2).ToString(), "Price Per Minute", lineInvoice.MinutePrice.ToString(),
        "Total", lineInvoice.TotalMinutesPrice.ToString()}
  };
            headerRangeData = "B10:" + Char.ConvertFromUtf32(headerRowData[0].Length + 64) + "10";
            worksheet.Cells[headerRangeData].LoadFromArrays(headerRowData);

            headerRowData = new List<string[]>()
  {
    new string[] { "SMS Beyond Package Limit",lineInvoice.SMS.ToString(), "Price Per SMS", lineInvoice.SMSPrice.ToString(),
        "Total", lineInvoice.TotalSMSPrice.ToString()}
  };
            headerRangeData = "B11:" + Char.ConvertFromUtf32(headerRowData[0].Length + 64) + "11";
            worksheet.Cells[headerRangeData].LoadFromArrays(headerRowData);

            headerRowData = new List<string[]>()
  {
    new string[] { "Out of Package Price","", "", "",
       "", lineInvoice.OutOfPackageTotalPrice.ToString()}
  };
            headerRangeData = "B12:" + Char.ConvertFromUtf32(headerRowData[0].Length + 64) + "12";
            worksheet.Cells[headerRangeData].Style.Font.Bold = true;
            worksheet.Cells[headerRangeData].LoadFromArrays(headerRowData);

            worksheet.DefaultColWidth = 15;
            worksheet.Cells[7, 7].Style.Font.Bold = true;
            worksheet.Cells[12, 7].Style.Font.Bold = true;
        }
    }
}
