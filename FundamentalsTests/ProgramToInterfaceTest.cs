using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgramToInterface;

namespace FundamentalsTests
{
  [TestClass]
  public class ProgramToInterfaceTest
  {
    [TestMethod]
    public void ConcreteClass_BehaviourNotChanging()
    {
      Duck duck = new Duck();
      Assert.AreEqual("All duck can swim!", duck.Swim());
    }   
  }
}
