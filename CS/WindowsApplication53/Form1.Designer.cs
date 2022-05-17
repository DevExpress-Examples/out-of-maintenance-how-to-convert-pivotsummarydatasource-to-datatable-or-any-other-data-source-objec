namespace WindowsApplication53
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
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding1 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding2 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding3 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding4 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding5 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding6 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.fieldName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldValueSum = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldValueCount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldValueAverage = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDate1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl1.DataMember = "Data";
            this.pivotGridControl1.DataSource = this.dataSet1;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldName1,
            this.fieldYear,
            this.fieldValueSum,
            this.fieldValueCount,
            this.fieldValueAverage,
            this.fieldDate1});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
            this.pivotGridControl1.OptionsDataField.FieldNaming = DevExpress.XtraPivotGrid.DataFieldNaming.Name;
            this.pivotGridControl1.Size = new System.Drawing.Size(412, 403);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3});
            this.dataTable1.TableName = "Data";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Name";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Date";
            this.dataColumn2.DataType = typeof(System.DateTime);
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Value";
            this.dataColumn3.DataType = typeof(decimal);
            // 
            // fieldName1
            // 
            this.fieldName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldName1.AreaIndex = 0;
            dataSourceColumnBinding1.ColumnName = "Name";
            this.fieldName1.DataBinding = dataSourceColumnBinding1;
            this.fieldName1.Name = "fieldName1";
            // 
            // fieldYear
            // 
            this.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldYear.AreaIndex = 0;
            this.fieldYear.Caption = "Year";
            dataSourceColumnBinding2.ColumnName = "Date";
            dataSourceColumnBinding2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldYear.DataBinding = dataSourceColumnBinding2;
            this.fieldYear.Name = "fieldYear";
            // 
            // fieldValueSum
            // 
            this.fieldValueSum.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldValueSum.AreaIndex = 0;
            this.fieldValueSum.Caption = "Sum";
            dataSourceColumnBinding3.ColumnName = "Value";
            this.fieldValueSum.DataBinding = dataSourceColumnBinding3;
            this.fieldValueSum.Name = "fieldValueSum";
            // 
            // fieldValueCount
            // 
            this.fieldValueCount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldValueCount.AreaIndex = 1;
            this.fieldValueCount.Caption = "Count";
            dataSourceColumnBinding4.ColumnName = "Value";
            this.fieldValueCount.DataBinding = dataSourceColumnBinding4;
            this.fieldValueCount.Name = "fieldValueCount";
            // 
            // fieldValueAverage
            // 
            this.fieldValueAverage.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldValueAverage.AreaIndex = 2;
            this.fieldValueAverage.Caption = "Average";
            dataSourceColumnBinding5.ColumnName = "Value";
            this.fieldValueAverage.DataBinding = dataSourceColumnBinding5;
            this.fieldValueAverage.Name = "fieldValueAverage";
            // 
            // fieldDate1
            // 
            this.fieldDate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldDate1.AreaIndex = 1;
            this.fieldDate1.Caption = "Date";
            dataSourceColumnBinding6.ColumnName = "Date";
            dataSourceColumnBinding6.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Date;
            this.fieldDate1.DataBinding = dataSourceColumnBinding6;
            this.fieldDate1.Name = "fieldDate1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 403);
            this.dataGridView1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pivotGridControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(959, 403);
            this.splitContainer1.SplitterDistance = 412;
            this.splitContainer1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 403);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private DevExpress.XtraPivotGrid.PivotGridField fieldName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldYear;
        private DevExpress.XtraPivotGrid.PivotGridField fieldValueSum;
        private DevExpress.XtraPivotGrid.PivotGridField fieldValueCount;
        private DevExpress.XtraPivotGrid.PivotGridField fieldValueAverage;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDate1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

