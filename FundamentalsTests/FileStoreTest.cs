using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOLID;

namespace FundamentalsTests
{
  [TestClass]
  public class FileStoreTest
  {
    private string message = "";
    [TestMethod]
    public void WhenRead_With49_ReturnsEmptyString()
    {
      FileStore fs = new FileStore();
      fs.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
      fs.Save(49, "some");
      fs.MessageRead += new EventHandler<MessageEventArgs>(messageEvent);
      fs.Read(49);
      Assert.AreEqual("some", message);
    }

    void messageEvent(object sender, MessageEventArgs e)
    {
      this.message = e.Message;
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void WhenRead_With49_NoWorkingDirectory_ReturnsEmptyString()
    {
      FileStore fs = new FileStore();
      fs.Save(49, "");
      fs.Read(49);
      Assert.AreEqual("", "");
    }
  }
}
