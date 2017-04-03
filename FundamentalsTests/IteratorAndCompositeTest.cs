using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IteratorAndComposite;

namespace FundamentalsTests
{
  [TestClass]
  public class IteratorAndCompositeTest
  {
    [TestMethod]
    public void GetName_Returns_BLT_MenuItem()
    {
      var menuItem = FactorySingleMenuCreator();
      Assert.AreEqual("BLT", menuItem.GetName());
    }

    [TestMethod]
    public void GetDescription_Return_FullText_MenuItem()
    {
      var menuItem = FactorySingleMenuCreator();
      Assert.AreEqual("Bacon with Lettuce & tomato on whole wheat", 
        menuItem.GetDescription());
    }

    [TestMethod]
    public void GetPrice_Returns_2_99_MenuItem()
    {
      var menuItem = FactorySingleMenuCreator();
      Assert.AreEqual(2.99, menuItem.GetPrice());
    }

    [TestMethod]
    public void IsVegetarian_Returns_False_MenuItem()
    {
      var menuItem = FactorySingleMenuCreator();
      Assert.AreEqual(false, menuItem.IsVegetarian());
    }
    
    private MenuItem FactorySingleMenuCreator()
    {
      return new MenuItem("BLT", "Bacon with Lettuce & tomato on whole wheat", false, 2.99);
    }
  }
}
