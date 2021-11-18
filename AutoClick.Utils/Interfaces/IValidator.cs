using AutoClick.Utils.Models;

namespace AutoClick.Utils.Interfaces
{
  public interface IValidator<T> where T : class
  {
    ValidationInformation Validate(T item);
  }
}
