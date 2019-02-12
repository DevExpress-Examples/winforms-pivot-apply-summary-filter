Namespace XtraPivotGrid_ApplySummaryFilter
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim fieldInfo13 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo14 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo15 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo16 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo17 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo18 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo19 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo20 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo21 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo22 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo23 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo24 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim excelWorksheetSettings2 As New DevExpress.DataAccess.Excel.ExcelWorksheetSettings()
			Dim excelSourceOptions2 As New DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings2)
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.fieldCountry = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.excelDataSource1 = New DevExpress.DataAccess.Excel.ExcelDataSource()
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.DataSource = Me.excelDataSource1
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldCountry, Me.fieldProductName, Me.fieldCategoryName, Me.fieldExtendedPrice, Me.fieldSalesPerson})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(758, 431)
			Me.pivotGridControl1.TabIndex = 0
			' 
			' fieldCountry
			' 
			Me.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldCountry.AreaIndex = 0
			Me.fieldCountry.Caption = "Country"
			Me.fieldCountry.FieldName = "Country"
			Me.fieldCountry.Name = "fieldCountry"
			' 
			' fieldProductName
			' 
			Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProductName.AreaIndex = 1
			Me.fieldProductName.Caption = "Product Name"
			Me.fieldProductName.FieldName = "ProductName"
			Me.fieldProductName.Name = "fieldProductName"
			' 
			' fieldCategoryName
			' 
			Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCategoryName.AreaIndex = 0
			Me.fieldCategoryName.Caption = "Category Name"
			Me.fieldCategoryName.FieldName = "CategoryName"
			Me.fieldCategoryName.Name = "fieldCategoryName"
			' 
			' fieldExtendedPrice
			' 
			Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldExtendedPrice.AreaIndex = 0
			Me.fieldExtendedPrice.Caption = "Extended Price"
			Me.fieldExtendedPrice.FieldName = "Extended Price"
			Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
			' 
			' fieldSalesPerson
			' 
			Me.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldSalesPerson.AreaIndex = 1
			Me.fieldSalesPerson.Caption = "Sales Person"
			Me.fieldSalesPerson.FieldName = "Sales Person"
			Me.fieldSalesPerson.Name = "fieldSalesPerson"
			' 
			' excelDataSource1
			' 
			Me.excelDataSource1.FileName = "C:\Data\SalesPerson.xlsx"
			Me.excelDataSource1.Name = "excelDataSource1"
			Me.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable")
			fieldInfo13.Name = "CategoryName"
			fieldInfo13.Type = GetType(String)
			fieldInfo14.Name = "Country"
			fieldInfo14.Type = GetType(String)
			fieldInfo15.Name = "FirstName"
			fieldInfo15.Type = GetType(String)
			fieldInfo16.Name = "LastName"
			fieldInfo16.Type = GetType(String)
			fieldInfo17.Name = "ProductName"
			fieldInfo17.Type = GetType(String)
			fieldInfo18.Name = "Sales Person"
			fieldInfo18.Type = GetType(String)
			fieldInfo19.Name = "OrderDate"
			fieldInfo19.Type = GetType(Date)
			fieldInfo20.Name = "OrderID"
			fieldInfo20.Type = GetType(Double)
			fieldInfo21.Name = "Quantity"
			fieldInfo21.Type = GetType(Double)
			fieldInfo22.Name = "Discount"
			fieldInfo22.Type = GetType(Double)
			fieldInfo23.Name = "Extended Price"
			fieldInfo23.Type = GetType(Double)
			fieldInfo24.Name = "UnitPrice"
			fieldInfo24.Type = GetType(Double)
			Me.excelDataSource1.Schema.AddRange(New DevExpress.DataAccess.Excel.FieldInfo() { fieldInfo13, fieldInfo14, fieldInfo15, fieldInfo16, fieldInfo17, fieldInfo18, fieldInfo19, fieldInfo20, fieldInfo21, fieldInfo22, fieldInfo23, fieldInfo24})
			excelWorksheetSettings2.CellRange = Nothing
			excelWorksheetSettings2.WorksheetName = "Data"
			excelSourceOptions2.ImportSettings = excelWorksheetSettings2
			Me.excelDataSource1.SourceOptions = excelSourceOptions2
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(758, 431)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Apply Summary Filter Example"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private fieldCountry As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCategoryName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldSalesPerson As DevExpress.XtraPivotGrid.PivotGridField
		Private excelDataSource1 As DevExpress.DataAccess.Excel.ExcelDataSource
	End Class
End Namespace

