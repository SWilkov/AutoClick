using MouseSimulator.Interfaces;

namespace MouseSimulator
{
  public class MouseActionService : IMouseActionService
  {
    private readonly Interfaces.IInputDispatcher _inputDispatcher;
    public MouseActionService()
    {
      _inputDispatcher = new MouseInputDispatcher();
    }

    public void LeftMouseButtonDown()
    {
      var inputs = new MouseBuilder().AddMouseButtonDown(MouseButton.Left).ToArray();
      _inputDispatcher.DispatchInput(inputs);
    }

    public void LeftMouseButtonUp()
    {
      var inputs = new MouseBuilder().AddMouseButtonUp(MouseButton.Left).ToArray();
      _inputDispatcher.DispatchInput(inputs);
    }
  }
}
