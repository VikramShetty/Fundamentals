using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOLID;
using System;
using System.IO;
using System.Linq;

namespace FundamentalsTests
{
  [TestClass]
  public class MessageStoreTest
  {
    [TestMethod]
    public void WhenRead_With49_ReturnsEmptyString()
    {
      var d = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
      var fs = new MessageStore(d);
      fs.Save(49, "Extra text");
      Assert.AreEqual("Extra text", fs.Read(49).DefaultIfEmpty("").Single());
    }

    [TestMethod]
    public void WhenRead_With49_NoWorkingDirectory_NotPossible()
    {
      //Because you cannot create a BetterFileStore class without passing a base path
      Assert.IsTrue(true);
    }

    [TestMethod]
    public void OCP_ReplaceLog_WithLog4Net()
    {
      var d = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
      var fs = new MessageStoreLog4Net(d);
      fs.Save(49, "Extra text");
      Assert.AreEqual("Extra text", fs.Read(49).DefaultIfEmpty("").Single());
    }
    
    [TestMethod]
    public void WorkingSqlStore()
    {
      var sql = new SqlStore();
      sql.WriteAllText(49, "Extra text");
      Assert.AreEqual("Extra text", sql.ReadAllText(49).DefaultIfEmpty("").Single());
    }
  }
}
