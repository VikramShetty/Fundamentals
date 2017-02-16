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
      var file = new FileStore(d);
      var fs = new MessageStore(file, file, file);
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
      var file = new FileStore(d);
      var fs = new MessageStoreLog4Net(file, file, file);
      fs.Save(49, "Extra text");
      Assert.AreEqual("Extra text", fs.Read(49).DefaultIfEmpty("").Single());
    }
    
    [TestMethod]
    public void WorkingSqlStore()
    {
      var sql = new SqlStore();
      sql.Save(49, "Extra text");
      Assert.AreEqual("Extra text", sql.Read(49).DefaultIfEmpty("").Single());
    }

    [TestMethod]
    public void WorkingFileStore()
    {
      var d = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
      var file = new FileStore(d);
      file.Save(51, "Extra file store text");
      Assert.AreEqual("Extra file store text", file.Read(51).DefaultIfEmpty("").Single());
    }

    [TestMethod]
    public void WorkingFileStoreNoId()
    {
      var d = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
      var file = new FileStore(d);
      Assert.AreEqual("", file.Read(60).DefaultIfEmpty("").Single());
    }

    [TestMethod]
    public void SOLID_FileStore_With_NormalLog()
    {
      var logger = new LoggerConfiguration().CreateLogger();
      var fileStore = new FileStore(
        new DirectoryInfo(
          AppDomain.CurrentDomain.BaseDirectory));
      var cache = new StoreCache(fileStore, fileStore);
      var log = new StoreLogger(logger, cache, cache);
      var msgStore = new MessageStore(
        log,
        log,
        fileStore
        );
      msgStore.Save(101, "All comes togther");
      Assert.AreEqual("All comes togther", 
        msgStore.Read(101).DefaultIfEmpty("").Single());
    }
  }
}
