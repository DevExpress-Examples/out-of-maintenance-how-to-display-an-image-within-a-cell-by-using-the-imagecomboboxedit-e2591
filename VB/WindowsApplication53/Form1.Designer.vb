Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication53
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim DataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding5 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.dataSet1 = New System.Data.DataSet()
            Me.dataTable1 = New System.Data.DataTable()
            Me.dataColumn1 = New System.Data.DataColumn()
            Me.dataColumn2 = New System.Data.DataColumn()
            Me.dataColumn3 = New System.Data.DataColumn()
            Me.fieldName1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldDate2 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldValue1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.repositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.fieldValue = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.fieldDate = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pivotGridControl1
            '
            Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
            Me.pivotGridControl1.DataMember = "Data"
            Me.pivotGridControl1.DataSource = Me.dataSet1
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldName1, Me.fieldDate2, Me.fieldValue1, Me.fieldValue, Me.fieldDate})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemImageComboBox1, Me.repositoryItemImageComboBox2})
            Me.pivotGridControl1.Size = New System.Drawing.Size(796, 292)
            Me.pivotGridControl1.TabIndex = 0
            '
            'dataSet1
            '
            Me.dataSet1.DataSetName = "NewDataSet"
            Me.dataSet1.Tables.AddRange(New System.Data.DataTable() {Me.dataTable1})
            '
            'dataTable1
            '
            Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.dataColumn1, Me.dataColumn2, Me.dataColumn3})
            Me.dataTable1.TableName = "Data"
            '
            'dataColumn1
            '
            Me.dataColumn1.ColumnName = "Name"
            '
            'dataColumn2
            '
            Me.dataColumn2.ColumnName = "Date"
            Me.dataColumn2.DataType = GetType(Date)
            '
            'dataColumn3
            '
            Me.dataColumn3.ColumnName = "Value"
            Me.dataColumn3.DataType = GetType(Integer)
            '
            'fieldName1
            '
            Me.fieldName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldName1.AreaIndex = 0
            DataSourceColumnBinding1.ColumnName = "Name"
            Me.fieldName1.DataBinding = DataSourceColumnBinding1
            Me.fieldName1.Name = "fieldName1"
            Me.fieldName1.RowValueLineCount = 3
            '
            'fieldDate2
            '
            Me.fieldDate2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldDate2.AreaIndex = 0
            Me.fieldDate2.Caption = "Year"
            DataSourceColumnBinding2.ColumnName = "Date"
            DataSourceColumnBinding2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldDate2.DataBinding = DataSourceColumnBinding2
            Me.fieldDate2.Name = "fieldDate2"
            '
            'fieldValue1
            '
            Me.fieldValue1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldValue1.AreaIndex = 0
            Me.fieldValue1.Caption = "Image+Text"
            DataSourceColumnBinding3.ColumnName = "Value"
            Me.fieldValue1.DataBinding = DataSourceColumnBinding3
            Me.fieldValue1.FieldEdit = Me.repositoryItemImageComboBox2
            Me.fieldValue1.Name = "fieldValue1"
            Me.fieldValue1.Options.AllowEdit = False
            Me.fieldValue1.Options.ShowButtonMode = DevExpress.XtraPivotGrid.PivotShowButtonModeEnum.ShowOnlyInEditor
            '
            'repositoryItemImageComboBox2
            '
            Me.repositoryItemImageComboBox2.AutoHeight = False
            Me.repositoryItemImageComboBox2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.repositoryItemImageComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox2.DisplayFormat.FormatString = "c"
            Me.repositoryItemImageComboBox2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2"
            '
            'fieldValue
            '
            Me.fieldValue.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldValue.AreaIndex = 1
            Me.fieldValue.Caption = "Image"
            DataSourceColumnBinding4.ColumnName = "Value"
            Me.fieldValue.DataBinding = DataSourceColumnBinding4
            Me.fieldValue.FieldEdit = Me.repositoryItemImageComboBox1
            Me.fieldValue.Name = "fieldValue"
            Me.fieldValue.Options.AllowEdit = False
            Me.fieldValue.Options.ShowButtonMode = DevExpress.XtraPivotGrid.PivotShowButtonModeEnum.ShowOnlyInEditor
            '
            'repositoryItemImageComboBox1
            '
            Me.repositoryItemImageComboBox1.AutoHeight = False
            Me.repositoryItemImageComboBox1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox1.DisplayFormat.FormatString = "c"
            Me.repositoryItemImageComboBox1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            '
            'fieldDate
            '
            Me.fieldDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldDate.AreaIndex = 1
            Me.fieldDate.Caption = "Date"
            DataSourceColumnBinding5.ColumnName = "Date"
            DataSourceColumnBinding5.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.[Date]
            Me.fieldDate.DataBinding = DataSourceColumnBinding5
            Me.fieldDate.Name = "fieldDate"
            '
            'imageCollection1
            '
            Me.imageCollection1.ImageSize = New System.Drawing.Size(32, 32)
            Me.imageCollection1.ImageStream = CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
            Me.imageCollection1.TransparentColor = System.Drawing.Color.Fuchsia
            Me.imageCollection1.Images.SetKeyName(0, "arrowright_green_32.bmp")
            Me.imageCollection1.Images.SetKeyName(1, "arrowright_green_32_d.bmp")
            Me.imageCollection1.Images.SetKeyName(2, "delete_x_32.bmp")
            Me.imageCollection1.Images.SetKeyName(3, "history_32.bmp")
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(796, 292)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private dataColumn2 As System.Data.DataColumn
		Private dataColumn3 As System.Data.DataColumn
		Private fieldName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldDate2 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldValue1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldValue As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldDate As DevExpress.XtraPivotGrid.PivotGridField
		Private repositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
		Private imageCollection1 As DevExpress.Utils.ImageCollection
	End Class
End Namespace

