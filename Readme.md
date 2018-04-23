# How to display an image within a cell by using the ImageComboBoxEdit


<p>This example demonstrates how to use the <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsRepositoryRepositoryItemImageComboBoxtopic"><u>RepositoryItemImageComboBox</u></a> class to show images within cells. Please note that the type of the summary value calculated for cells should match the type of the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsControlsComboBoxItem_Valuetopic"><u>ComboBoxItem.Value</u></a> object. In the attached example, the value of the data source field and item values are <i>Integer</i><i>.</i><i> </i>Moreover, the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridFieldBase_SummaryTypetopic"><u>PivotGridFieldBase.SummaryType</u></a> property of the corresponding data fields is set to <i>M</i><i>ax</i><i>,</i><i> </i>otherwise, the value can be automatically converted to decimal format by XtraPivotGrid control. Please use the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridFieldBase_RowValueLineCounttopic"><u>PivotGridFieldBase.RowValueLineCount</u></a> property to specify row height.</p>

<br/>


