Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid

Namespace XtraPivotGrid_ApplySummaryFilter
	Partial Public Class Form1
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
			excelDataSource1.FileName = "SalesPerson.xlsx"
			excelDataSource1.Fill()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			pivotGridControl1.BeginUpdate()
			Try
				' Set the minimum displayed summary value.
				fieldExtendedPrice1.SummaryFilter.StartValue = 500

				' Set the maximum displayed summary value.
				fieldExtendedPrice1.SummaryFilter.EndValue = 2500

				' Apply summary filter to the aggregation level specified by the RowField and ColumnField values.
				fieldExtendedPrice1.SummaryFilter.Mode = PivotSummaryFilterMode.SpecificLevel

				' Set the row that identifies the filtered aggregation level.
				fieldExtendedPrice1.SummaryFilter.RowField = fieldProductName1

				' Set the row that identifies the filtered aggregation level.
				fieldExtendedPrice1.SummaryFilter.ColumnField = fieldCountry1
			Finally
				pivotGridControl1.EndUpdate()
			End Try
		End Sub
	End Class
End Namespace
