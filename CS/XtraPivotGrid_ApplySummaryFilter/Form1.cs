using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;

namespace XtraPivotGrid_ApplySummaryFilter {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
            excelDataSource1.FileName = "SalesPerson.xlsx";
            excelDataSource1.Fill();
        }
        private void Form1_Load(object sender, EventArgs e) {
            pivotGridControl1.BeginUpdate();
            try {
                // Set the minimum displayed summary value.
                fieldExtendedPrice1.SummaryFilter.StartValue = 500;

                // Set the maximum displayed summary value.
                fieldExtendedPrice1.SummaryFilter.EndValue = 2500;

                // Apply summary filter to the aggregation level specified by the RowField and ColumnField values.
                fieldExtendedPrice1.SummaryFilter.Mode = PivotSummaryFilterMode.SpecificLevel;

                // Set the row that identifies the filtered aggregation level.
                fieldExtendedPrice1.SummaryFilter.RowField = fieldProductName1;

                // Set the row that identifies the filtered aggregation level.
                fieldExtendedPrice1.SummaryFilter.ColumnField = fieldCountry1;
            }
            finally {
                pivotGridControl1.EndUpdate();
            }
        }
    }
}
