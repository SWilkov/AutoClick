using MouseSimulator.Models;
using MouseSimulator.Native;

namespace MouseSimulator.Interfaces
{
  internal interface IMouseButtonFactory
  {
    MouseFlag Get(MouseAction action, MouseButton button);
  }
}