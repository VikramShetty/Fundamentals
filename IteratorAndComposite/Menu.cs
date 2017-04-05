using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorAndComposite
{
  public class Menu : MenuComponent
  {
    List<MenuComponent> menuComponents = new List<MenuComponent>();
    string Name;
    string Description;

    public Menu(string Name, string Description)
    {
      this.Name = Name;
      this.Description = Description;
    }

    public override void add(MenuComponent menuComponent)
    {
      menuComponents.Add(menuComponent);
    }

    public void remove(MenuComponent menuComponent)
    {
       menuComponents.Remove(menuComponent);
    }

    public MenuComponent getChild(int i)
    {
      return (MenuComponent)menuComponents[i];
    }

    public string GetName()
    {
      return this.Name;
    }

    public string GetDescription()
    {
      return this.Description;
    }

    public override string Print()
    {
      StringBuilder output = new StringBuilder();
      output.Append("\n" + GetName());
      output.Append("\n, " + GetDescription());
      output.Append("\n" + CONST.LINE_SEPARATOR);
      IEnumerator enumerator = menuComponents.GetEnumerator();
      while (enumerator.MoveNext())
      {
        MenuComponent menuComponent = (MenuComponent)enumerator.Current;
        output.Append(menuComponent.Print());
      }
      return output.ToString();
    }
  }
}
