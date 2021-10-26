using System;
using System.Windows;
using Core;

namespace Presentation
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      BuildPlot1(this, EventArgs.Empty);
    }

    private void BuildPlot1(object sender, EventArgs e)
    {
      _canvas.Children.Clear();
      PlotBuilder1.Build(_canvas);
    }

    private void BuildPlot2(object sender, EventArgs e)
    {
      _canvas.Children.Clear();
      PlotBuilder2.Build(_canvas);
    }

    private void BuildPlot3(object sender, EventArgs e)
    {
      _canvas.Children.Clear();
      PlotBuilder3.Build(_canvas);
    }
  }
}
