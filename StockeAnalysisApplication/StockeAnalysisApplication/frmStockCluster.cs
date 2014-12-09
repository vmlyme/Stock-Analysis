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
        private double[,] dtw;
        double[,] dtw_;
        private int rows = -1, column = -1;
        
        private DateTime DateFromExcelFormat(string ExcelCellValue)
        {
            IFormatProvider culture = new System.Globalization.CultureInfo("fr-FR", true);
            string _date = ExcelCellValue.Substring(8, 2) + "/" + ExcelCellValue.Substring(5, 1) + ExcelCellValue.Substring(7, 1) +"/" + ExcelCellValue.Substring(0, 2)+ExcelCellValue.Substring(3, 2);
            DateTime date = DateTime.Parse(_date, culture, System.Globalization.DateTimeStyles.AssumeLocal);
            return date;
        }
        private double min_array(double[,] a, int x, int y)
        {
            double min = 999999;
            for (int i = 1; i < x-1; i++)
            {
                for (int j = i+1; j < y; j++)
                {
                    min = Math.Min(min, a[i, j]);
                }
            }
            return min;
        }
        private double min(double a, double b, double c)
        {
            if (a < b && a < c) return a;
            else if (b < a && b < c) return b;
            else return c;
        }
        private double dtw_sup(int a, int b, int i, int j)
        {
            if (i == 0 && j == 0) return 0;
            else if (i == 0) return double.Parse(data[a, j]) + dtw_[i, j - 1];
            else if (j == 0) return double.Parse(data[b, i]) + dtw_[i - 1, j];
            else return Math.Abs(double.Parse(data[a, i]) - double.Parse(data[b, j])) + min(dtw_[i - 1, j], dtw_[i, j - 1], dtw_[i - 1, j - 1]);
        }
        private double DTW(int a, int b, int x, int y) 
        {
            dtw_ = new double[y-x,y-x];
            for (int i = 0; i < (y - x); i++) 
            {
                for (int j = 0; j < (y - x); j++)
                {
                    dtw_[i, j] = dtw_sup(a, b, i, j);
                }
            }
            return dtw_[y-x-1,y-x-1];
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

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            dtw = new double[rows, rows];
            string test="";
            for (int i = 1; i < rows-1; i++) 
            {
                for (int j = i+1; j < rows; j++)
                {
                    dtw[i,j] = DTW(i,j,1,column);
                    test+=dtw[i, j].ToString()+" ";
                }
                test += "\n";
            }
            MessageBox.Show(test);
            MessageBox.Show(min_array(dtw,rows,rows).ToString());

        }

        private void btnSeeChart_Click(object sender, EventArgs e)
        {
            //select a stock name-> choose a period time from... to....->show a chart of this stock that selected


        }
    }
}
