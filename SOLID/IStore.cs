﻿using System.IO;

namespace SOLID
{
  public interface IStore
  {
    Maybe<string> Read(int id);
  }
}
