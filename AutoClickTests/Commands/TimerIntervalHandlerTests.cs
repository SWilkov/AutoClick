using AC.Framework.Models;
using AC.Utils.Interfaces;
using AutoClick.Commands;
using System;
using Xunit;

namespace AutoClickTests.Commands
{
  public class TimerIntervalHandlerTests
  {
    private ICommandHandler<TimerIntervalCommand> _handler;
    public TimerIntervalHandlerTests()
    {
      _handler = new TimerIntervalHandler();
    }

    [Fact]
    public void command_null_throw_ex()
    {
      Assert.Throws<ArgumentNullException>(() => _handler.Handle(null));
    }

    [Fact]
    public void setup_null_throw_ex()
    {
      var cmd = new TimerIntervalCommand(null);
      Assert.Throws<ArgumentNullException>(() => _handler.Handle(cmd));
    }

    [Fact]
    public void setup_contains_milliseconds_set_interval()
    {
      var cmd = new TimerIntervalCommand(new Setup
      {
        Interval = new Time
        {
          Milliseconds = 3000
        },
        RepeatsFor = 100
      });

      _handler.Handle(cmd);
      Assert.Equal(3000, cmd.Interval);
    }

    [Fact]
    public void ten_minutes_returns_correct_milliseconds()
    {
      var setup = new Setup
      {
        Interval = new Time
        {
          Milliseconds = 0,
          Hours = 0,
          Minutes = 1,
          Seconds = 0
        },
        RepeatsFor = 100
      };
      var cmd = new TimerIntervalCommand(setup);
      _handler.Handle(cmd);

      Assert.Equal(60000, cmd.Interval);
    }

    [Fact]
    public void one_hour_ten_minutes_thirty_seconds_returns_correct_milliseconds()
    {
      var setup = new Setup
      {
        Interval = new Time
        {
          Milliseconds = 0,
          Hours = 0, 
          Minutes = 10,
          Seconds = 30
        },
        RepeatsFor = 100
      };
      var cmd = new TimerIntervalCommand(setup);
      _handler.Handle(cmd);

      Assert.Equal(630000, cmd.Interval);
    }
  }
}
