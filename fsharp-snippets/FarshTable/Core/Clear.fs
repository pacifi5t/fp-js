namespace Core

open System.Windows.Controls
open System.Collections.Generic

module ClearController =
  let Clear (textBoxes: List<TextBox>) =
     
     for i = 0 to textBoxes.Count - 1 do 
        textBoxes.[i].Clear()
     


    
 
