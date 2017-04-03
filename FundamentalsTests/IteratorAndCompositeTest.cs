using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IteratorAndComposite;

namespace FundamentalsTests
{
  [TestClass]
  public class IteratorAndCompositeTest
  {
    #region "Menu Items"
    [TestMethod]
    public void GetName_Returns_BLT_MenuItem()
    {
      var menuItem = FactorySingleMenuCreator();
      Assert.AreEqual(CONST.D_2_NAME, menuItem.GetName());
    }

    [TestMethod]
    public void GetDescription_Return_FullText_MenuItem()
    {
      var menuItem = FactorySingleMenuCreator();
      Assert.AreEqual(CONST.D_2_DESC,
        menuItem.GetDescription());
    }

    [TestMethod]
    public void GetPrice_Returns_2_99_MenuItem()
    {
      var menuItem = FactorySingleMenuCreator();
      Assert.AreEqual(CONST.D_2_PRICE, menuItem.GetPrice());
    }

    [TestMethod]
    public void IsVegetarian_Returns_False_MenuItem()
    {
      var menuItem = FactorySingleMenuCreator();
      Assert.AreEqual(CONST.D_2_VEG, menuItem.IsVegetarian());
    }
    #endregion
    #region "PanCakeHouseMenu"

    [TestMethod]
    public void MoreThanZero_Item_InMenu_Of_PanCakeHouseMenu()
    {
      var panCakeHouseMenu = new PanCakeHouseMenu();
      Assert.AreEqual(true, panCakeHouseMenu.getMenuItems().Count > 0);
    }

    [TestMethod]
    public void KNB_Pancake_IsFirstMenu_In_PanCakeHouseMenu()
    {
      var panCakeHouseMenu = new PanCakeHouseMenu();
      Assert.AreEqual(CONST.P_1_NAME, panCakeHouseMenu.getMenuItems()[0].GetName());
    }

    #endregion
    private MenuItem FactorySingleMenuCreator()
    {
      return new MenuItem(CONST.D_2_NAME, CONST.D_2_DESC, CONST.D_2_VEG, CONST.D_2_PRICE);
    }
  }
}
