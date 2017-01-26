using System;
using System.Collections.Concurrent;
using System.IO;

namespace SOLID
{
  public class FileStore
  {
    private readonly ConcurrentDictionary<int, string> cache;
    public FileStore(DirectoryInfo workingDirectory)
    {
      if (workingDirectory == null)
        throw new ArgumentNullException("workingDirectory");
      if (!Directory.Exists(workingDirectory.FullName))
        throw new ArgumentException("You tried to provide a working directory string that doesn't represent a working directory. It's not your fault, but please supply a valid path to an existing directory."
          , "workingDirectory");

      this.WorkingDirectory = workingDirectory;

      cache = new ConcurrentDictionary<int, string>();
    }

    public DirectoryInfo WorkingDirectory { get; private set; }

    public void Save(int id, string message)
    {
      Log.Information("Saving Message {id}", id);
      var file = GetFileInfo(id); //ok to query from command
      File.WriteAllText(file.FullName, message);
      this.cache.AddOrUpdate(id, message, (i, s) => message);
      Log.Information("Saved Message {id}", id);
    }

    public Maybe<string> Read(int id)
    {
      Log.Debug("Reading Message {id}", id);
      var file = GetFileInfo(id);
      if (!file.Exists)
      {
        Log.Debug("No Message {id} found", id);
        return new Maybe<string>();
      }
      var message = this.cache.GetOrAdd(id, _ =>
        File.ReadAllText(file.FullName));

      Log.Debug("Reading Message {id}", id);
      return new Maybe<string>(message);
    }

    public FileInfo GetFileInfo(int id)
    {
      return new FileInfo(Path.Combine(this.WorkingDirectory.FullName, id + ".txt"));
    }
  }
}
