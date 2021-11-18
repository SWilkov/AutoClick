using AC.Utils.Interfaces;
using AutoClick.Interfaces;
using MouseSimulator.Interfaces;

namespace AutoClick.Commands
{
  public class StartAutoClickHandler : ICommandHandler<StartAutoClickCommand>
  {
    private readonly IMouseActionService _mouseActionService;
    private readonly ITimeService _timeService;

    public StartAutoClickHandler(IMouseActionService mouseActionService,
      ITimeService timeService)
    {
      _mouseActionService = mouseActionService;
      _timeService = timeService;
    }

    public void Handle(StartAutoClickCommand command)
    {
      if (command == null) throw new ArgumentNullException(nameof(command));
      if (command.ClickerConfiguration == null) throw new ArgumentNullException(nameof(command.ClickerConfiguration));    

      _timeService.Run(command.ClickTimeFrame, command.ClickerConfiguration);
    }
  }
}
