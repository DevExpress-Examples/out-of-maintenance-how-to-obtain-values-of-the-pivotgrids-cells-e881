namespace Sample
{
    partial class Form1
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
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.nwindDataSet1 = new Sample.nwindDataSet();
            this.fieldCompanyName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.customerReportsTableAdapter1 = new Sample.nwindDataSetTableAdapters.CustomerReportsTableAdapter();
            this.fieldMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl1.DataMember = "CustomerReports";
            this.pivotGridControl1.DataSource = this.nwindDataSet1;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCompanyName,
            this.fieldOrderYear,
            this.fieldProductAmount,
            this.fieldProductName,
            this.fieldMonth,
            this.pivotGridField1});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(622, 259);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // nwindDataSet1
            // 
            this.nwindDataSet1.DataSetName = "nwindDataSet";
            this.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldCompanyName
            // 
            this.fieldCompanyName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCompanyName.AreaIndex = 0;
            this.fieldCompanyName.FieldName = "CompanyName";
            this.fieldCompanyName.Name = "fieldCompanyName";
            // 
            // fieldOrderYear
            // 
            this.fieldOrderYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderYear.AreaIndex = 0;
            this.fieldOrderYear.Caption = "Year";
            this.fieldOrderYear.FieldName = "OrderDate";
            this.fieldOrderYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldOrderYear.Name = "fieldOrderYear";
            this.fieldOrderYear.UnboundFieldName = "fieldOrderYear";
            // 
            // fieldProductAmount
            // 
            this.fieldProductAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldProductAmount.AreaIndex = 0;
            this.fieldProductAmount.Caption = "Sum";
            this.fieldProductAmount.FieldName = "ProductAmount";
            this.fieldProductAmount.Name = "fieldProductAmount";
            // 
            // fieldProductName
            // 
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName.AreaIndex = 1;
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.Name = "fieldProductName";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 215);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(622, 192);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(622, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Obtain data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customerReportsTableAdapter1
            // 
            this.customerReportsTableAdapter1.ClearBeforeFill = true;
            // 
            // fieldMonth
            // 
            this.fieldMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldMonth.AreaIndex = 1;
            this.fieldMonth.Caption = "Month";
            this.fieldMonth.FieldName = "OrderDate";
            this.fieldMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fieldMonth.Name = "fieldMonth";
            this.fieldMonth.UnboundFieldName = "pivotGridField1";
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField1.AreaIndex = 1;
            this.pivotGridField1.Caption = "Variation";
            this.pivotGridField1.FieldName = "ProductAmount";
            this.pivotGridField1.Name = "pivotGridField1";
            this.pivotGridField1.Options.HideEmptyVariationItems = true;
            this.pivotGridField1.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.AbsoluteVariation;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 474);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private System.Windows.Forms.Panel panel1;
        private nwindDataSet nwindDataSet1;
        private Sample.nwindDataSetTableAdapters.CustomerReportsTableAdapter customerReportsTableAdapter1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCompanyName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderYear;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductAmount;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMonth;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
    }
}

