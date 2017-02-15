using System.IO;

namespace SOLID
{
  public interface IStoreWriter
  {
    void Save(int id, string message);
  }
}
