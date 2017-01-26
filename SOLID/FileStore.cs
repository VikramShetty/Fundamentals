using System;
using System.Collections.Concurrent;
using System.IO;

namespace SOLID
{
  public class FileStore
  {
    private readonly StoreCache cache;
    private readonly StoreLogger log;
    public FileStore(DirectoryInfo workingDirectory)
    {
      if (workingDirectory == null)
        throw new ArgumentNullException("workingDirectory");
      if (!Directory.Exists(workingDirectory.FullName))
        throw new ArgumentException("You tried to provide a working directory string that doesn't represent a working directory. It's not your fault, but please supply a valid path to an existing directory."
          , "workingDirectory");

      this.WorkingDirectory = workingDirectory;
      this.cache = new StoreCache();
      this.log = new StoreLogger();
    }

    public DirectoryInfo WorkingDirectory { get; private set; }

    public void Save(int id, string message)
    {
      this.log.Saving(id);
      var file = GetFileInfo(id); //ok to query from command
      File.WriteAllText(file.FullName, message);
      this.cache.AddOrUpdate(id, message);
      this.log.Saved(id);
    }

    public Maybe<string> Read(int id)
    {
      this.log.Reading(id);
      var file = GetFileInfo(id);
      if (!file.Exists)
      {
        this.log.DidNotFind(id);
        return new Maybe<string>();
      }
      var message = this.cache.GetOrAdd(id, _ =>
        File.ReadAllText(file.FullName));

      this.log.Returning(id);
      return new Maybe<string>(message);
    }

    public FileInfo GetFileInfo(int id)
    {
      return new FileInfo(Path.Combine(this.WorkingDirectory.FullName, id + ".txt"));
    }
  }
}
