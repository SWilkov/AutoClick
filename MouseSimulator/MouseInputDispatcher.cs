using MouseSimulator.Interfaces;
using MouseSimulator.Native;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MouseSimulator
{
  internal class MouseInputDispatcher : IInputDispatcher
  {
    public void DispatchInput(INPUT[] inputs)
    {
      if (inputs == null) throw new ArgumentNullException("inputs");
      if (inputs.Length == 0) throw new ArgumentException("The input array was empty", "inputs");
      var successful = Native.Methods.SendInput((UInt32)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));
      if (successful != inputs.Length)
        throw new Exception("Some simulated input commands were not sent successfully. The most common reason for this happening are the security features of Windows including User Interface Privacy Isolation (UIPI). Your application can only send commands to applications of the same or lower elevation. Similarly certain commands are restricted to Accessibility/UIAutomation applications. Refer to the project home page and the code samples for more information.");
    }
  }
}
