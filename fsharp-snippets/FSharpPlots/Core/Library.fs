namespace Core

open System.Windows.Controls
open System.Windows.Shapes
open System.Windows.Media

module PlotBuilder1 =
  let Build (canvas: Canvas) = 
    let ellipse = Ellipse(Width = 100., Height = 50., Fill = SolidColorBrush(Colors.Red))
    canvas.Children.Add(ellipse)
