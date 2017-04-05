using System.Collections;
using System.Text;
namespace IteratorAndComposite
{
    public class MenuItem : MenuComponent
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

      public override string Print()
      {
        StringBuilder output = new StringBuilder();
        output.Append("\n " + GetName());
        if (IsVegetarian())
          output.Append("(v)");

        output.Append(", " + GetPrice());
        output.Append("\n    -- " + GetDescription());
        return output.ToString();
      }

      public override IEnumerator createEnumerator()
      {
        return new NullEnumerator();
      }
    }
}
