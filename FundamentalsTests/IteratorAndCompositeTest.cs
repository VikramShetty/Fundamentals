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
      //Using IEnumerator because of this http://www.c-sharpcorner.com/UploadFile/219d4d/ienumerable-vs-ienumerator-in-C-Sharp/
      //Removed because internals of the object should not be access directly
      //var panCakeHouseMenu = new PanCakeHouseMenu();
      //IEnumerator panCakeHouseIterator = panCakeHouseMenu.createIterator();
      //Assert.AreEqual(true, panCakeHouseIterator.Count() > 0);
    }

    [TestMethod]
    public void Four_Items_InMenu_Of_PanCakeHouseMenu()
    {
      //Using IEnumerator because of this http://www.c-sharpcorner.com/UploadFile/219d4d/ienumerable-vs-ienumerator-in-C-Sharp/
      //Removed because internals of the object should not be access directly
      //var panCakeHouseMenu = new PanCakeHouseMenu();
      //IEnumerator panCakeHouseIterator = panCakeHouseMenu.createIterator();
      //Assert.AreEqual(4, panCakeHouseIterator.Count());
    }

    [TestMethod]
    public void KNB_Pancake_IsFirstMenu_In_PanCakeHouseMenu()
    {
      //Removed because internals of the object should not be access directly
      //var panCakeHouseMenu = new PanCakeHouseMenu();
      //Assert.AreEqual(CONST.P_1_NAME, panCakeHouseMenu.getMenuItems()[0].GetName());
    }

    [TestMethod]
    public void T_2_99_IsCost_Of_FirstMenu_In_PanCakeHouseMenu()
    {
      //Removed because internals of the object should not be access directly
      //var panCakeHouseMenu = new PanCakeHouseMenu();
      //Assert.AreEqual(CONST.P_1_PRICE, panCakeHouseMenu.getMenuItems()[0].GetPrice());
    }

    [TestMethod]
    public void FirstMenu_Is_Veg_In_PanCakeHouseMenu()
    {
      //Removed because internals of the object should not be access directly
      //var panCakeHouseMenu = new PanCakeHouseMenu();
      //Assert.AreEqual(CONST.P_1_VEG, panCakeHouseMenu.getMenuItems()[0].IsVegetarian());
    }

    [TestMethod]
    public void Pancake_IsSecondMenu_In_PanCakeHouseMenu()
    {
      //Removed because internals of the object should not be access directly
      //var panCakeHouseMenu = new PanCakeHouseMenu();
      //Assert.AreEqual(CONST.P_2_NAME, panCakeHouseMenu.getMenuItems()[1].GetName());
    }

    [TestMethod]
    public void BlueberryPancake_IsSecondMenu_In_PanCakeHouseMenu()
    {
      //Removed because internals of the object should not be access directly
      //var panCakeHouseMenu = new PanCakeHouseMenu();
      //Assert.AreEqual(CONST.P_3_NAME, panCakeHouseMenu.getMenuItems()[2].GetName());
    }

    [TestMethod]
    public void WafflesPancake_IsSecondMenu_In_PanCakeHouseMenu()
    {
      //Removed because internals of the object should not be access directly
      //var panCakeHouseMenu = new PanCakeHouseMenu();
      //Assert.AreEqual(CONST.P_4_NAME, panCakeHouseMenu.getMenuItems()[3].GetName());
    }   

    #endregion
    #region "DinnerMenu"
    [TestMethod]
    public void MoreThanZero_Item_InMenu_Of_DinnerMenu()
    {
      //Using IEnumerator because of this http://www.c-sharpcorner.com/UploadFile/219d4d/ienumerable-vs-ienumerator-in-C-Sharp/
      //Removed because internals of the object should not be access directly
      //var dinnerMenu = new DinnerMenu();
      //Iterator dinnerIterator = dinnerMenu.createIterator();
      //Assert.AreEqual(true, dinnerIterator.Count() > 0);
    }

    [TestMethod]
    public void Six_Items_InMenu_Of_DinnerMenu()
    {
      //Using IEnumerator because of this http://www.c-sharpcorner.com/UploadFile/219d4d/ienumerable-vs-ienumerator-in-C-Sharp/
      //Removed because internals of the object should not be access directly
      //var dinnerMenu = new DinnerMenu();
      //Iterator dinnerIterator = dinnerMenu.createIterator();
      //Assert.AreEqual(6, dinnerIterator.Count());
    }

    [TestMethod]
    public void VegBLT_IsFirstMenu_In_DinnerMenu()
    {
      //Removed because internals of the object should not be access directly
      //var dinnerMenu = new DinnerMenu();
      //Assert.AreEqual(CONST.D_1_NAME, dinnerMenu.getMenuItems()[0].GetName());
    }

    [TestMethod]
    public void HotDog_IsLastMenu_In_DinnerMenu()
    {
      //Removed because internals of the object should not be access directly
      //var dinnerMenu = new DinnerMenu();
      //Assert.AreEqual(CONST.D_4_NAME, dinnerMenu.getMenuItems()[3].GetName());
    }

    [TestMethod]
    public void Soup_IsThirdMenu_In_DinnerMenu()
    {
      //Removed because internals of the object should not be access directly
      //var dinnerMenu = new DinnerMenu();
      //Assert.AreEqual(CONST.D_3_NAME, dinnerMenu.getMenuItems()[2].GetName());
    }

    [TestMethod]
    public void BLT_IsSecondMenu_In_DinnerMenu()
    {
      //Removed because internals of the object should not be access directly
      //var dinnerMenu = new DinnerMenu();
      //Assert.AreEqual(CONST.D_2_NAME, dinnerMenu.getMenuItems()[1].GetName());
    }
    #endregion
    #region "Waitress"
    [TestMethod]
    public void PrintMenu_By_Waitress()
    {
      List<Menu> menus = new List<Menu>();
      menus.Add(new PanCakeHouseMenu());
      menus.Add(new DinnerMenu());
      menus.Add(new CafeMenu());
      var waitress = new Waitress(menus);
      Assert.AreEqual(
        // "MENU\n----\nBREAKFAST\n" +
        CONST.P_1_NAME + ", " + CONST.P_1_PRICE + " -- \n" + CONST.P_1_DESC + "\n" +
        CONST.P_2_NAME + ", " + CONST.P_2_PRICE + " -- \n" + CONST.P_2_DESC + "\n" +
        CONST.P_3_NAME + ", " + CONST.P_3_PRICE + " -- \n" + CONST.P_3_DESC + "\n" +
        CONST.P_4_NAME + ", " + CONST.P_4_PRICE + " -- \n" + CONST.P_4_DESC + "\n" +
        // "\nLUNCH\n" + 
        CONST.D_1_NAME + ", " + CONST.D_1_PRICE + " -- \n" + CONST.D_1_DESC + "\n" +
        CONST.D_2_NAME + ", " + CONST.D_2_PRICE + " -- \n" + CONST.D_2_DESC + "\n" +
        CONST.D_3_NAME + ", " + CONST.D_3_PRICE + " -- \n" + CONST.D_3_DESC + "\n" +
        CONST.D_4_NAME + ", " + CONST.D_4_PRICE + " -- \n" + CONST.D_4_DESC + "\n" +
        // "\nDINNER\n" +
        CONST.C_1_NAME + ", " + CONST.C_1_PRICE + " -- \n" + CONST.C_1_DESC + "\n" +
        CONST.C_2_NAME + ", " + CONST.C_2_PRICE + " -- \n" + CONST.C_2_DESC + "\n" +
        CONST.C_3_NAME + ", " + CONST.C_3_PRICE + " -- \n" + CONST.C_3_DESC + "\n" 
        , waitress.PrintMenu());
    }    
    #endregion

    private MenuItem FactorySingleMenuCreator()
    {
      return new MenuItem(CONST.D_2_NAME, CONST.D_2_DESC, CONST.D_2_VEG, CONST.D_2_PRICE);
    }
  }
}
