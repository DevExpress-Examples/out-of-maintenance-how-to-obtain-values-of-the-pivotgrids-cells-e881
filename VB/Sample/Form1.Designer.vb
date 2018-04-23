Imports Microsoft.VisualBasic
Imports System
Namespace Sample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.nwindDataSet1 = New Sample.nwindDataSet()
			Me.fieldCompanyName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderYear = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductAmount = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.dataGridView1 = New System.Windows.Forms.DataGridView()
			Me.button1 = New System.Windows.Forms.Button()
			Me.customerReportsTableAdapter1 = New Sample.nwindDataSetTableAdapters.CustomerReportsTableAdapter()
			Me.fieldMonth = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.pivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl1.DataMember = "CustomerReports"
			Me.pivotGridControl1.DataSource = Me.nwindDataSet1
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldCompanyName, Me.fieldOrderYear, Me.fieldProductAmount, Me.fieldProductName, Me.fieldMonth, Me.pivotGridField1})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(622, 259)
			Me.pivotGridControl1.TabIndex = 0
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' fieldCompanyName
			' 
			Me.fieldCompanyName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCompanyName.AreaIndex = 0
			Me.fieldCompanyName.FieldName = "CompanyName"
			Me.fieldCompanyName.Name = "fieldCompanyName"
			' 
			' fieldOrderYear
			' 
			Me.fieldOrderYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldOrderYear.AreaIndex = 0
			Me.fieldOrderYear.Caption = "Year"
			Me.fieldOrderYear.FieldName = "OrderDate"
			Me.fieldOrderYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.fieldOrderYear.Name = "fieldOrderYear"
			Me.fieldOrderYear.UnboundFieldName = "fieldOrderYear"
			' 
			' fieldProductAmount
			' 
			Me.fieldProductAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldProductAmount.AreaIndex = 0
			Me.fieldProductAmount.Caption = "Sum"
			Me.fieldProductAmount.FieldName = "ProductAmount"
			Me.fieldProductAmount.Name = "fieldProductAmount"
			' 
			' fieldProductName
			' 
			Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProductName.AreaIndex = 1
			Me.fieldProductName.FieldName = "ProductName"
			Me.fieldProductName.Name = "fieldProductName"
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.dataGridView1)
			Me.panel1.Controls.Add(Me.button1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panel1.Location = New System.Drawing.Point(0, 259)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(622, 215)
			Me.panel1.TabIndex = 1
			' 
			' dataGridView1
			' 
			Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dataGridView1.Location = New System.Drawing.Point(0, 23)
			Me.dataGridView1.Name = "dataGridView1"
			Me.dataGridView1.Size = New System.Drawing.Size(622, 192)
			Me.dataGridView1.TabIndex = 0
			' 
			' button1
			' 
			Me.button1.Dock = System.Windows.Forms.DockStyle.Top
			Me.button1.Location = New System.Drawing.Point(0, 0)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(622, 23)
			Me.button1.TabIndex = 1
			Me.button1.Text = "Obtain data"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' customerReportsTableAdapter1
			' 
			Me.customerReportsTableAdapter1.ClearBeforeFill = True
			' 
			' fieldMonth
			' 
			Me.fieldMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldMonth.AreaIndex = 1
			Me.fieldMonth.Caption = "Month"
			Me.fieldMonth.FieldName = "OrderDate"
			Me.fieldMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
			Me.fieldMonth.Name = "fieldMonth"
			Me.fieldMonth.UnboundFieldName = "pivotGridField1"
			' 
			' pivotGridField1
			' 
			Me.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.pivotGridField1.AreaIndex = 1
			Me.pivotGridField1.Caption = "Variation"
			Me.pivotGridField1.FieldName = "ProductAmount"
			Me.pivotGridField1.Name = "pivotGridField1"
			Me.pivotGridField1.Options.HideEmptyVariationItems = True
			Me.pivotGridField1.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.AbsoluteVariation
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(622, 474)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Controls.Add(Me.panel1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private panel1 As System.Windows.Forms.Panel
		Private nwindDataSet1 As nwindDataSet
		Private customerReportsTableAdapter1 As Sample.nwindDataSetTableAdapters.CustomerReportsTableAdapter
		Private fieldCompanyName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldOrderYear As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductAmount As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField
		Private dataGridView1 As System.Windows.Forms.DataGridView
		Private WithEvents button1 As System.Windows.Forms.Button
		Private fieldMonth As DevExpress.XtraPivotGrid.PivotGridField
		Private pivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace

