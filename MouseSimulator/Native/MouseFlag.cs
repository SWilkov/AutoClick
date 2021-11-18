namespace MouseSimulator.Native
{
  internal enum MouseFlag : uint
  {
    LeftDown = 0x0002,
    LeftUp = 0x0004,
    RightDown = 0x0008,
    RightUp = 0x0010,
    Absolute = 0x8000,
    MiddleDown = 0x0020,
    MiddleUp = 0x0040
  }
}
