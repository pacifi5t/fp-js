namespace Core

open System.Windows.Controls
open System.Windows.Media

module PlotBuilder1 =
  let Build (canvas: Canvas) = 
    let context = CanvasContext(canvas)
    context.SetStrokeThickness 2.
    context.SetColor Colors.Black
    // Borders for plot
    context.MoveTo(30., 10.)
    context.LineTo(30., 460.)
    context.LineTo(500., 460.)

    // Plotting scale and numbers
    for i = 0 to 5 do
      context.SetText($"{(5 - i) * 100}", float 4, float (i * 80 + 60))
      context.MoveTo(25., float (i * 80 + 60)); 
      context.LineTo(30., float (i * 80 + 60));

    // Drawing the plot
    let canvasHeight = 500.
    let x = [70.; 200.; 300.; 390.; 430.]
    let y = [60.; 300.; 150.; 200.; 340.]
    context.MoveTo(x.Head, canvasHeight - y.Head)
    for i = 1 to (x.Length - 1) do
      context.LineTo(x.[i], canvasHeight - y.[i])
