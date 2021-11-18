using AC.Framework.Models;
using AC.Utils.Interfaces;
using AC.Utils.Models;

namespace AutoClick.Validators
{
  public class SetupValidator : IValidator<Setup>
  {
    private readonly IValidator<Time> _timeValidator;
    public SetupValidator(IValidator<Time> timeValidator)
    {
      _timeValidator = timeValidator;
    }

    public ValidationInformation Validate(Setup item)
    {
      if (item == null) throw new ArgumentNullException(nameof(item));
      var info = new ValidationInformation(ValidationResult.Valid);

      var intervalValdation = _timeValidator.Validate(item.Interval);
      if (intervalValdation.Result == ValidationResult.Invalid)
      {
        info.Result = ValidationResult.Invalid;
        info.Message = intervalValdation.Message;
      }

      if (item.RepeatsFor < 0)
      {
        info.Result = ValidationResult.Invalid;
        info.Message += $" Invalid RepeatFor cannot be a minus value";
      }

      return info;
    }
  }
}
