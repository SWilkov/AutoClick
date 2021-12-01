using AC.Framework.Models;
using AutoClick.Factories;
using AutoClick.Interfaces;
using AutoClick.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AutoClickTests.Factories
{
  public class TimerFrameFactoryTests
  {
    private ITimeFrameFactory _factory;
    public TimerFrameFactoryTests()
    {
      _factory = new TimeFrameFactory();
    }

    [Fact]
    public void setup_null_throw_exception()
    {
      Assert.Throws<ArgumentNullException>(() => _factory.Get(null));
    }

    [Fact]
    public void setup_repeats_return_repeater()
    {
      var setup = new Repeater
      {
        Repeats = true,
        RepeatsFor = 20
      };

      Assert.Equal(ClickTimeFrame.Repeat, _factory.Get(setup));
    }

    [Fact]
    public void setup_continuous_return_continuous()
    {
      var setup = new Repeater
      {
        Repeats = false,
        RepeatsFor = 20
      };

      Assert.Equal(ClickTimeFrame.Continuous, _factory.Get(setup));
    }
  }
}
