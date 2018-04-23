Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls

Namespace WindowsApplication53
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

			AssignImages()
			PopulateTable()
			pivotGridControl1.RefreshData()
			pivotGridControl1.BestFit()
		End Sub
		Private Sub AssignImages()
			repositoryItemImageComboBox1.LargeImages = imageCollection1
			repositoryItemImageComboBox1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center

			For i As Integer = 0 To imageCollection1.Images.Count - 1
				repositoryItemImageComboBox1.Items.Add(New ImageComboBoxItem(i, i))
			Next i

			repositoryItemImageComboBox2.LargeImages = imageCollection1
			For i As Integer = 0 To imageCollection1.Images.Count - 1
				repositoryItemImageComboBox2.Items.Add(New ImageComboBoxItem(String.Format("Image {0}", i), i, i))
			Next i


		End Sub
		Private Sub PopulateTable()
			Dim myTable As DataTable = dataSet1.Tables("Data")
			myTable.Rows.Add(New Object() {"Aaa", DateTime.Today, 0})
			myTable.Rows.Add(New Object() { "Aaa", DateTime.Today.AddDays(1), 1 })
			myTable.Rows.Add(New Object() { "Bbb", DateTime.Today, 3 })
			myTable.Rows.Add(New Object() { "Bbb", DateTime.Today.AddDays(1), 1 })
			myTable.Rows.Add(New Object() { "Ccc", DateTime.Today, 2})
			myTable.Rows.Add(New Object() { "Ccc", DateTime.Today.AddDays(1), 1 })

			myTable.Rows.Add(New Object() { "Aaa", DateTime.Today.AddYears(1), 0 })
			myTable.Rows.Add(New Object() { "Aaa", DateTime.Today.AddYears(1).AddDays(1), 1 })
			myTable.Rows.Add(New Object() { "Bbb", DateTime.Today.AddYears(1), 2 })
			myTable.Rows.Add(New Object() { "Bbb", DateTime.Today.AddDays(1).AddYears(1), 2 })
			myTable.Rows.Add(New Object() { "Ccc", DateTime.Today.AddYears(1), 1 })
			myTable.Rows.Add(New Object() { "Ccc", DateTime.Today.AddDays(1).AddYears(1), 3 })
		End Sub

	End Class
End Namespace