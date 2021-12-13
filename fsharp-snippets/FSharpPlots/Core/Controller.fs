namespace Core

open System.Data;

module Controller =
  let Build (dt: DataTable) =
     let dt = new DataTable("emp");
     let dc1 = new DataColumn("id");
     
     let dc2 = new DataColumn("name");
     
     let dc3 = new DataColumn("email");
     
     let dc4 = new DataColumn("city");
     
     dt.Columns.Add(dc1);
     
     dt.Columns.Add(dc2);
     
     dt.Columns.Add(dc3);
     
     dt.Columns.Add(dc4);
 
