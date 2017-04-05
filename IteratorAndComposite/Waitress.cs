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
  }
}
