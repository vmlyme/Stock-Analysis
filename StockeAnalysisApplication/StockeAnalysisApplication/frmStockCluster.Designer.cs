namespace StockeAnalysisApplication
{
    partial class frmStockCluster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAnalysis = new DevExpress.XtraEditors.SimpleButton();
            this.Algorithm = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cklStockList = new System.Windows.Forms.CheckedListBox();
            this.btnCheckAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnSeeChart = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Location = new System.Drawing.Point(12, 350);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(101, 20);
            this.btnAnalysis.TabIndex = 1;
            this.btnAnalysis.Text = "Analysis Cluster";
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // Algorithm
            // 
            this.Algorithm.Location = new System.Drawing.Point(506, 11);
            this.Algorithm.Name = "Algorithm";
            this.Algorithm.Size = new System.Drawing.Size(82, 13);
            this.Algorithm.TabIndex = 3;
            this.Algorithm.Text = "Cluster Algorithm";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(677, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Distance Algorithm";
            // 
            // cklStockList
            // 
            this.cklStockList.FormattingEnabled = true;
            this.cklStockList.Items.AddRange(new object[] {
            "Stock 1",
            "Stock 2",
            "Stock 3",
            "Stock 4",
            "Stock 5",
            "Stock 6",
            "Stock 7",
            "..."});
            this.cklStockList.Location = new System.Drawing.Point(12, 130);
            this.cklStockList.Name = "cklStockList";
            this.cklStockList.Size = new System.Drawing.Size(100, 214);
            this.cklStockList.TabIndex = 6;
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Location = new System.Drawing.Point(13, 101);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(100, 23);
            this.btnCheckAll.TabIndex = 7;
            this.btnCheckAll.Text = "Check All Stock";
            // 
            // btnSeeChart
            // 
            this.btnSeeChart.Location = new System.Drawing.Point(12, 376);
            this.btnSeeChart.Name = "btnSeeChart";
            this.btnSeeChart.Size = new System.Drawing.Size(101, 23);
            this.btnSeeChart.TabIndex = 8;
            this.btnSeeChart.Text = "See chart";
            this.btnSeeChart.Click += new System.EventHandler(this.btnSeeChart_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 75);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Filter";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelControl1.Location = new System.Drawing.Point(151, 78);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(615, 255);
            this.panelControl1.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(486, 33);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(127, 13);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Hierarchical Clustering";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(646, 33);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(130, 13);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Dynamic Time Warping";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(12, 14);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(135, 20);
            this.textEdit1.TabIndex = 14;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(166, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "Import File";
            // 
            // frmStockCluster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 468);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.btnSeeChart);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnCheckAll);
            this.Controls.Add(this.cklStockList);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.Algorithm);
            this.Controls.Add(this.btnAnalysis);
            this.Name = "frmStockCluster";
            this.Text = "Stock Cluster Program";
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAnalysis;
        private DevExpress.XtraEditors.LabelControl Algorithm;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.CheckedListBox cklStockList;
        private DevExpress.XtraEditors.SimpleButton btnCheckAll;
        private DevExpress.XtraEditors.SimpleButton btnSeeChart;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;

    }
}