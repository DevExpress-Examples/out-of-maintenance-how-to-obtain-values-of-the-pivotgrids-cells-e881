Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid

Namespace Sample
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			customerReportsTableAdapter1.Fill(nwindDataSet1.CustomerReports)
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim tbl As New DataTable()
			If pivotGridControl1.Cells.RowCount = 0 Then
				Return
			End If

			Dim rowFields As List(Of PivotGridField) = pivotGridControl1.GetFieldsByArea(PivotArea.RowArea)
			For Each rowField As PivotGridField In rowFields
				tbl.Columns.Add(rowField.ToString())
			Next rowField
			For i As Integer = 0 To pivotGridControl1.Cells.ColumnCount - 1
				tbl.Columns.Add(GetColumnFieldValueText(pivotGridControl1, pivotGridControl1.Cells.GetCellInfo(i, 0)))
			Next i



			For rowIndex As Integer = 0 To pivotGridControl1.Cells.RowCount - 1
				Dim row As DataRow = tbl.NewRow()
				Dim cellInfo As DevExpress.XtraPivotGrid.PivotCellEventArgs = pivotGridControl1.Cells.GetCellInfo(0, rowIndex)

				For Each rowField As PivotGridField In rowFields
					 row(rowField.AreaIndex) = cellInfo.GetFieldValue(rowField)
				Next rowField

				For columnIndex As Integer = 0 To pivotGridControl1.Cells.ColumnCount - 1
					row(columnIndex + rowFields.Count) = pivotGridControl1.Cells.GetCellInfo(columnIndex, rowIndex).Value
				Next columnIndex
				tbl.Rows.Add(row)
			Next rowIndex
			dataGridView1.DataSource = tbl
		End Sub
		Private Shared separatorString As String = " | "
		Private Function GetColumnFieldValueText(ByVal pivotGrid As PivotGridControl, ByVal cellInfo As PivotCellEventArgs) As String
			Dim sb As New StringBuilder()
			If cellInfo.ColumnValueType = PivotGridValueType.GrandTotal Then
				sb.Append("Grand Total")
				sb.Append(separatorString)
			Else
				For Each field As PivotGridField In cellInfo.GetColumnFields()
					sb.Append(cellInfo.GetFieldValue(field))
					sb.Append(separatorString)
				Next field
			End If
			If pivotGrid.GetFieldsByArea(PivotArea.DataArea).Count > 1 Then
				sb.Append(cellInfo.DataField)
			Else
				sb.Remove(sb.Length - separatorString.Length, separatorString.Length)
			End If
			Return sb.ToString()
		End Function
	End Class
End Namespace