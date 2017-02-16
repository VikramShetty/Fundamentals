using System;
using System.Diagnostics.Eventing;
using System.Reactive.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoffeeMaker;

namespace FundamentalsTests
{
  [TestClass]
  public class CoffeeMakerTest
  {
    [TestMethod]
    public void One_Coffee_Cycle()
    {
      var hardware = new CoffeMakerInMemory();
      hardware.SetReliefValveState(ReliefValveState.CLOSED);
      hardware.WarmerPlateStatus = WarmerPlateStatus.POT_EMPTY;

      var buttonEvents = Observable
        .Interval(TimeSpan.FromSeconds(1))
        .Select(_ => hardware.GetBrewButtonStatus())
        .Publish();

      var boilerEvents = Observable
        .Interval(TimeSpan.FromSeconds(1))
        .Select(_ => hardware.GetBoilerStatus())
        .Publish();

      var warmerEvents = Observable
        .Interval(TimeSpan.FromSeconds(1))
        .Select(_ => hardware.GetWarmerPlateStatus())
        .Publish();

      var boiler = new Boiler(hardware);
      var indicator = new Indicator(hardware);
      var valve = new ReliefValue(hardware);
      var warmer = new WarmerPlate(hardware);

      using (buttonEvents.Subscribe(boiler))
      using (buttonEvents.Subscribe(indicator))
      using (boilerEvents.Subscribe(boiler))
      using (boilerEvents.Subscribe(indicator))
      using (warmerEvents.Subscribe(valve))
      using (warmerEvents.Subscribe(warmer))
      {
        buttonEvents.Connect();
        boilerEvents.Connect();
        warmerEvents.Connect();

        //while (!Exit(hardware))
        //writeHardwareState(hardware);

      }
    }
  }
}
