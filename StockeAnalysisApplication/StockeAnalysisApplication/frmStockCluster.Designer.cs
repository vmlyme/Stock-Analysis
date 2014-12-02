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
            this.cmdClusterAlgorithm = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Algorithm = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdDistanceAlgorithm = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cklStockList = new System.Windows.Forms.CheckedListBox();
            this.btnCheckAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnSeeChart = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cmdClusterAlgorithm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDistanceAlgorithm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Location = new System.Drawing.Point(358, 30);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(95, 20);
            this.btnAnalysis.TabIndex = 1;
            this.btnAnalysis.Text = "Analysis Cluster";
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // cmdClusterAlgorithm
            // 
            this.cmdClusterAlgorithm.Location = new System.Drawing.Point(3, 30);
            this.cmdClusterAlgorithm.Name = "cmdClusterAlgorithm";
            this.cmdClusterAlgorithm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmdClusterAlgorithm.Properties.Items.AddRange(new object[] {
            "Hierarchycial"});
            this.cmdClusterAlgorithm.Size = new System.Drawing.Size(149, 20);
            this.cmdClusterAlgorithm.TabIndex = 2;
            // 
            // Algorithm
            // 
            this.Algorithm.Location = new System.Drawing.Point(3, 11);
            this.Algorithm.Name = "Algorithm";
            this.Algorithm.Size = new System.Drawing.Size(82, 13);
            this.Algorithm.TabIndex = 3;
            this.Algorithm.Text = "Cluster Algorithm";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(192, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Distance Algorithm";
            // 
            // cmdDistanceAlgorithm
            // 
            this.cmdDistanceAlgorithm.Location = new System.Drawing.Point(192, 30);
            this.cmdDistanceAlgorithm.Name = "cmdDistanceAlgorithm";
            this.cmdDistanceAlgorithm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmdDistanceAlgorithm.Properties.Items.AddRange(new object[] {
            "Euclipdean",
            "DTW"});
            this.cmdDistanceAlgorithm.Size = new System.Drawing.Size(149, 20);
            this.cmdDistanceAlgorithm.TabIndex = 4;
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
            this.cklStockList.Location = new System.Drawing.Point(-2, 130);
            this.cklStockList.Name = "cklStockList";
            this.cklStockList.Size = new System.Drawing.Size(100, 154);
            this.cklStockList.TabIndex = 6;
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Location = new System.Drawing.Point(-2, 101);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(100, 23);
            this.btnCheckAll.TabIndex = 7;
            this.btnCheckAll.Text = "Check All Stock";
            // 
            // btnSeeChart
            // 
            this.btnSeeChart.Location = new System.Drawing.Point(0, 290);
            this.btnSeeChart.Name = "btnSeeChart";
            this.btnSeeChart.Size = new System.Drawing.Size(100, 23);
            this.btnSeeChart.TabIndex = 8;
            this.btnSeeChart.Text = "See chart";
            this.btnSeeChart.Click += new System.EventHandler(this.btnSeeChart_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(0, 75);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(3, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Filter";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelControl1.Location = new System.Drawing.Point(124, 78);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(642, 319);
            this.panelControl1.TabIndex = 11;
            // 
            // frmStockCluster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 468);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSeeChart);
            this.Controls.Add(this.btnCheckAll);
            this.Controls.Add(this.cklStockList);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmdDistanceAlgorithm);
            this.Controls.Add(this.Algorithm);
            this.Controls.Add(this.cmdClusterAlgorithm);
            this.Controls.Add(this.btnAnalysis);
            this.Name = "frmStockCluster";
            this.Text = "Stock Cluster Program";
            ((System.ComponentModel.ISupportInitialize)(this.cmdClusterAlgorithm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdDistanceAlgorithm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAnalysis;
        private DevExpress.XtraEditors.ComboBoxEdit cmdClusterAlgorithm;
        private DevExpress.XtraEditors.LabelControl Algorithm;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmdDistanceAlgorithm;
        private System.Windows.Forms.CheckedListBox cklStockList;
        private DevExpress.XtraEditors.SimpleButton btnCheckAll;
        private DevExpress.XtraEditors.SimpleButton btnSeeChart;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;

    }
}