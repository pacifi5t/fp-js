namespace Core

open System
open System.Windows.Controls
open System.Windows.Media

module PlotBuilder2 =
  let Build (canvas: Canvas) = 
    let context = CanvasContext(canvas)
    context.SetStrokeThickness 2.
    context.SetColor Colors.Black

    // Borders for plot
    context.MoveTo(250., 0.)
    context.LineTo(250., 500.)
    context.MoveTo(0., 250.)
    context.LineTo(500., 250.)
    context.MoveTo(250., 250.)

    // Plotting scale and numbers
    for i = -5 to 5 do
      context.SetText($"{i}", float (i * 55 + 250), 270.)
      if i <> 0 then
        context.SetText($"{i}", 270., float (-i * 55 + 250))
      
      context.MoveTo(float (i * 55 + 250), 240.); 
      context.LineTo(float (i * 55 + 250), 260.);
      context.MoveTo(240., float(i * 55 + 250));
      context.LineTo(260., float(i * 55 + 250));

    context.MoveTo(0., 250.); 
    context.SetColor Colors.Red
    // Drawing the plot    
    for x = -180 to 720 do
       let y = 180.0 - Math.Sin(float x * Math.PI / 180.) * 120.; 
       context.LineTo(70. + float x,  70. + y);
