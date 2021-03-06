﻿using System;
using System.IO;

namespace SOLID
{
  public class FileStore :  IFileLocator, IStoreReader , IStoreWriter
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
    public void Save(int id, string message)
    {
      File.WriteAllText(this.GetFileInfo(id).FullName, message);
    }

    public Maybe<string> Read(int id)
    {
      var file = this.GetFileInfo(id);
      if (!file.Exists)
        return new Maybe<string>();
      var path = file.FullName;
      return new Maybe<string>(File.ReadAllText(path));
    }

    public FileInfo GetFileInfo(int id)
    {
      return new FileInfo(Path.Combine(this.workingDirectory.FullName, id + ".txt"));
    }
  }
}
