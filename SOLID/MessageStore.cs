using System;
using System.IO;

namespace SOLID
{
  public class MessageStore
  {
    private readonly StoreCache cache;
    private readonly StoreLogger log;
    private readonly FileStore fileStore;
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
      this.fileStore = new FileStore();
    }
    
    public DirectoryInfo WorkingDirectory { get; private set; }

    public void Save(int id, string message)
    {
      this.Log.Saving(id);
      var file = GetFileInfo(id); //ok to query from command
      this.Store.WriteAllText(file.FullName, message);
      this.Cache.AddOrUpdate(id, message);
      this.Log.Saved(id);
    }

    public Maybe<string> Read(int id)
    {
      this.Log.Reading(id);
      var file = GetFileInfo(id);
      if (!file.Exists)
      {
        this.Log.DidNotFind(id);
        return new Maybe<string>();
      }
      var message = this.Cache.GetOrAdd(id, _ =>
        this.Store.ReadAllText(file.FullName));

      this.Log.Returning(id);
      return new Maybe<string>(message);
    }

    public FileInfo GetFileInfo(int id)
    {
      return this.fileStore.GetFileInfo(id, this.WorkingDirectory.FullName);
    }

    public virtual FileStore Store
    {
      get { return this.fileStore; }
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
