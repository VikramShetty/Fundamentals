using System.IO;

namespace SOLID
{
  public interface IStore : IStoreWriter
  {
    Maybe<string> ReadAllText(int id);
  }
}
