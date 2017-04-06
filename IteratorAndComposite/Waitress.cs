using System;
using System.Collections;
using System.Text;
namespace IteratorAndComposite
{
  public class Waitress
  {
    MenuComponent allMenus;
    public Waitress(MenuComponent allMenus)
    {
      this.allMenus = allMenus;
    }
    public string PrintMenu()
    {
      return allMenus.Print();
    }

    public string PrintVegetarianMenu()
    {
      StringBuilder menuOutput = new StringBuilder();
      IEnumerator enumerator = allMenus.createEnumerator();
      menuOutput.Append("\nVEG\n");
      while (enumerator.MoveNext())
      {
        MenuComponent menuComponent = (MenuComponent)enumerator.Current;
        try
        {
          if (menuComponent.IsVegetarian())
            menuOutput.Append(menuComponent.Print());
        }
        catch (InvalidOperationException e) { }
      }
      return menuOutput.ToString();
    }
  }
}
