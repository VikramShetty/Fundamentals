using System;
using System.IO;
using System.Linq;

namespace SOLID
{
  public class MessageStore
  {
    private readonly StoreCache cache;
    private readonly StoreLogger log;
    private readonly IStore store;
    private readonly IFileLocator fileLocator;
    private readonly IStoreWriter writer;
    private readonly IStoreReader reader;
    public MessageStore(DirectoryInfo workingDirectory)
    {
      if (workingDirectory == null)
        throw new ArgumentNullException("workingDirectory");
      if (!Directory.Exists(workingDirectory.FullName))
        throw new ArgumentException("You tried to provide a working directory string that doesn't represent a working directory. It's not your fault, but please supply a valid path to an existing directory."
          , "workingDirectory");

      this.WorkingDirectory = workingDirectory;
      var fileStore = new FileStore(workingDirectory);
      var c = new StoreCache(fileStore,fileStore);
      this.cache = c;
      var l = new StoreLogger(c,c);
      this.log = l;
      this.store = fileStore;
      this.fileLocator = fileStore;
      this.writer = l;
      this.reader = l;
    }
    
    public DirectoryInfo WorkingDirectory { get; private set; }

    public void Save(int id, string message)
    {
      writer.Save(id,message);
    }

    public Maybe<string> Read(int id)
    {
      return this.Cache.Read(id);
    }

    public FileInfo GetFileInfo(int id)
    {
      return this.fileLocator.GetFileInfo(id);
    }

    public virtual IStore Store
    {
      get { return this.store; }
    }

    public virtual IStoreWriter StoreWriter
    {
      get { return this.writer; }
    }

    public virtual IStoreReader StoreReader
    {
      get { return this.reader; }
    }

    public virtual StoreCache Cache
    {
      get { return this.cache; }
    }

    public virtual StoreLogger Log
    {
      get { return this.log; }
    }
  }
}
