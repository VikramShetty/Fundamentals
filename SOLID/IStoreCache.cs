namespace SOLID
{
  interface IStoreCache
  {
    Maybe<string> Read(int id);
  }
}
