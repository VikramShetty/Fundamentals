using System.IO;

namespace SOLID
{
  public interface IStore
  {
    void WriteAllText(string path, string message);

    string ReadAllText(string path);

    FileInfo GetFileInfo(int id, string workingDirectory);
  }
}
