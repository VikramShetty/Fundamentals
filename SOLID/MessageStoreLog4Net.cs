using System.IO;

namespace SOLID
{
  public class MessageStoreLog4Net : MessageStore
  {
    public MessageStoreLog4Net(IStoreWriter writer,
      IStoreReader reader,
      IFileLocator fileLocator)
      : base(writer,reader,fileLocator)
    {

    }
  }
  
}