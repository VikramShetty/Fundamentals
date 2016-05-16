using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
  public class Car
  {
    private int year;
    private Engine engine;
    public Car(int theYear, Engine anEngine)
    {
      year = theYear;
      engine = anEngine;
    }

    public Car(Car otherCar)
    {
      year = otherCar.year;
      if (typeof(TurboEngine) == otherCar.engine.GetType())
        engine = new TurboEngine((TurboEngine)otherCar.engine);
      else if (typeof(PistonEngine) == otherCar.engine.GetType())
        engine = new PistonEngine((PistonEngine)otherCar.engine);
      else
        engine = new Engine(otherCar.engine);
    }

    public override string ToString()
    {
      return "Car: " + year + " class " + engine.ToString();
    }
  }
}
