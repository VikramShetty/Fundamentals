using System;

namespace CoffeeMaker
{
  public class ReliefValue : IObserver<WarmerPlateStatus>
  {
    private readonly ICoffeeMaker hardware;

    public ReliefValue(ICoffeeMaker hardware)
    {
      if (hardware == null)
        throw new ArgumentNullException("hardware");

      this.hardware = hardware;
    }
    public void OnNext(WarmerPlateStatus value)
    {
      if (value == WarmerPlateStatus.POT_NOT_EMPTY)
        this.hardware.SetReliefValveState(ReliefValveState.OPEN);
      else
        this.hardware.SetReliefValveState(ReliefValveState.CLOSED);
    }

    public void OnError(Exception error)
    {
    }

    public void OnCompleted()
    {
    }
  }
}
