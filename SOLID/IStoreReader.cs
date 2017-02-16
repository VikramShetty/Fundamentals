namespace SOLID
{
  public interface IStoreReader
  {
    Maybe<string> Read(int id);
  }
}
