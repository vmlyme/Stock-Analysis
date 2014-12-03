using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Compression;
//using Excel = Microsoft.Office.Interop.Excel;
//using System.Data.OleDb;
using System.Globalization;
using Excel;

namespace StockeAnalysisApplication
{
    public partial class frmStockCluster : Form
    {
        public frmStockCluster()
        {
            InitializeComponent();
        }
        private string[,] data;
        private int rows = -1, column = -1;
        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            //show depend tree with selected parameters and alogithm

        }

        private void btnSeeChart_Click(object sender, EventArgs e)
        {
            //select a stock name-> choose a period time from... to....->show a chart of this stock that selected
            
            
        }
        public static DateTime DateFromExcelFormat(string ExcelCellValue)
        {
            IFormatProvider culture = new System.Globalization.CultureInfo("fr-FR", true);
            string _date = ExcelCellValue.Substring(8, 2) + "/" + ExcelCellValue.Substring(5, 1) + ExcelCellValue.Substring(7, 1) +"/" + ExcelCellValue.Substring(0, 2)+ExcelCellValue.Substring(3, 2);
            DateTime date = DateTime.Parse(_date, culture, System.Globalization.DateTimeStyles.AssumeLocal);
            return date;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog()==DialogResult.OK){
                textEdit1.Text = openFileDialog.FileName.ToString();
            }
            //get size of excel
            foreach (var worksheet in Workbook.Worksheets(openFileDialog.FileName.ToString()))
            {
                foreach (var row in worksheet.Rows)
                {
                    rows++;
                    foreach (var cell in row.Cells)
                    {
                        if (cell != null)
                        {
                            if(rows==0) column++;
                        }
                    }
                }
                break;
            }
            
            //get data to array data
            data = new string[rows + 1, column + 1];
            foreach (var worksheet in Workbook.Worksheets(openFileDialog.FileName.ToString()))
            {
                int i = 0,j;
                foreach (var row in worksheet.Rows)
                {
                    j = 0;
                    foreach (var cell in row.Cells)
                    {
                        if (cell != null && j<=column)
                        {
                            data[i,j] = cell.Text;
                            j++;
                        }
                    }
                    i++;

                }
                break;
            }

            //Clear StockList
            cklStockList.Items.Clear();
            //Add items to StockList

            for(int i=1;i<rows;i++)
            {
                cklStockList.Items.Add(data[i,0]);
            }
            //Add items to date time picker
            dateTimeBegin.Value = DateFromExcelFormat(data[0, column]);

            dateTimeEnd.Value = DateFromExcelFormat(data[0, 1]);

            
            
        }
    }
}
