using System.IO;

namespace SOLID
{
  public class MessageStoreLog4Net : MessageStore
  {
    public MessageStoreLog4Net(DirectoryInfo workingDirectory)
      : base(workingDirectory)
    {

    }

    public override StoreLogger Log
    {
      get { return new StoreLogger4Net(this.Store); }
    }

  }
  
}