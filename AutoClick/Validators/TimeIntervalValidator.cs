using AC.Framework.Models;
using AC.Utils.Interfaces;
using AC.Utils.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClick.Validators
{
  public class TimeIntervalValidator : IValidator<Time>
  {
    public ValidationInformation Validate(Time item)
    {
      if (item == null) throw new ArgumentNullException(nameof(item));

      var info = new ValidationInformation(ValidationResult.Valid);

      if ((item.Hours > 0 || item.Minutes > 0 || item.Seconds > 0) && item.Milliseconds > 0)
      {
        info.Result = ValidationResult.Invalid;
        info.Message = "Error please set either hours,minutes,seconds or Milliseconds. ";
      }

      if (item.Hours < 0 || item.Minutes < 0 || item.Seconds < 0)
      {
        info.Result = ValidationResult.Invalid;
        info.Message += "Invalid mouse click interval.";
      }

      if (item.Hours == 0 && item.Minutes == 0 && item.Seconds == 0 && item.Milliseconds == 0)
      {
        info.Result = ValidationResult.Invalid;
        info.Message += "No click interval set. ";
      }

      return info;
    }
  }
}
