namespace Core

open System
open System.Windows.Controls
open System.Windows.Media

module PlotBuilder3 =
  let Build (canvas: Canvas) = 
    let context = CanvasContext(canvas)
    context.SetStrokeThickness 2.
    context.SetColor Colors.Black

    // Borders for plot
    context.MoveTo(30., 10.);
    context.LineTo(30., 460.); 
    context.LineTo(500., 460.); 

    // Plotting scale and numbers
    for i = 0 to 5 do
      context.SetText($"{(5 - i) * 20}", 4., float i * 80. + 60.); 
      context.MoveTo(25., float i * 80. + 60.); 
      context.LineTo(30., float i * 80. + 60.); 
    
    let labels = ["JAN"; "FEB"; "MAR"; "APR"; "MAY"]
    
    for i = 0 to 4 do
      context.SetText(labels.[i], 50. + float i * 100., 475.); 

    // Drawing the plot
    context.SetColor Colors.Green
    let data = [10.; 53.; 39.; 54.; 21.] 

    for i = 0 to (data.Length - 1) do
       let currentBar = data.[i]; 
       context.FillRect(40. + float i * 100., 460. - currentBar * 5., 50., currentBar * 5.); 
      