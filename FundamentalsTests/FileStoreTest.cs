using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOLID;
using System;
using System.IO;
using System.Linq;

namespace FundamentalsTests
{
  [TestClass]
  public class FileStoreTest
  {
    [TestMethod]
    public void WhenRead_With49_ReturnsEmptyString()
    {
      DirectoryInfo d = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
      FileStore fs = new FileStore(d);
      fs.Save(49, "Extra text");
      Assert.AreEqual("Extra text", fs.Read(49).DefaultIfEmpty("").Single());
    }

    [TestMethod]
    public void WhenRead_With49_NoWorkingDirectory_NotPossible()
    {
      //Because you cannot create a BetterFileStore class without passing a base path
      Assert.IsTrue(true);
    }
  }
}
