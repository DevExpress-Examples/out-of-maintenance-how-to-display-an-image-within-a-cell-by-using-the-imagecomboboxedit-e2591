using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;

namespace WindowsApplication53
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            AssignImages();
            PopulateTable();
            pivotGridControl1.RefreshData();
            pivotGridControl1.BestFit();            
        }
        private void AssignImages()
        {
            repositoryItemImageComboBox1.LargeImages = imageCollection1;
            repositoryItemImageComboBox1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;

            for (int i = 0; i < imageCollection1.Images.Count ; i++)
                repositoryItemImageComboBox1.Items.Add(new ImageComboBoxItem( i, i));

            repositoryItemImageComboBox2.LargeImages = imageCollection1;
            for (int i = 0; i < imageCollection1.Images.Count; i++)
                repositoryItemImageComboBox2.Items.Add(new ImageComboBoxItem(string.Format("Image {0}", i), i, i));
 

        }
        private void PopulateTable()
        {
            DataTable myTable = dataSet1.Tables["Data"];
            myTable.Rows.Add(new object[] {"Aaa", DateTime.Today, 0});
            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today.AddDays(1), 1 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today, 3 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today.AddDays(1), 1 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today, 2});
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today.AddDays(1), 1 });

            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today.AddYears(1), 0 });
            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today.AddYears(1).AddDays(1), 1 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today.AddYears(1), 2 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today.AddDays(1).AddYears(1), 2 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today.AddYears(1), 1 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today.AddDays(1).AddYears(1), 3 });
        }
       
    }
}