using AC.Utils.Models;

namespace AC.Utils.Interfaces
{
  public interface IValidator<T> where T : class
  {
    ValidationInformation Validate(T item);
  }
}
