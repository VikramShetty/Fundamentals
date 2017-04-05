using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndComposite
{
  public class CafeMenu
  {
    Hashtable menuItems = new Hashtable();
    public CafeMenu()
    {
      addItem("Veggie Burger and Air Fries", 
        "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",true, 3.99);
      addItem("Soup of the day",
        "A cup of the soup of the day, with a side salad", false, 3.69);
      addItem("Burrito",
        "A large burrito, with whole pinto beans, salsa, guacamole", true, 4.29);
    }

    public void addItem(string Name, string Description, bool Vegetarian, double price)
    {
      MenuItem menuItem = new MenuItem(Name, Description, Vegetarian, price);
      menuItems.Add(menuItem.GetName(), menuItem);
    }

    public Hashtable getItems()
    {
      return menuItems;
    }
  }
}
