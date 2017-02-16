
namespace SOLID
{
  public interface ILogger
  {
    void Information(string message, int id);

    void Debug(string message, int id);
  }
}
