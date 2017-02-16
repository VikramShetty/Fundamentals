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
    public MessageStore(DirectoryInfo workingDirectory)
    {
      if (workingDirectory == null)
        throw new ArgumentNullException("workingDirectory");
      if (!Directory.Exists(workingDirectory.FullName))
        throw new ArgumentException("You tried to provide a working directory string that doesn't represent a working directory. It's not your fault, but please supply a valid path to an existing directory."
          , "workingDirectory");

      this.WorkingDirectory = workingDirectory;
      this.cache = new StoreCache();
      this.log = new StoreLogger();
      var fileStore = new FileStore(workingDirectory);
      this.store = fileStore;
      this.fileLocator = fileStore;
    }
    
    public DirectoryInfo WorkingDirectory { get; private set; }

    public void Save(int id, string message)
    {
      new LogSavingStoreWriter().Save(id, message);
      this.Store.Save(id, message);
      this.Cache.Save(id, message);
      new LogSavedStoreWriter().Save(id, message);
    }

    public Maybe<string> Read(int id)
    {
      this.Log.Reading(id);
      var message = this.Cache.GetOrAdd(id, _ =>
       this.Store.ReadAllText(id));

      if(message.Any())
        this.Log.Returning(id);
      else 
        this.Log.DidNotFind(id);

      return message;
    }

    public FileInfo GetFileInfo(int id)
    {
      return this.fileLocator.GetFileInfo(id);
    }

    public virtual IStore Store
    {
      get { return this.store; }
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
