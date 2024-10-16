<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581564/21.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4390)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->

# Pivot Grid for WinForms - Apply Summary Filter

This example demonstrates how to apply a summary filter to a specific detail level.

The Pivot Grid displays product sales by country. The summary filter is applied to country totals calculated for individual products to display values in the range from 500 to 2500. The filter applies to a specific detail level identified by the _Product Name_ and _Country_ fields.

![screenshot](./images/screenshot.png)

API in this example:

* [PivotSummaryFilter.StartValue](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotSummaryFilter.StartValue)
* [PivotSummaryFilter.EndValue](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotSummaryFilter.EndValue)
* [PivotSummaryFilter.Mode](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotSummaryFilter.Mode)
* [PivotSummaryFilter.RowField](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotSummaryFilter.RowField)
* [PivotSummaryFilter.ColumnField](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotSummaryFilter.ColumnField)

## Files to Review

* [Form1.cs](./CS/XtraPivotGrid_ApplySummaryFilter/Form1.cs) (VB: [Form1.vb](./VB/XtraPivotGrid_ApplySummaryFilter/Form1.vb))

## Documentation

- [Filter by Summaries](https://docs.devexpress.com/WindowsForms/11545/controls-and-libraries/pivot-grid/data-shaping/filtering/filter-by-summaries)
- [Summaries](https://docs.devexpress.com/WindowsForms/9384)
- [Levels of Details](https://docs.devexpress.com/WindowsForms/1796/controls-and-libraries/pivot-grid/fundamentals/hierarchical-value-presentation#use-resulting-detail-levels)

## More Examples 

- [Pivot Grid for WinForms - Apply Summary Filter in OLAP mode](https://github.com/DevExpress-Examples/how-to-implement-sorting-by-summary-in-olap-mode-e3023)
- [Pivot Grid for WinForms -Implement Group Filter](https://github.com/DevExpress-Examples/how-to-implement-group-filter-for-a-pivotgridcontrol-e4581)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pivot-apply-summary-filter&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pivot-apply-summary-filter&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
