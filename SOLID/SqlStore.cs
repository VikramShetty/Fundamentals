using System;
using System.Data;

namespace SOLID
{
  public class SqlStore : IStoreReader, IStoreWriter
  {
    DataTable table = new DataTable();
    public SqlStore()
    {
      table.Columns.Add("Id", typeof(int));
      table.Columns.Add("Message", typeof(string));
    }
    public void Save(int id, string message)
    {
      table.Rows.Add(id, message);
    }

    public Maybe<string> Read(int id)
    {
      string val = "";
      foreach (DataRow row in table.Rows)
      {
        if (Convert.ToInt32(row["ID"]) == id)
          val = row["Message"].ToString();
      }
      var m = new Maybe<string>(val);
      return m;
    }
  }
}
