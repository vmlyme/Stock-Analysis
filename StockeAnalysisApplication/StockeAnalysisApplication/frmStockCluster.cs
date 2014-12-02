using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockeAnalysisApplication
{
    public partial class frmStockCluster : Form
    {
        public frmStockCluster()
        {
            InitializeComponent();
        }
        //public DataSet loadFromDataBaseToDataFrame
        //{
            
        //    //return a dataset
        // //   return;
        //}
        //public DistMatrix findDistMatrix(DataSet dt)
        //{
        //    //return distance matrix of imported dataset
        //}
      //public float findDistance(VectorDataTimeSeri stock1,VectorDataTimeSeri stock2,string method)
      //{
      //  if(method=="Euclipdean")
      //  {
      //       return 1;
      //  }
      //  if(method=="DTW")
      //  {
      //       return 1;
      //  }
      //  return 0;
      //}
      

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            //show depend tree with selected parameters and alogithm

        }

        private void btnSeeChart_Click(object sender, EventArgs e)
        {
            //select a stock name-> choose a period time from... to....->show a chart of this stock that selected
            
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
