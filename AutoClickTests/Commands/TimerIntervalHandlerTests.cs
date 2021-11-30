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
      var cmd = new TimerIntervalCommand(new Time
        {
          Milliseconds = 3000
        });

      _handler.Handle(cmd);
      Assert.Equal(3000, cmd.Milliseconds);
    }

    [Fact]
    public void ten_minutes_returns_correct_milliseconds()
    {

      var interval = new Time
      {
        Milliseconds = 0,
        Hours = 0,
        Minutes = 1,
        Seconds = 0
      };
      var cmd = new TimerIntervalCommand(interval);
      _handler.Handle(cmd);

      Assert.Equal(60000, cmd.Milliseconds);
    }

    [Fact]
    public void one_hour_ten_minutes_thirty_seconds_returns_correct_milliseconds()
    {
      var interval = new Time
      {
        Milliseconds = 0,
        Hours = 0,
        Minutes = 10,
        Seconds = 30
      };
      var cmd = new TimerIntervalCommand(interval);
      _handler.Handle(cmd);

      Assert.Equal(630000, cmd.Milliseconds);
    }
  }
}
