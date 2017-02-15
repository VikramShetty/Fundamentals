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
    public void WriteAllText(int id, string message)
    {
      table.Rows.Add(id, message);
    }

    public string ReadAllText(string path)
    {
      string val = "";
      foreach (DataRow row in table.Rows)
      {
        if (row["ID"].ToString() == path)
          val = row["Message"].ToString();
      }
      return val;
    }

    public System.IO.FileInfo GetFileInfo(int id)
    {
      throw new NotSupportedException();
    }
  }
}
