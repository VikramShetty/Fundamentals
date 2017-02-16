using System;
using System.IO;
using System.Linq;

namespace SOLID
{
  public class MessageStore
  {
    private readonly IStoreWriter writer;
    private readonly IStoreReader reader;
    private readonly IFileLocator fileLocator;
    public MessageStore(IStoreWriter writer,
      IStoreReader reader,
      IFileLocator fileLocator
      )
    {
      if (writer == null)
        throw new ArgumentNullException("writer");
      if (reader == null)
        throw new ArgumentNullException("reader");
      if (fileLocator == null)
        throw new ArgumentNullException("fileLocator");

      this.fileLocator = fileLocator;
      this.writer = writer;
      this.reader = reader;
    }
    
    public DirectoryInfo WorkingDirectory { get; private set; }

    public void Save(int id, string message)
    {
      writer.Save(id,message);
    }

    public Maybe<string> Read(int id)
    {
      return this.reader.Read(id);
    }

    public FileInfo GetFileInfo(int id)
    {
      return this.fileLocator.GetFileInfo(id);
    }
    
    public virtual IStoreWriter Writer
    {
      get { return this.writer; }
    }

    public virtual IStoreReader Reader
    {
      get { return this.reader; }
    }

    public virtual IFileLocator FileLocator
    {
      get { return this.fileLocator; }
    }
  }
}
