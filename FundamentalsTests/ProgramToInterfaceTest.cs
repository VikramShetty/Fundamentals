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
    public void FlyInterface_BehaviourThatChanges()
    {
      Duck duck = new MallardDuck();
      Assert.AreEqual("I am flying.", duck.PerformFly());
    }

    [TestMethod]
    public void QuackInterface_BehaviourThatChanges()
    {
      Duck duck = new MallardDuck();
      Assert.AreEqual("Quack Quack!", duck.PerformQuack());
    }

    [TestMethod]
    public void RubberDuck_DoNotFly()
    {
      //Actual use of creating the design
      Duck duck = new RubberDuck();
      Assert.AreEqual("I can't fly", duck.PerformFly());
    }

    [TestMethod]
    public void RubberDuck_SqueakDoNotQuack()
    {
      //Actual use of creating the design
      Duck duck = new RubberDuck();
      Assert.AreEqual("Squeak", duck.PerformQuack());
    }

    [TestMethod]
    public void DecoyDuck_DoNotFly()
    {
      //Actual use of creating the design
      Duck duck = new DecoyDuck();
      Assert.AreEqual("I can't fly", duck.PerformFly());
    }

    [TestMethod]
    public void DecoyDuck_DoesQuack()
    {
      //Actual use of creating the design
      Duck duck = new DecoyDuck();
      Assert.AreEqual("Quack Quack!", duck.PerformQuack());
    }

    [TestMethod]
    public void Display_MallardDuck()
    {
      Duck duck = new MallardDuck();
      Assert.AreEqual("I am a real Mallard Duck", duck.display());
    }

    [TestMethod]
    public void Display_RubberDuck()
    {
      Duck duck = new RubberDuck();
      Assert.AreEqual("I am a yellow Rubber Duck", duck.display());
    }

    [TestMethod]
    public void Display_DecoyDuck()
    {
      Duck duck = new DecoyDuck();
      Assert.AreEqual("I am a Decoy Duck", duck.display());
    }
    
  }
}
