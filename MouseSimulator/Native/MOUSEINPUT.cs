using System;
using System.Collections.Generic;
using System.Text;

namespace MouseSimulator.Native
{
  internal struct MOUSEINPUT
  {
    public Int32 X;

    public Int32 Y;

    public UInt32 MouseData;
    
    public UInt32 Flags;

    public UInt32 Time;

    public IntPtr ExtraInfo;
  }
}
