using System.IO;

namespace SOLID
{
  public interface IFileLocator
  {
    FileInfo GetFileInfo(int id);
  }
}
