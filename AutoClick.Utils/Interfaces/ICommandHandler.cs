namespace AutoClick.Utils.Interfaces
{
  public interface ICommandHandler<T> where T : class
  {
    void Handle(T command);
  }
}
