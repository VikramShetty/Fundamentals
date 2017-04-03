using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndComposite
{
  public class PanCakeHouseMenu
  {
    List<MenuItem> menuItems;
    public PanCakeHouseMenu()
    {
      menuItems = new List<MenuItem>();
      addItem(CONST.P_1_NAME, CONST.P_1_DESC,
        CONST.P_1_VEG, CONST.P_1_PRICE);
    }

    public void addItem(string Name, string Description, bool Vegetarian, double price)
    {
      var menuItem = new MenuItem(Name, Description, Vegetarian, price);
      menuItems.Add(menuItem);
    }

    public List<MenuItem> getMenuItems()
    {
      return menuItems;
    }
  }
}
