Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid

Namespace XtraPivotGrid_ApplySummaryFilter
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

			' Binds the pivot grid to data.
			Me.salesPersonTableAdapter.Fill(Me.nwindDataSet.SalesPerson)

			' Locks the control to prevent excessive updates when multiple properties are modified.
			pivotGridControl1.BeginUpdate()
			Try

				' Sets the minimum summary value to be displayed.
				fieldExtendedPrice.SummaryFilter.StartValue = 500

				' Sets the maximum summary value to be displayed.
				fieldExtendedPrice.SummaryFilter.EndValue = 2500

				' Specifies that summary filtering should be applied
				' to a particular aggregation level.
				fieldExtendedPrice.SummaryFilter.Mode = PivotSummaryFilterMode.SpecificLevel

				' Sets the row used to identify an aggregation level
				' to which the filtering is applied.
				fieldExtendedPrice.SummaryFilter.RowField = fieldProductName

				' Sets the column used to identify an aggregation level
				' to which the filtering is applied.
				fieldExtendedPrice.SummaryFilter.ColumnField = fieldCountry
			Finally

				' Unlocks the control.
				pivotGridControl1.EndUpdate()
			End Try
		End Sub
	End Class
End Namespace
