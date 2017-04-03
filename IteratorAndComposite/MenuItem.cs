namespace IteratorAndComposite
{
    public class MenuItem
    {
      private string Name;
      private string Description;
      private bool Vegetarian;
      private double Price;

      public MenuItem(string Name, string Description, bool Vegetarian, double price)
      {
        this.Name = Name;
        this.Description = Description;
        this.Vegetarian = Vegetarian;
        this.Price = price;
      }

      public string GetName()
      {
        return this.Name;
      }

      public string GetDescription()
      {
        return this.Description;
      }

      public double GetPrice()
      {
        return this.Price;
      }

      public bool IsVegetarian()
      {
        return this.Vegetarian;
      }
    }
}
