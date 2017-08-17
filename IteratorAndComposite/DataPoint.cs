using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndComposite
{
  public class DataPoint : DataComponent
  {
    private string Name;
    private string Field;

    public DataPoint(string Name, string Field)
    {
      this.Name = Name;
      this.Field = Field; 
    }

    public override string GetName()
    {
      return this.Name;
    }

    public string GetField()
    {
      return this.Field;
    }

    public override string Print()
    {
      StringBuilder output = new StringBuilder();
      output.Append("\n--" + GetName());
      output.Append(", " + GetField());
      return output.ToString();
    }

    public override IEnumerator createEnumerator()
    {
      return new NullEnumerator();
    }

    public override DataComponent Compare(DataComponent filter, DataComponent leafNode)
    {
      return this;
    }

    public override bool AllChildAreLeafs()
    {
      return false;
    }

    public override bool HasChild()
    {
      return false;
    }    
  }
}
