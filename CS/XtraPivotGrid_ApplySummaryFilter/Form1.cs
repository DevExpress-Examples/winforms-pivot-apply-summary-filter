using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;

namespace XtraPivotGrid_ApplySummaryFilter {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            this.salesPersonTableAdapter.Fill(this.nwindDataSet.SalesPerson);

            pivotGridControl1.BeginUpdate();
            try {
                // Set the minimum displayed summary value.
                fieldExtendedPrice.SummaryFilter.StartValue = 500;

                // Set the maximum displayed summary value.
                fieldExtendedPrice.SummaryFilter.EndValue = 2500;

                // Apply summary filter to the aggregation level specified by the RowField and ColumnField values.
                fieldExtendedPrice.SummaryFilter.Mode = PivotSummaryFilterMode.SpecificLevel;

                // Set the row that identifies the filtered aggregation level.
                fieldExtendedPrice.SummaryFilter.RowField = fieldProductName;

                // Set the row that identifies the filtered aggregation level.
                fieldExtendedPrice.SummaryFilter.ColumnField = fieldCountry;
            }
            finally {
                pivotGridControl1.EndUpdate();
            }
        }
    }
}
