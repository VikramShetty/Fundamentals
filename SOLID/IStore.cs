using System.IO;

namespace SOLID
{
  public interface IStore
  {
    void Save(int id, string message);

    Maybe<string> ReadAllText(int id);

    FileInfo GetFileInfo(int id);
  }
}
