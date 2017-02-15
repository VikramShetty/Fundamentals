using System.IO;

namespace SOLID
{
  public interface IStore
  {
    void WriteAllText(int id, string message);

    string ReadAllText(string path);

    FileInfo GetFileInfo(int id);
  }
}
