Namespace WindowsApplication53

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim dataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding5 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding6 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.dataSet1 = New System.Data.DataSet()
            Me.dataTable1 = New System.Data.DataTable()
            Me.dataColumn1 = New System.Data.DataColumn()
            Me.dataColumn2 = New System.Data.DataColumn()
            Me.dataColumn3 = New System.Data.DataColumn()
            Me.fieldName1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldValueSum = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldValueCount = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldValueAverage = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.dataGridView1 = New System.Windows.Forms.DataGridView()
            Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dataSet1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dataTable1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dataGridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.splitContainer1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainer1.Panel1.SuspendLayout()
            Me.splitContainer1.Panel2.SuspendLayout()
            Me.splitContainer1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.pivotGridControl1.DataMember = "Data"
            Me.pivotGridControl1.DataSource = Me.dataSet1
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldName1, Me.fieldYear, Me.fieldValueSum, Me.fieldValueCount, Me.fieldValueAverage, Me.fieldDate1})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.OptionsDataField.FieldNaming = DevExpress.XtraPivotGrid.DataFieldNaming.Name
            Me.pivotGridControl1.Size = New System.Drawing.Size(412, 403)
            Me.pivotGridControl1.TabIndex = 0
            ' 
            ' dataSet1
            ' 
            Me.dataSet1.DataSetName = "NewDataSet"
            Me.dataSet1.Tables.AddRange(New System.Data.DataTable() {Me.dataTable1})
            ' 
            ' dataTable1
            ' 
            Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.dataColumn1, Me.dataColumn2, Me.dataColumn3})
            Me.dataTable1.TableName = "Data"
            ' 
            ' dataColumn1
            ' 
            Me.dataColumn1.ColumnName = "Name"
            ' 
            ' dataColumn2
            ' 
            Me.dataColumn2.ColumnName = "Date"
            Me.dataColumn2.DataType = GetType(System.DateTime)
            ' 
            ' dataColumn3
            ' 
            Me.dataColumn3.ColumnName = "Value"
            Me.dataColumn3.DataType = GetType(Decimal)
            ' 
            ' fieldName1
            ' 
            Me.fieldName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldName1.AreaIndex = 0
            dataSourceColumnBinding1.ColumnName = "Name"
            Me.fieldName1.DataBinding = dataSourceColumnBinding1
            Me.fieldName1.Name = "fieldName1"
            ' 
            ' fieldYear
            ' 
            Me.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldYear.AreaIndex = 0
            Me.fieldYear.Caption = "Year"
            dataSourceColumnBinding2.ColumnName = "Date"
            dataSourceColumnBinding2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldYear.DataBinding = dataSourceColumnBinding2
            Me.fieldYear.Name = "fieldYear"
            ' 
            ' fieldValueSum
            ' 
            Me.fieldValueSum.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldValueSum.AreaIndex = 0
            Me.fieldValueSum.Caption = "Sum"
            dataSourceColumnBinding3.ColumnName = "Value"
            Me.fieldValueSum.DataBinding = dataSourceColumnBinding3
            Me.fieldValueSum.Name = "fieldValueSum"
            ' 
            ' fieldValueCount
            ' 
            Me.fieldValueCount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldValueCount.AreaIndex = 1
            Me.fieldValueCount.Caption = "Count"
            dataSourceColumnBinding4.ColumnName = "Value"
            Me.fieldValueCount.DataBinding = dataSourceColumnBinding4
            Me.fieldValueCount.Name = "fieldValueCount"
            ' 
            ' fieldValueAverage
            ' 
            Me.fieldValueAverage.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldValueAverage.AreaIndex = 2
            Me.fieldValueAverage.Caption = "Average"
            dataSourceColumnBinding5.ColumnName = "Value"
            Me.fieldValueAverage.DataBinding = dataSourceColumnBinding5
            Me.fieldValueAverage.Name = "fieldValueAverage"
            ' 
            ' fieldDate1
            ' 
            Me.fieldDate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldDate1.AreaIndex = 1
            Me.fieldDate1.Caption = "Date"
            dataSourceColumnBinding6.ColumnName = "Date"
            dataSourceColumnBinding6.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.[Date]
            Me.fieldDate1.DataBinding = dataSourceColumnBinding6
            Me.fieldDate1.Name = "fieldDate1"
            ' 
            ' dataGridView1
            ' 
            Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dataGridView1.Location = New System.Drawing.Point(0, 0)
            Me.dataGridView1.Name = "dataGridView1"
            Me.dataGridView1.Size = New System.Drawing.Size(543, 403)
            Me.dataGridView1.TabIndex = 1
            ' 
            ' splitContainer1
            ' 
            Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
            Me.splitContainer1.Name = "splitContainer1"
            ' 
            ' splitContainer1.Panel1
            ' 
            Me.splitContainer1.Panel1.Controls.Add(Me.pivotGridControl1)
            ' 
            ' splitContainer1.Panel2
            ' 
            Me.splitContainer1.Panel2.Controls.Add(Me.dataGridView1)
            Me.splitContainer1.Size = New System.Drawing.Size(959, 403)
            Me.splitContainer1.SplitterDistance = 412
            Me.splitContainer1.TabIndex = 2
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(959, 403)
            Me.Controls.Add(Me.splitContainer1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dataSet1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dataTable1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dataGridView1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainer1.Panel1.ResumeLayout(False)
            Me.splitContainer1.Panel2.ResumeLayout(False)
            CType((Me.splitContainer1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainer1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

        Private dataSet1 As System.Data.DataSet

        Private dataTable1 As System.Data.DataTable

        Private dataColumn1 As System.Data.DataColumn

        Private dataColumn2 As System.Data.DataColumn

        Private dataColumn3 As System.Data.DataColumn

        Private fieldName1 As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldYear As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldValueSum As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldValueCount As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldValueAverage As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldDate1 As DevExpress.XtraPivotGrid.PivotGridField

        Private dataGridView1 As System.Windows.Forms.DataGridView

        Private splitContainer1 As System.Windows.Forms.SplitContainer
    End Class
End Namespace
