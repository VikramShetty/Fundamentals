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
      this.store = new FileStore(workingDirectory);
    }
    
    public DirectoryInfo WorkingDirectory { get; private set; }

    public void Save(int id, string message)
    {
      this.Log.Saving(id, message);
      this.Store.WriteAllText(id, message);
      this.Cache.AddOrUpdate(id, message);
      this.Log.Saved(id, message);
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
      return this.store.GetFileInfo(id);
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
