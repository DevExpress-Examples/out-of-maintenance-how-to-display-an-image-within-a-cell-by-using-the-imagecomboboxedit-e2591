<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581869/10.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2591)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication53/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication53/Form1.vb))
* [Program.cs](./CS/WindowsApplication53/Program.cs) (VB: [Program.vb](./VB/WindowsApplication53/Program.vb))
<!-- default file list end -->
# How to display an image within a cell by using the ImageComboBoxEdit


<p>This example demonstrates how to use the <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsRepositoryRepositoryItemImageComboBoxtopic"><u>RepositoryItemImageComboBox</u></a> class to show images within cells. Please note that the type of the summary value calculated for cells should match the type of the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsControlsComboBoxItem_Valuetopic"><u>ComboBoxItem.Value</u></a> object. In the attached example, the value of the data source field and item values are <i>Integer</i><i>.</i><i> </i>Moreover, the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridFieldBase_SummaryTypetopic"><u>PivotGridFieldBase.SummaryType</u></a> property of the corresponding data fields is set to <i>M</i><i>ax</i><i>,</i><i> </i>otherwise, the value can be automatically converted to decimal format by XtraPivotGrid control. Please use the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridFieldBase_RowValueLineCounttopic"><u>PivotGridFieldBase.RowValueLineCount</u></a> property to specify row height.</p>

<br/>


