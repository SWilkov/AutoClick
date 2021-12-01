using AC.Framework.Models;
using AC.Utils.Interfaces;
using AC.Utils.Models;
using AutoClick.Validators;
using System;
using Xunit;

namespace AutoClickTests
{
  public class RepeaterValidatorTests
  {
    private IValidator<Repeater> _validator;
    public RepeaterValidatorTests()
    {
      _validator = new RepeaterValidator();
    }

    [Fact]
    public void repeater_null_throw_ex()
    {
      Assert.Throws<ArgumentNullException>(() => _validator.Validate(null));
    }

    [Fact]
    public void repeats_but_repeats_for_zero_fail()
    {
      var repeater = new Repeater
      {
        Repeats = true,
        RepeatsFor = 0
      };

      Assert.Equal(ValidationResult.Invalid, _validator.Validate(repeater).Result);
    }

    [Fact]
    public void repeats_and_repeats_for_over_zero_success()
    {
      var repeater = new Repeater
      {
        Repeats = true,
        RepeatsFor = 10
      };

      Assert.Equal(ValidationResult.Valid, _validator.Validate(repeater).Result);
    }
  }
}
