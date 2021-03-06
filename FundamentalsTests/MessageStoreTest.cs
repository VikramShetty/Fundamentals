﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
      //Older way to to replace better ways in SOLID_FileStore_With_Log4Net()
      /*
      var d = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
      var file = new FileStore(d);
      var fs = new MessageStoreLog4Net(file, file, file);
      fs.Save(49, "Extra text");
      Assert.AreEqual("Extra text", fs.Read(49).DefaultIfEmpty("").Single());*/
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

    [TestMethod]
    public void SOLID_SqlStore_With_NormalLog()
    {
      var logger = new LoggerConfiguration().CreateLogger();
      var sqlStore = new SqlStore();
      var cache = new StoreCache(sqlStore, sqlStore);
      var log = new StoreLogger(logger, cache, cache);
      var msgStore = new MessageStore(
        log,
        log,
        new FileLocator()
        );
      msgStore.Save(102, "All comes togther with SQL");
      Assert.AreEqual("All comes togther with SQL",
        msgStore.Read(102).DefaultIfEmpty("").Single());
    }

    [TestMethod]
    public void SOLID_FileStore_With_Log4Net()
    {
      var logger = new LoggerConfiguration().CreateLoggerLog4Net();
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

    [TestMethod]
    public void SOLID_SqlStore_With_Log4Net()
    {
      var logger = new LoggerConfiguration().CreateLoggerLog4Net();
      var sqlStore = new SqlStore();
      var cache = new StoreCache(sqlStore, sqlStore);
      var log = new StoreLogger(logger, cache, cache);
      var msgStore = new MessageStore(
        log,
        log,
        new FileLocator()
        );
      msgStore.Save(102, "All comes togther with SQL");
      Assert.AreEqual("All comes togther with SQL",
        msgStore.Read(102).DefaultIfEmpty("").Single());
    }
  }
}
