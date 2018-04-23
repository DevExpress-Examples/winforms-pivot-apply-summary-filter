using System;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;

namespace XtraPivotGrid_ApplySummaryFilter {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {

            // Binds the pivot grid to data.
            this.salesPersonTableAdapter.Fill(this.nwindDataSet.SalesPerson);

            // Locks the control to prevent excessive updates when multiple properties are modified.
            pivotGridControl1.BeginUpdate();
            try {

                // Sets the minimum summary value to be displayed.
                fieldExtendedPrice.SummaryFilter.StartValue = 500;

                // Sets the maximum summary value to be displayed.
                fieldExtendedPrice.SummaryFilter.EndValue = 2500;

                // Specifies that summary filtering should be applied
                // to a particular aggregation level.
                fieldExtendedPrice.SummaryFilter.Mode = PivotSummaryFilterMode.SpecificLevel;

                // Sets the row used to identify an aggregation level
                // to which the filtering is applied.
                fieldExtendedPrice.SummaryFilter.RowField = fieldProductName;

                // Sets the column used to identify an aggregation level
                // to which the filtering is applied.
                fieldExtendedPrice.SummaryFilter.ColumnField = fieldCountry;
            }
            finally {

                // Unlocks the control.
                pivotGridControl1.EndUpdate();
            }
        }
    }
}
