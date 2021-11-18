using MouseSimulator.Interfaces;
using MouseSimulator.Models;
using MouseSimulator.Native;
using System;
using System.Collections.Generic;
using System.Text;

namespace MouseSimulator.Mappers
{
  internal class MouseButtonDownMapper : IMouseButtonFactory
  {
    public MouseFlag Get(MouseAction action, MouseButton button)
    {
      if (action != MouseAction.Down) throw new ArgumentException($"Invalid arg: {action.ToString()}");
      switch (button)
      {
        case MouseButton.Left:
          return MouseFlag.LeftDown;
        case MouseButton.Middle:
          return MouseFlag.MiddleDown;
        case MouseButton.Right:
          return MouseFlag.RightDown;
        default:
          return MouseFlag.LeftDown;
      }
    }
  }
}
