namespace XtraPivotGrid_ApplySummaryFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo1 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo2 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo3 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo4 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo5 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo6 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo7 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo8 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo9 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo10 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo11 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo12 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.ExcelWorksheetSettings excelWorksheetSettings1 = new DevExpress.DataAccess.Excel.ExcelWorksheetSettings();
            DevExpress.DataAccess.Excel.ExcelSourceOptions excelSourceOptions1 = new DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings1);
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding1 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding2 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding3 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding4 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding5 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.fieldCountry1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCategoryName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesPerson1 = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.excelDataSource1;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCountry1,
            this.fieldProductName1,
            this.fieldCategoryName1,
            this.fieldExtendedPrice1,
            this.fieldSalesPerson1});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
            this.pivotGridControl1.Size = new System.Drawing.Size(758, 431);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.FileName = "C:\\Data\\SalesPerson.xlsx";
            this.excelDataSource1.Name = "excelDataSource1";
            this.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable");
            fieldInfo1.Name = "CategoryName";
            fieldInfo1.OriginalName = null;
            fieldInfo1.Type = typeof(string);
            fieldInfo2.Name = "Country";
            fieldInfo2.OriginalName = null;
            fieldInfo2.Type = typeof(string);
            fieldInfo3.Name = "FirstName";
            fieldInfo3.OriginalName = null;
            fieldInfo3.Type = typeof(string);
            fieldInfo4.Name = "LastName";
            fieldInfo4.OriginalName = null;
            fieldInfo4.Type = typeof(string);
            fieldInfo5.Name = "ProductName";
            fieldInfo5.OriginalName = null;
            fieldInfo5.Type = typeof(string);
            fieldInfo6.Name = "Sales Person";
            fieldInfo6.OriginalName = null;
            fieldInfo6.Type = typeof(string);
            fieldInfo7.Name = "OrderDate";
            fieldInfo7.OriginalName = null;
            fieldInfo7.Type = typeof(System.DateTime);
            fieldInfo8.Name = "OrderID";
            fieldInfo8.OriginalName = null;
            fieldInfo8.Type = typeof(double);
            fieldInfo9.Name = "Quantity";
            fieldInfo9.OriginalName = null;
            fieldInfo9.Type = typeof(double);
            fieldInfo10.Name = "Discount";
            fieldInfo10.OriginalName = null;
            fieldInfo10.Type = typeof(double);
            fieldInfo11.Name = "Extended Price";
            fieldInfo11.OriginalName = null;
            fieldInfo11.Type = typeof(double);
            fieldInfo12.Name = "UnitPrice";
            fieldInfo12.OriginalName = null;
            fieldInfo12.Type = typeof(double);
            this.excelDataSource1.Schema.AddRange(new DevExpress.DataAccess.Excel.FieldInfo[] {
            fieldInfo1,
            fieldInfo2,
            fieldInfo3,
            fieldInfo4,
            fieldInfo5,
            fieldInfo6,
            fieldInfo7,
            fieldInfo8,
            fieldInfo9,
            fieldInfo10,
            fieldInfo11,
            fieldInfo12});
            excelWorksheetSettings1.CellRange = null;
            excelWorksheetSettings1.WorksheetIndex = null;
            excelWorksheetSettings1.WorksheetName = "Data";
            excelSourceOptions1.ImportSettings = excelWorksheetSettings1;
            this.excelDataSource1.SourceOptions = excelSourceOptions1;
            // 
            // fieldCountry1
            // 
            this.fieldCountry1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldCountry1.AreaIndex = 0;
            this.fieldCountry1.Caption = "Country";
            dataSourceColumnBinding1.ColumnName = "Country";
            this.fieldCountry1.DataBinding = dataSourceColumnBinding1;
            this.fieldCountry1.Name = "fieldCountry1";
            // 
            // fieldProductName1
            // 
            this.fieldProductName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName1.AreaIndex = 1;
            this.fieldProductName1.Caption = "Product Name";
            dataSourceColumnBinding2.ColumnName = "ProductName";
            this.fieldProductName1.DataBinding = dataSourceColumnBinding2;
            this.fieldProductName1.Name = "fieldProductName1";
            // 
            // fieldCategoryName1
            // 
            this.fieldCategoryName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName1.AreaIndex = 0;
            this.fieldCategoryName1.Caption = "Category Name";
            dataSourceColumnBinding3.ColumnName = "CategoryName";
            this.fieldCategoryName1.DataBinding = dataSourceColumnBinding3;
            this.fieldCategoryName1.Name = "fieldCategoryName1";
            // 
            // fieldExtendedPrice1
            // 
            this.fieldExtendedPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPrice1.AreaIndex = 0;
            this.fieldExtendedPrice1.Caption = "Extended Price";
            dataSourceColumnBinding4.ColumnName = "Extended Price";
            this.fieldExtendedPrice1.DataBinding = dataSourceColumnBinding4;
            this.fieldExtendedPrice1.Name = "fieldExtendedPrice1";
            // 
            // fieldSalesPerson1
            // 
            this.fieldSalesPerson1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldSalesPerson1.AreaIndex = 1;
            this.fieldSalesPerson1.Caption = "Sales Person";
            dataSourceColumnBinding5.ColumnName = "Sales Person";
            this.fieldSalesPerson1.DataBinding = dataSourceColumnBinding5;
            this.fieldSalesPerson1.Name = "fieldSalesPerson1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 431);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "Apply Summary Filter Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCountry1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategoryName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldExtendedPrice1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSalesPerson1;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
    }
}

