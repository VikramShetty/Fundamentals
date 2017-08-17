using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndComposite
{
  public class DataNode : DataComponent
  {
    IEnumerator enumerator = null;
    List<DataComponent> dataComponents = new List<DataComponent>();
    string Name;
    public DataNode(string Name)
    {
      this.Name = Name;
    }

    public override void Add(DataComponent dataComponent)
    {
      dataComponents.Add(dataComponent);
    }

    public override void Remove(DataComponent dataComponent)
    {
      dataComponents.Remove(dataComponent);
    }

    public override DataComponent GetChild(int i)
    {
      return (DataComponent)dataComponents[i];
    }

    public override string GetName()
    {
      return this.Name;
    }

    public override string Print()
    {
      StringBuilder output = new StringBuilder();
      output.Append("\n" + GetName());
      IEnumerator enumerator = dataComponents.GetEnumerator();
      while (enumerator.MoveNext())
      {
        DataComponent dataComponent = (DataComponent)enumerator.Current;
        output.Append(dataComponent.Print());
      }
      return output.ToString();
    }

    public override DataComponent Compare(DataComponent filter, DataComponent leafNode)
    {
      IEnumerator enumeratorSource = dataComponents.GetEnumerator();
      while (enumeratorSource.MoveNext())
      {
        DataComponent dataComponent = (DataComponent)enumeratorSource.Current;

        if (Match(dataComponent, filter))
        {
          if (dataComponent.AllChildAreLeafs())
            leafNode.Add(dataComponent);

          dataComponent.Compare(Next(filter), leafNode);
        }
        else
          dataComponent.Compare(filter, leafNode);

      }
      return leafNode;
    }

    private bool Match(DataComponent dataComponent, DataComponent filter)
    {
      bool match = false;
      if (dataComponent.HasChild())
        if (dataComponent.GetName() == filter.GetChild(0).GetName())
          match = true;

      return match;
    }

    private DataComponent Next(DataComponent component)
    {
      DataComponent next = null;
      if (component.HasChild())
        next = component.GetChild(0);

      return next;
    }

    public override IEnumerator createEnumerator()
    {
      if (enumerator == null)
         enumerator = new CompositeDataEnumerator(dataComponents.GetEnumerator());
     
      return enumerator;
    }

    public override bool AllChildAreLeafs()
    {
      bool AllChildAreLeaf = true;

      foreach (var component in dataComponents)
      {
        if (component.GetType() == typeof(DataNode))
          AllChildAreLeaf = false;
      }
      return AllChildAreLeaf;
    }

    public override bool HasChild()
    {
      return dataComponents.Count > 0;
    }
  }
}
