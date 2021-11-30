using AutoClick.Interfaces;
using KeyboardSimulator.Native;

namespace AutoClick.Services
{
  public class HotKeyService : IHotKeyService
  {
    public bool RegisterHotKeyWrapper(IntPtr handle, int id, int modifiers, int virtualKey)
    {
      return Methods.RegisterHotKey(handle, id, modifiers, virtualKey);
    }

    public bool UnregisterHotKeyWrapper(IntPtr handle, int id)
    {
      return Methods.UnregisterHotKey(handle, id);
    }
  }
}
