using AC.Framework.Models;
using AC.Utils.Interfaces;
using AC.Utils.Models;

namespace AutoClick.Validators
{
  public class RepeaterValidator : IValidator<Repeater>
  {
    public ValidationInformation Validate(Repeater item)
    {
      if (item == null) throw new ArgumentNullException(nameof(item));

      var info = new ValidationInformation(ValidationResult.Valid);

      if (item.Repeats && item.RepeatsFor <= 0)
      {
        info.Result = ValidationResult.Invalid;
        info.Message = "RepeatsFor must be higher than zero";
      }

      return info;
    }
  }
}
