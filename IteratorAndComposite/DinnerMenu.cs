using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndComposite
{
  public class DinnerMenu
  {
    MenuItem[] menuItems;
    private const int MAX_ITEMS = 6;
    int numberOfItems = 0;
    public DinnerMenu()
    {
      menuItems = new MenuItem[MAX_ITEMS];
      addItem(CONST.D_1_NAME, CONST.D_1_DESC, CONST.D_1_VEG, CONST.D_1_PRICE);
      addItem(CONST.D_2_NAME, CONST.D_2_DESC, CONST.D_2_VEG, CONST.D_2_PRICE);
      addItem(CONST.D_3_NAME, CONST.D_3_DESC, CONST.D_3_VEG, CONST.D_3_PRICE);
      addItem(CONST.D_4_NAME, CONST.D_4_DESC, CONST.D_4_VEG, CONST.D_4_PRICE);
    }

    public void addItem(string Name, string Description, bool Vegetarian, double price)
    {
      var menuItem = new MenuItem(Name, Description, Vegetarian, price);
      if(numberOfItems >= MAX_ITEMS){
        throw new Exception("Sorry, menu is full! Can't add item to menu");
      }
      else{
        menuItems[numberOfItems] = menuItem;
        numberOfItems = numberOfItems + 1;
      }
    }

    public MenuItem[] getMenuItems()
    {
      return menuItems;
    }

    // other menu methods here
  }
}
