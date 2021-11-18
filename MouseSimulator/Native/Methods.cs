using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MouseSimulator.Native
{
  internal static class Methods
  {
    [DllImport("user32.dll", SetLastError = true)]
    public static extern UInt32 SendInput(UInt32 numberOfInputs, INPUT[] inputs, Int32 sizeOfInputStructure);
  }
}
