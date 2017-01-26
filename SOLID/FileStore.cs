using System;
using System.IO;

namespace SOLID
{
  public class FileStore
  {
    public FileStore(string workingDirectory)
      {
        if (workingDirectory == null)
          throw new ArgumentNullException("workingDirectory");
        if(!Directory.Exists(workingDirectory))
          throw new ArgumentException("You tried to provide a working directory string that doesn't represent a working directory. It's not your fault, but please supply a valid path to an existing directory."
            , "workingDirectory");

        this.WorkingDirectory = workingDirectory;
      }

      public string WorkingDirectory { get; private set; }

      public void Save(int id, string message)
      {
        var path = GetFileName(id); //ok to query from command
        File.WriteAllText(path, message);
      }

      public Maybe<string> Read(int id)
      {
        var path = GetFileName(id);
        if (!File.Exists(path))
          return new Maybe<string>();
        var message = File.ReadAllText(path);
        return new Maybe<string>(message);
      }

      public string GetFileName(int id)
      {
        return Path.Combine(this.WorkingDirectory, id + ".txt");
      }
  }
}
