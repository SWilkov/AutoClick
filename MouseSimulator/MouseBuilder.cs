using MouseSimulator.Interfaces;
using MouseSimulator.Models;
using MouseSimulator.Native;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MouseSimulator
{
  internal class MouseBuilder : IEnumerable<INPUT>
  {
    private readonly List<INPUT> _inputList;
    private readonly IMouseButtonFactory _mouseButtonFactory;

    public MouseBuilder()
    {
      _inputList = new List<INPUT>();
      var dict = new Dictionary<MouseAction, IMouseButtonFactory>
      {
        {
          MouseAction.Down,
          new Mappers.MouseButtonDownMapper()
        },
        {
          MouseAction.Up,
          new Mappers.MouseButtonUpMapper()
        }
      };
      _mouseButtonFactory = new Factories.MouseButtonFactory(dict);
    }

    public INPUT[] ToArray()
    {
      return _inputList.ToArray();
    }

    public IEnumerator<INPUT> GetEnumerator()
    {
      return _inputList.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }

    public INPUT this[int position]
    {
      get
      {
        return _inputList[position];
      }
    }

    public MouseBuilder AddMouseButtonDown(MouseButton button)
    {
      var buttonDown = new INPUT { Type = (UInt32)InputType.Mouse };
      buttonDown.Data.Flags = (UInt32)_mouseButtonFactory.Get(MouseAction.Down, button);

      _inputList.Add(buttonDown);

      return this;
    }

    public MouseBuilder AddMouseButtonUp(MouseButton button)
    {
      var buttonUp = new INPUT {  Type =(UInt32)InputType.Mouse };
      buttonUp.Data.Flags = (UInt32)_mouseButtonFactory.Get(MouseAction.Up, button);
      _inputList.Add(buttonUp);
      return this;
    }
  }
}
