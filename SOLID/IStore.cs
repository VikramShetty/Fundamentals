using System.IO;

namespace SOLID
{
  public interface IStore : IStoreWriter , IFileLocator
  {
    Maybe<string> ReadAllText(int id);
  }
}
