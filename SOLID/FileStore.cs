﻿using System;
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
    public virtual void WriteAllText(int id, string message)
    {
      File.WriteAllText(this.GetFileInfo(id).FullName, message);
    }

    public virtual Maybe<string> ReadAllText(int id)
    {
      return new Maybe<string>(File.ReadAllText(GetFileInfo(id).FullName));
    }

    public virtual FileInfo GetFileInfo(int id)
    {
      return new FileInfo(Path.Combine(this.workingDirectory.FullName, id + ".txt"));
    }
  }
}
