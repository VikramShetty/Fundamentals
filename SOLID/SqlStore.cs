using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
  public class SqlStore : IStore
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

    public Maybe<string> ReadAllText(int id)
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

    public System.IO.FileInfo GetFileInfo(int id)
    {
      throw new NotSupportedException();
    }
  }
}
