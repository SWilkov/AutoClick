using MouseSimulator.Interfaces;
using MouseSimulator.Models;
using MouseSimulator.Native;
using System;
using System.Collections.Generic;
using System.Text;

namespace MouseSimulator.Factories
{
  internal class MouseButtonFactory : IMouseButtonFactory
  {
    private readonly Dictionary<MouseAction, IMouseButtonFactory> _factories;
    public MouseButtonFactory(Dictionary<MouseAction, IMouseButtonFactory> factories)
    {
      _factories = factories;
    }

    public MouseFlag Get(MouseAction action, MouseButton button) =>
      _factories.TryGetValue(action, out IMouseButtonFactory fact) 
        ? _factories[action].Get(action, button) 
        : throw new ArgumentException($"No factory found for action: {action.ToString()}");
  }

  
}
