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
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo13 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo14 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo15 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo16 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo17 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo18 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo19 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo20 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo21 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo22 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo23 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo24 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.ExcelWorksheetSettings excelWorksheetSettings2 = new DevExpress.DataAccess.Excel.ExcelWorksheetSettings();
            DevExpress.DataAccess.Excel.ExcelSourceOptions excelSourceOptions2 = new DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings2);
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldCountry = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCategoryName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesPerson = new DevExpress.XtraPivotGrid.PivotGridField();
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.excelDataSource1;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCountry,
            this.fieldProductName,
            this.fieldCategoryName,
            this.fieldExtendedPrice,
            this.fieldSalesPerson});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(758, 431);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // fieldCountry
            // 
            this.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldCountry.AreaIndex = 0;
            this.fieldCountry.Caption = "Country";
            this.fieldCountry.FieldName = "Country";
            this.fieldCountry.Name = "fieldCountry";
            // 
            // fieldProductName
            // 
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName.AreaIndex = 1;
            this.fieldProductName.Caption = "Product Name";
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.Name = "fieldProductName";
            // 
            // fieldCategoryName
            // 
            this.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName.AreaIndex = 0;
            this.fieldCategoryName.Caption = "Category Name";
            this.fieldCategoryName.FieldName = "CategoryName";
            this.fieldCategoryName.Name = "fieldCategoryName";
            // 
            // fieldExtendedPrice
            // 
            this.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPrice.AreaIndex = 0;
            this.fieldExtendedPrice.Caption = "Extended Price";
            this.fieldExtendedPrice.FieldName = "Extended Price";
            this.fieldExtendedPrice.Name = "fieldExtendedPrice";
            // 
            // fieldSalesPerson
            // 
            this.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldSalesPerson.AreaIndex = 1;
            this.fieldSalesPerson.Caption = "Sales Person";
            this.fieldSalesPerson.FieldName = "Sales Person";
            this.fieldSalesPerson.Name = "fieldSalesPerson";
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.FileName = "C:\\Data\\SalesPerson.xlsx";
            this.excelDataSource1.Name = "excelDataSource1";
            this.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable");
            fieldInfo13.Name = "CategoryName";
            fieldInfo13.Type = typeof(string);
            fieldInfo14.Name = "Country";
            fieldInfo14.Type = typeof(string);
            fieldInfo15.Name = "FirstName";
            fieldInfo15.Type = typeof(string);
            fieldInfo16.Name = "LastName";
            fieldInfo16.Type = typeof(string);
            fieldInfo17.Name = "ProductName";
            fieldInfo17.Type = typeof(string);
            fieldInfo18.Name = "Sales Person";
            fieldInfo18.Type = typeof(string);
            fieldInfo19.Name = "OrderDate";
            fieldInfo19.Type = typeof(System.DateTime);
            fieldInfo20.Name = "OrderID";
            fieldInfo20.Type = typeof(double);
            fieldInfo21.Name = "Quantity";
            fieldInfo21.Type = typeof(double);
            fieldInfo22.Name = "Discount";
            fieldInfo22.Type = typeof(double);
            fieldInfo23.Name = "Extended Price";
            fieldInfo23.Type = typeof(double);
            fieldInfo24.Name = "UnitPrice";
            fieldInfo24.Type = typeof(double);
            this.excelDataSource1.Schema.AddRange(new DevExpress.DataAccess.Excel.FieldInfo[] {
            fieldInfo13,
            fieldInfo14,
            fieldInfo15,
            fieldInfo16,
            fieldInfo17,
            fieldInfo18,
            fieldInfo19,
            fieldInfo20,
            fieldInfo21,
            fieldInfo22,
            fieldInfo23,
            fieldInfo24});
            excelWorksheetSettings2.CellRange = null;
            excelWorksheetSettings2.WorksheetName = "Data";
            excelSourceOptions2.ImportSettings = excelWorksheetSettings2;
            this.excelDataSource1.SourceOptions = excelSourceOptions2;
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
        private DevExpress.XtraPivotGrid.PivotGridField fieldCountry;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategoryName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldExtendedPrice;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSalesPerson;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
    }
}

