using MouseSimulator.Interfaces;
using MouseSimulator.Models;
using MouseSimulator.Native;
using System;
using System.Collections.Generic;
using System.Text;

namespace MouseSimulator.Mappers
{
  internal class MouseButtonUpMapper : IMouseButtonFactory
  {
    public MouseFlag Get(MouseAction action, MouseButton button)
    {
      if (action != MouseAction.Up) throw new ArgumentException($"Invalid arg: {action.ToString()}");
      switch (button)
      {
        case MouseButton.Left:
          return MouseFlag.LeftUp;
        case MouseButton.Right:
          return MouseFlag.RightUp;
        case MouseButton.Middle:
          return MouseFlag.MiddleUp;
        default: return MouseFlag.LeftUp;
      }
    }
  }
}
