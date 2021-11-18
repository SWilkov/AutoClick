using MouseSimulator.Native;

namespace MouseSimulator.Interfaces
{
  internal interface IInputDispatcher
  {
    void DispatchInput(INPUT[] inputs);
  }
}
