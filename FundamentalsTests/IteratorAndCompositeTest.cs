using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IteratorAndComposite;
using System.Collections;
using System.Collections.Generic;

namespace FundamentalsTests
{
  [TestClass]
  public class IteratorAndCompositeTest
  {
    #region "Menu Items"
    [TestMethod]
    public void GetName_Returns_BLT_MenuItem()
    {
      var menuItem = FactorySingleMenuItemCreator();
      Assert.AreEqual(CONST.D_2_NAME, menuItem.GetName());
    }

    [TestMethod]
    public void GetDescription_Return_FullText_MenuItem()
    {
      var menuItem = FactorySingleMenuItemCreator();
      Assert.AreEqual(CONST.D_2_DESC,
        menuItem.GetDescription());
    }

    [TestMethod]
    public void GetPrice_Returns_2_99_MenuItem()
    {
      var menuItem = FactorySingleMenuItemCreator();
      Assert.AreEqual(CONST.D_2_PRICE, menuItem.GetPrice());
    }

    [TestMethod]
    public void IsVegetarian_Returns_False_MenuItem()
    {
      var menuItem = FactorySingleMenuItemCreator();
      Assert.AreEqual(CONST.D_2_VEG, menuItem.IsVegetarian());
    }

    [TestMethod]
    public void print_MenuItem()
    {
      var menuItem = FactorySingleMenuItemCreator();
      Assert.AreEqual("\n " + CONST.D_2_NAME + ", " + CONST.D_2_PRICE + "\n    -- " + CONST.D_2_DESC, menuItem.Print());
    }
    #endregion
    #region "Menu"
    [TestMethod]
    public void GetName_Returns_BLT_Menu()
    {
      var menu = FactorySingleMenuCreator();
      Assert.AreEqual(CONST.M_1_NAME, menu.GetName());
    }

    [TestMethod]
    public void GetDescription_Return_FullText_Menu()
    {
      var menu = FactorySingleMenuCreator();
      Assert.AreEqual(CONST.M_1_DESC, menu.GetDescription());
    }

    [TestMethod]
    public void print_Menu()
    {
      var menu = FactorySingleMenuCreator();
      Assert.AreEqual("\n" + CONST.M_1_NAME + "\n, " + CONST.M_1_DESC +
        "\n" + CONST.LINE_SEPARATOR, menu.Print());
    }

    [TestMethod]
    public void print_PanCake_Menu()
    {
      MenuComponent pancakeHouseMenu = new Menu(CONST.M_1_NAME, CONST.M_1_DESC);
      MenuComponent allMenus = new Menu(CONST.M_0_NAME, CONST.M_0_DESC);
      allMenus.add(pancakeHouseMenu);

      pancakeHouseMenu.add(new MenuItem(CONST.P_1_NAME, CONST.P_1_DESC, CONST.P_1_VEG, CONST.P_1_PRICE));
      pancakeHouseMenu.add(new MenuItem(CONST.P_2_NAME, CONST.P_2_DESC, CONST.P_2_VEG, CONST.P_2_PRICE));
      pancakeHouseMenu.add(new MenuItem(CONST.P_3_NAME, CONST.P_3_DESC, CONST.P_3_VEG, CONST.P_3_PRICE));
      pancakeHouseMenu.add(new MenuItem(CONST.P_4_NAME, CONST.P_4_DESC, CONST.P_4_VEG, CONST.P_4_PRICE));

      Assert.AreEqual("\n" + CONST.M_0_NAME + "\n, " + CONST.M_0_DESC +
        "\n" + CONST.LINE_SEPARATOR +
        "\n" + CONST.M_1_NAME + "\n, " + CONST.M_1_DESC +
        "\n" + CONST.LINE_SEPARATOR + "\n " +
        CONST.P_1_NAME + CONST.IsVeg + ", " + CONST.P_1_PRICE + "\n    -- " + CONST.P_1_DESC + "\n " +
        CONST.P_2_NAME + CONST.NtVeg + ", " + CONST.P_2_PRICE + "\n    -- " + CONST.P_2_DESC + "\n " +
        CONST.P_3_NAME + CONST.IsVeg + ", " + CONST.P_3_PRICE + "\n    -- " + CONST.P_3_DESC + "\n " +
        CONST.P_4_NAME + CONST.IsVeg + ", " + CONST.P_4_PRICE + "\n    -- " + CONST.P_4_DESC,
        allMenus.Print());
    }
    #endregion
    #region "PanCakeHouseMenu"
    //Using IEnumerator because of this http://www.c-sharpcorner.com/UploadFile/219d4d/ienumerable-vs-ienumerator-in-C-Sharp/
    //Removed because internals of the object should not be access directly
    //Removed all tests under this
    #endregion
    #region "DinnerMenu"
    //Using IEnumerator because of this http://www.c-sharpcorner.com/UploadFile/219d4d/ienumerable-vs-ienumerator-in-C-Sharp/
    //Removed because internals of the object should not be access directly
    //Removed all tests under this
    #endregion
    #region "Waitress"
    [TestMethod]
    public void PrintMenu_By_Waitress()
    {
      MenuComponent pancakeHouseMenu = new Menu(CONST.M_1_NAME, CONST.M_1_DESC);
      MenuComponent dinerMenu = new Menu(CONST.M_2_NAME, CONST.M_2_DESC);
      MenuComponent cafeMenu = new Menu(CONST.M_3_NAME, CONST.M_3_DESC);
      MenuComponent allMenus = new Menu(CONST.M_0_NAME, CONST.M_0_DESC);
      allMenus.add(pancakeHouseMenu);
      allMenus.add(dinerMenu);
      allMenus.add(cafeMenu);

      pancakeHouseMenu.add(new MenuItem(CONST.P_1_NAME, CONST.P_1_DESC, CONST.P_1_VEG, CONST.P_1_PRICE));
      pancakeHouseMenu.add(new MenuItem(CONST.P_2_NAME, CONST.P_2_DESC, CONST.P_2_VEG, CONST.P_2_PRICE));
      pancakeHouseMenu.add(new MenuItem(CONST.P_3_NAME, CONST.P_3_DESC, CONST.P_3_VEG, CONST.P_3_PRICE));
      pancakeHouseMenu.add(new MenuItem(CONST.P_4_NAME, CONST.P_4_DESC, CONST.P_4_VEG, CONST.P_4_PRICE));

      dinerMenu.add(new MenuItem(CONST.D_1_NAME, CONST.D_1_DESC, CONST.D_1_VEG, CONST.D_1_PRICE));
      dinerMenu.add(new MenuItem(CONST.D_2_NAME, CONST.D_2_DESC, CONST.D_2_VEG, CONST.D_2_PRICE));
      dinerMenu.add(new MenuItem(CONST.D_3_NAME, CONST.D_3_DESC, CONST.D_3_VEG, CONST.D_3_PRICE));
      dinerMenu.add(new MenuItem(CONST.D_4_NAME, CONST.D_4_DESC, CONST.D_4_VEG, CONST.D_4_PRICE));

      cafeMenu.add(new MenuItem(CONST.C_1_NAME, CONST.C_1_DESC, CONST.C_1_VEG, CONST.C_1_PRICE));
      cafeMenu.add(new MenuItem(CONST.C_2_NAME, CONST.C_2_DESC, CONST.C_2_VEG, CONST.C_2_PRICE));
      cafeMenu.add(new MenuItem(CONST.C_3_NAME, CONST.C_3_DESC, CONST.C_3_VEG, CONST.C_3_PRICE));
      
      var waitress = new Waitress(allMenus);
      Assert.AreEqual("\n" + CONST.M_0_NAME + "\n, " + CONST.M_0_DESC +
        "\n" + CONST.LINE_SEPARATOR +
        "\n" + CONST.M_1_NAME + "\n, " + CONST.M_1_DESC +
        "\n" + CONST.LINE_SEPARATOR + "\n " +
        CONST.P_1_NAME + CONST.IsVeg + ", " + CONST.P_1_PRICE + "\n    -- " + CONST.P_1_DESC + "\n " +
        CONST.P_2_NAME + CONST.NtVeg + ", " + CONST.P_2_PRICE + "\n    -- " + CONST.P_2_DESC + "\n " +
        CONST.P_3_NAME + CONST.IsVeg + ", " + CONST.P_3_PRICE + "\n    -- " + CONST.P_3_DESC + "\n " +
        CONST.P_4_NAME + CONST.IsVeg + ", " + CONST.P_4_PRICE + "\n    -- " + CONST.P_4_DESC +
        "\n" + CONST.M_2_NAME + "\n, " + CONST.M_2_DESC +
        "\n" + CONST.LINE_SEPARATOR + "\n " +
        CONST.D_1_NAME + CONST.IsVeg + ", " + CONST.D_1_PRICE + "\n    -- " + CONST.D_1_DESC + "\n " +
        CONST.D_2_NAME + CONST.NtVeg + ", " + CONST.D_2_PRICE + "\n    -- " + CONST.D_2_DESC + "\n " +
        CONST.D_3_NAME + CONST.NtVeg + ", " + CONST.D_3_PRICE + "\n    -- " + CONST.D_3_DESC + "\n " +
        CONST.D_4_NAME + CONST.NtVeg + ", " + CONST.D_4_PRICE + "\n    -- " + CONST.D_4_DESC + 
        "\n" + CONST.M_3_NAME + "\n, " + CONST.M_3_DESC +
        "\n" + CONST.LINE_SEPARATOR + "\n " +
        CONST.C_1_NAME + CONST.IsVeg + ", " + CONST.C_1_PRICE + "\n    -- " + CONST.C_1_DESC + "\n " +
        CONST.C_2_NAME + CONST.NtVeg + ", " + CONST.C_2_PRICE + "\n    -- " + CONST.C_2_DESC + "\n " +
        CONST.C_3_NAME + CONST.IsVeg + ", " + CONST.C_3_PRICE + "\n    -- " + CONST.C_3_DESC 
        , waitress.PrintMenu());
    }
    #endregion

    private MenuItem FactorySingleMenuItemCreator()
    {
      return new MenuItem(CONST.D_2_NAME, CONST.D_2_DESC, CONST.D_2_VEG, CONST.D_2_PRICE);
    }

    private Menu FactorySingleMenuCreator()
    {
      return new Menu(CONST.M_1_NAME, CONST.M_1_DESC);
    }
  }
}
