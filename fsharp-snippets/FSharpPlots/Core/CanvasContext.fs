namespace Core

open System.Windows
open System.Windows.Controls
open System.Windows.Shapes
open System.Windows.Media

type private CanvasContext(_canvas: Canvas) = class
  let mutable _lastPoint = Point(0., 0.)
  let mutable _color = Colors.Black
  let mutable _strokeThickness = 2.

  member a.SetColor(color: Color) =
    _color <- color

  member a.SetStrokeThickness(newThickness: float) =
    _strokeThickness <- newThickness

  member a.MoveTo(x: float, y: float) =
    _lastPoint <- Point(x, y)

  member a.LineTo(x: float, y: float) =
    let line = Line(Fill = SolidColorBrush(_color), Stroke = SolidColorBrush(_color), StrokeThickness = _strokeThickness, X1 = _lastPoint.X, Y1 = _lastPoint.Y, X2 = x, Y2 = y)
    _lastPoint <- Point(x, y)
    _canvas.Children.Add(line) |> ignore

  member a.SetText(text: string, x: float, y: float) =
    let textBlock = TextBlock(Text = text)
    _canvas.Children.Add(textBlock) |> ignore
    Canvas.SetTop(textBlock, y - 10.)
    Canvas.SetLeft(textBlock, x)

  member a.FillRect(x: float, y: float, width: float, height: float) =
    let rectange = Rectangle(Width = width, Height = height, Fill = SolidColorBrush(_color))
    _canvas.Children.Add(rectange) |> ignore
    Canvas.SetTop(rectange, y)
    Canvas.SetLeft(rectange, x)

end