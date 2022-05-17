Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid

Namespace WindowsApplication53

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            PopulateTable()
            pivotGridControl1.RefreshData()
            pivotGridControl1.BestFit()
            dataGridView1.DataSource = ConvertPivotSummaryDataSourceToDataTable(pivotGridControl1.CreateSummaryDataSource())
        End Sub

        Private Function ConvertPivotSummaryDataSourceToDataTable(ByVal source As PivotSummaryDataSource) As DataTable
            Dim dt As DataTable = New DataTable()
            For Each _propertyDescriptor As PropertyDescriptor In source.GetItemProperties(Nothing)
                dt.Columns.Add(_propertyDescriptor.Name, _propertyDescriptor.PropertyType)
            Next

            For r As Integer = 0 To source.RowCount - 1
                Dim rowValues As Object() = New Object(dt.Columns.Count - 1) {}
                For c As Integer = 0 To dt.Columns.Count - 1
                    rowValues(c) = source.GetValue(r, dt.Columns(c).ColumnName)
                Next

                dt.Rows.Add(rowValues)
            Next

            Return dt
        End Function

        Private Sub PopulateTable()
            Dim myTable As DataTable = dataSet1.Tables("Data")
            myTable.Rows.Add(New Object() {"Aaa", Date.Today, 7})
            myTable.Rows.Add(New Object() {"Aaa", Date.Today.AddDays(1), 4})
            myTable.Rows.Add(New Object() {"Bbb", Date.Today, 12})
            myTable.Rows.Add(New Object() {"Bbb", Date.Today.AddDays(1), 14})
            myTable.Rows.Add(New Object() {"Ccc", Date.Today, 11})
            myTable.Rows.Add(New Object() {"Ccc", Date.Today.AddDays(1), 10})
            myTable.Rows.Add(New Object() {"Aaa", Date.Today.AddYears(1), 4})
            myTable.Rows.Add(New Object() {"Aaa", Date.Today.AddYears(1).AddDays(1), 2})
            myTable.Rows.Add(New Object() {"Bbb", Date.Today.AddYears(1), 3})
            myTable.Rows.Add(New Object() {"Bbb", Date.Today.AddDays(1).AddYears(1), 1})
            myTable.Rows.Add(New Object() {"Ccc", Date.Today.AddYears(1), 8})
            myTable.Rows.Add(New Object() {"Ccc", Date.Today.AddDays(1).AddYears(1), 22})
        End Sub
    End Class
End Namespace
