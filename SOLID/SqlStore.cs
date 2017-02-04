using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
  public class SqlStore : IStore
  {
    public void WriteAllText(string path, string message)
    {
      //Write to database
    }

    public string ReadAllText(string path)
    {
      //Read and return from database here
      return "";
    }

    public System.IO.FileInfo GetFileInfo(int id, string workingDirectory)
    {
      throw new NotSupportedException();
    }
  }
}
