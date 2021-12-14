using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Core;
 
using System.Data;

namespace Presentation
{
  public partial class MainWindow : Window
  {
    List<TextBox> textBoxes = new List<TextBox>();
    public MainWindow()
    {
         InitializeComponent();
         Build(this, EventArgs.Empty);
         
         textBoxes.Add(textBox1);
         textBoxes.Add(textBox2);
         textBoxes.Add(textBox3);
         textBoxes.Add(textBox4);
    }

    DataTable dt;
    DataRow dr;

    private void Build(object sender, EventArgs e)
    {
         dt = new DataTable("emp");

         BuildController.Build(dt);

         dataGrid1.ItemsSource = dt.DefaultView;
    }
     
    private void insertData_Click(object sender, RoutedEventArgs e)
    {
        InserController.Insert(textBoxes, dt);
     
        dataGrid1.ItemsSource = dt.DefaultView;
    }
    private void clearTextBox_Click(object sender, RoutedEventArgs e)
    {
        ClearController.Clear(textBoxes);
    }

    private void deleteData_Click(object sender, RoutedEventArgs e)
    {
        dataGrid1.ItemsSource = dt.DefaultView;
        
        try
        {
            dt.Rows.Remove(dr);
        }
         catch { 
            
        }
    }
  }
}
