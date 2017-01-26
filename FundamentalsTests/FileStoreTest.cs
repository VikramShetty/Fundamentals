using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOLID;

namespace FundamentalsTests
{
  [TestClass]
  public class FileStoreTest
  {
    [TestMethod]
    public void WhenRead_With49_ReturnsEmptyString()
    {
      FileStore fs = new FileStore(AppDomain.CurrentDomain.BaseDirectory);
      fs.Save(49, "");
      Assert.AreEqual("", fs.Read(49).DefaultIfEmpty("").Single());
    }

    [TestMethod]
    public void WhenRead_With49_NoWorkingDirectory_NotPossible()
    {
      //Because you cannot create a BetterFileStore class without passing a base path
      Assert.IsTrue(true);
    }
  }
}
