<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581564/12.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4390)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/XtraPivotGrid_ApplySummaryFilter/Form1.cs) (VB: [Form1.vb](./VB/XtraPivotGrid_ApplySummaryFilter/Form1.vb))
<!-- default file list end -->
# How to apply summary filter


<p>The following example shows how to apply a summary filter to PivotGridControl data that belongs to a particular aggregation level. </p><p>In this example, PivotGridControl displays product sales by country. The summary filter is applied to country totals calculated for individual products, so that only values that fall into the range from 500 to 2500 are included. </p><p>The range of included values is specified using the PivotSummaryFilter.StartValue and PivotSummaryFilter.EndValue properties. To enable filtering only for the selected aggregation level, the PivotSummaryFilter.Mode property is set to PivotSummaryFilterMode.SpecificLevel. To identify this level, the PivotSummaryFilter.RowField and PivotSummaryFilter.ColumnField properties are set to fieldProductName and fieldCountry respectively.</p><br />


<br/>


