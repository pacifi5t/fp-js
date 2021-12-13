namespace Core

open System.Windows.Controls
open System.Collections.Generic

open System.Data

module InserController =
  let Insert (textBoxes: List<TextBox>, dt: DataTable)=
    let dr = dt.NewRow();

    for i=0 to textBoxes.Count - 1 do 
        dr.[i] <- textBoxes.[i].Text;
    
       
    dt.Rows.Add(dr);
          
     


    
 
