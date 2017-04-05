using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndComposite
{
  public class CafeMenu : IMenu
  {
    Hashtable menuItems = new Hashtable();
    public CafeMenu()
    {
      addItem(CONST.C_1_NAME,CONST.C_1_DESC, CONST.C_1_VEG, CONST.C_1_PRICE);
      addItem(CONST.C_2_NAME, CONST.C_2_DESC, CONST.C_2_VEG, CONST.C_2_PRICE);
      addItem(CONST.C_3_NAME, CONST.C_3_DESC, CONST.C_3_VEG, CONST.C_3_PRICE);
    }

    public void addItem(string Name, string Description, bool Vegetarian, double price)
    {
      MenuItem menuItem = new MenuItem(Name, Description, Vegetarian, price);
      menuItems.Add(menuItem.GetName(), menuItem);
    }
    
    public IEnumerator createEnumerator()
    {
      return menuItems.Values.GetEnumerator();
    }
  }
}
