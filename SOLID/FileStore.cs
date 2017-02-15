using System;
using System.IO;

namespace SOLID
{
  public class FileStore : IStore
  {
    private readonly DirectoryInfo workingDirectory;
    public FileStore(DirectoryInfo workingDirectory)
    {
      if(workingDirectory == null)
        throw new ArgumentNullException("workingDirectory");
      if(!workingDirectory.Exists)
        throw new ArgumentException("Directory doesn't Exist", "workingDirectory");

      this.workingDirectory = workingDirectory;
    }
    public virtual void WriteAllText(string path, string message)
    {
      File.WriteAllText(path, message);
    }

    public virtual string ReadAllText(string path)
    {
      return File.ReadAllText(path);
    }

    public virtual FileInfo GetFileInfo(int id)
    {
      return new FileInfo(Path.Combine(this.workingDirectory.FullName, id + ".txt"));
    }
  }
}
