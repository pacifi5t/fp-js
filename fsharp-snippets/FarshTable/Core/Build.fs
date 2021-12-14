namespace Core

open System.Data;
 

module BuildController =
  let Build (dt: DataTable) =
     

     dt.Columns.Add( new DataColumn("id"));
     
     dt.Columns.Add(new DataColumn("name"));
     
     dt.Columns.Add(new DataColumn("email"));
     
     dt.Columns.Add(new DataColumn("city"));


    
 
