# How to apply summary filter


<p>The following example shows how to apply a summary filter to PivotGridControl data that belongs to a particular aggregation level. </p><p>In this example, PivotGridControl displays product sales by country. The summary filter is applied to country totals calculated for individual products, so that only values that fall into the range from 500 to 2500 are included. </p><p>The range of included values is specified using the PivotSummaryFilter.StartValue and PivotSummaryFilter.EndValue properties. To enable filtering only for the selected aggregation level, the PivotSummaryFilter.Mode property is set to PivotSummaryFilterMode.SpecificLevel. To identify this level, the PivotSummaryFilter.RowField and PivotSummaryFilter.ColumnField properties are set to fieldProductName and fieldCountry respectively.</p><br />


<br/>


