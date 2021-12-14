namespace Core

open System.Windows.Controls
open System.Collections.Generic

open System.Data

module DeleteController =
  let Delete ( dr: DataRow, dt:DataTable)=
     dt.Rows.Remove(dr) |> ignore
 
          
     


    
 
