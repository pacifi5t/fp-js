using System;
using System.Windows;
using Core;
 
using System.Data;

namespace Presentation
{
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      Build(this, EventArgs.Empty);
    }
    DataTable dt;
    private void Build(object sender, EventArgs e)
    {
            dt = new DataTable("emp");

            DataColumn dc1 = new DataColumn("id", typeof(int));

            DataColumn dc2 = new DataColumn("name", typeof(string));

            DataColumn dc3 = new DataColumn("email", typeof(string));

            DataColumn dc4 = new DataColumn("city", typeof(string));

            dt.Columns.Add(dc1);

            dt.Columns.Add(dc2);

            dt.Columns.Add(dc3);

            dt.Columns.Add(dc4);

            dataGrid1.ItemsSource = dt.DefaultView;
            /* Controller.Build(dt);*/
        }
    DataRow dr;
    private void insertData_Click(object sender, RoutedEventArgs e)
    {
        dr = dt.NewRow();

        dr[0] = int.Parse(textBox1.Text);

        dr[1] = textBox2.Text;

        dr[2] = textBox3.Text;

        dr[3] = textBox4.Text;

        dt.Rows.Add(dr);

        dataGrid1.ItemsSource = dt.DefaultView;

        textBox1.Focus();
    }
    private void clearTextBox_Click(object sender, RoutedEventArgs e)
    {
        textBox1.Clear();

        textBox2.Clear();

        textBox3.Clear();

        textBox4.Clear();
    }

    private void deleteData_Click(object sender, RoutedEventArgs e)
    {
        dataGrid1.ItemsSource = dt.DefaultView;

        dt.Rows.Remove(dr);

            textBox1.Focus();
    }
  }
}
