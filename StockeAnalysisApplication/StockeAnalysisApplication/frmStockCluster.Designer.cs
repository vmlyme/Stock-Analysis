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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Location = new System.Drawing.Point(16, 431);
            this.btnAnalysis.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(135, 25);
            this.btnAnalysis.TabIndex = 1;
            this.btnAnalysis.Text = "Analysis Cluster";
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // Algorithm
            // 
            this.Algorithm.Location = new System.Drawing.Point(675, 14);
            this.Algorithm.Margin = new System.Windows.Forms.Padding(4);
            this.Algorithm.Name = "Algorithm";
            this.Algorithm.Size = new System.Drawing.Size(99, 16);
            this.Algorithm.TabIndex = 3;
            this.Algorithm.Text = "Cluster Algorithm";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(903, 14);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(107, 16);
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
            this.cklStockList.Location = new System.Drawing.Point(16, 160);
            this.cklStockList.Margin = new System.Windows.Forms.Padding(4);
            this.cklStockList.Name = "cklStockList";
            this.cklStockList.Size = new System.Drawing.Size(132, 259);
            this.cklStockList.TabIndex = 6;
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Location = new System.Drawing.Point(17, 124);
            this.btnCheckAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(133, 28);
            this.btnCheckAll.TabIndex = 7;
            this.btnCheckAll.Text = "Check All Stock";
            // 
            // btnSeeChart
            // 
            this.btnSeeChart.Location = new System.Drawing.Point(16, 463);
            this.btnSeeChart.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeeChart.Name = "btnSeeChart";
            this.btnSeeChart.Size = new System.Drawing.Size(135, 28);
            this.btnSeeChart.TabIndex = 8;
            this.btnSeeChart.Text = "See chart";
            this.btnSeeChart.Click += new System.EventHandler(this.btnSeeChart_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(16, 92);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(133, 22);
            this.txtSearch.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 69);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 16);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Filter";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelControl1.Location = new System.Drawing.Point(398, 96);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(623, 395);
            this.panelControl1.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(648, 41);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(153, 17);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Hierarchical Clustering";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(861, 41);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(157, 17);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Dynamic Time Warping";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(16, 17);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(4);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(180, 22);
            this.textEdit1.TabIndex = 14;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(221, 15);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(100, 28);
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "Import File";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(173, 160);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(173, 208);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 18;
            // 
            // frmStockCluster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 654);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;

    }
}