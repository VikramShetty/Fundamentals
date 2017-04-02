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
      Duck duck = new MallardDuck();
      Assert.AreEqual("All duck can swim!", duck.Swim());
    }

    [TestMethod]
    public void Interface_BehaviourThatChanges()
    {
      Duck duck = new MallardDuck();
      Assert.AreEqual("I am flying.", duck.PerformFly());
    }
  }
}
