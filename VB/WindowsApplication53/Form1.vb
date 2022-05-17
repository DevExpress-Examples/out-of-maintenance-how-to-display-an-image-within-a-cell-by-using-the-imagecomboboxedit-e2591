Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls

Namespace WindowsApplication53

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
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
            Next

            repositoryItemImageComboBox2.LargeImages = imageCollection1
            For i As Integer = 0 To imageCollection1.Images.Count - 1
                repositoryItemImageComboBox2.Items.Add(New ImageComboBoxItem(String.Format("Image {0}", i), i, i))
            Next
        End Sub

        Private Sub PopulateTable()
            Dim myTable As DataTable = dataSet1.Tables("Data")
            myTable.Rows.Add(New Object() {"Aaa", Date.Today, 0})
            myTable.Rows.Add(New Object() {"Aaa", Date.Today.AddDays(1), 1})
            myTable.Rows.Add(New Object() {"Bbb", Date.Today, 3})
            myTable.Rows.Add(New Object() {"Bbb", Date.Today.AddDays(1), 1})
            myTable.Rows.Add(New Object() {"Ccc", Date.Today, 2})
            myTable.Rows.Add(New Object() {"Ccc", Date.Today.AddDays(1), 1})
            myTable.Rows.Add(New Object() {"Aaa", Date.Today.AddYears(1), 0})
            myTable.Rows.Add(New Object() {"Aaa", Date.Today.AddYears(1).AddDays(1), 1})
            myTable.Rows.Add(New Object() {"Bbb", Date.Today.AddYears(1), 2})
            myTable.Rows.Add(New Object() {"Bbb", Date.Today.AddDays(1).AddYears(1), 2})
            myTable.Rows.Add(New Object() {"Ccc", Date.Today.AddYears(1), 1})
            myTable.Rows.Add(New Object() {"Ccc", Date.Today.AddDays(1).AddYears(1), 3})
        End Sub
    End Class
End Namespace
