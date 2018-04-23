using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;

namespace Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            customerReportsTableAdapter1.Fill(nwindDataSet1.CustomerReports);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            if (pivotGridControl1.Cells.RowCount == 0) return;

            List<PivotGridField> rowFields = pivotGridControl1.GetFieldsByArea(PivotArea.RowArea);
            foreach (PivotGridField rowField in rowFields)
                tbl.Columns.Add(rowField.ToString());
            for ( int i = 0; i < pivotGridControl1.Cells.ColumnCount ; i++)            
                tbl.Columns.Add(GetColumnFieldValueText(pivotGridControl1, pivotGridControl1.Cells.GetCellInfo(i, 0)));                              
            
                       

            for ( int rowIndex = 0 ; rowIndex < pivotGridControl1.Cells.RowCount; rowIndex ++)
            {
                DataRow row = tbl.NewRow();
                DevExpress.XtraPivotGrid.PivotCellEventArgs cellInfo = pivotGridControl1.Cells.GetCellInfo(0, rowIndex);

                foreach (PivotGridField rowField in rowFields )
            		 row[ rowField.AreaIndex ] = cellInfo.GetFieldValue( rowField );	            
            
                for (int columnIndex = 0; columnIndex < pivotGridControl1.Cells.ColumnCount; columnIndex++)
                    row[columnIndex + rowFields.Count] = pivotGridControl1.Cells.GetCellInfo(columnIndex, rowIndex).Value;                
                tbl.Rows.Add(row);
            }
            dataGridView1.DataSource = tbl;
        }
        static string separatorString = " | ";
        private string GetColumnFieldValueText(PivotGridControl pivotGrid, PivotCellEventArgs cellInfo)
        {
            StringBuilder sb = new StringBuilder();
            if (cellInfo.ColumnValueType == PivotGridValueType.GrandTotal)
            {
                sb.Append("Grand Total");
                sb.Append( separatorString );
            }
            else
                foreach (PivotGridField field in cellInfo.GetColumnFields())
                {
                    sb.Append(cellInfo.GetFieldValue(field));
                    sb.Append(separatorString);
                }
            if (pivotGrid.GetFieldsByArea(PivotArea.DataArea).Count > 1)
                sb.Append(cellInfo.DataField);
            else
                sb.Remove(sb.Length - separatorString.Length, separatorString.Length);
            return sb.ToString();
        }
    }
}