﻿using System.Collections.Generic;

namespace IteratorAndComposite
{
  public class PanCakeHouseMenu
  {
    List<MenuItem> menuItems;
    public PanCakeHouseMenu()
    {
      menuItems = new List<MenuItem>();
      addItem(CONST.P_1_NAME, CONST.P_1_DESC, CONST.P_1_VEG, CONST.P_1_PRICE);
      addItem(CONST.P_2_NAME, CONST.P_2_DESC, CONST.P_2_VEG, CONST.P_2_PRICE);
      addItem(CONST.P_3_NAME, CONST.P_3_DESC, CONST.P_3_VEG, CONST.P_3_PRICE);
      addItem(CONST.P_4_NAME, CONST.P_4_DESC, CONST.P_4_VEG, CONST.P_4_PRICE);
    }

    public void addItem(string Name, string Description, bool Vegetarian, double price)
    {
      var menuItem = new MenuItem(Name, Description, Vegetarian, price);
      menuItems.Add(menuItem);
    }

    public Iterator createIterator()
    {
      return new PanCakeHouseIterator(menuItems);
    }

    // other menu methods here
  }
}
