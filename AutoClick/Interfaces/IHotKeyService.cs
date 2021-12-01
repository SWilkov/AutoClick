
namespace AutoClick.Interfaces
{
  /// <summary>
  /// Wrapper class for the system methods (winuser.h)[https://docs.microsoft.com/en-us/windows/win32/api/winuser]
  /// </summary>
  public interface IHotKeyService
  {
    /// <summary>
    /// https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-registerhotkey
    /// </summary>
    /// <param name="handle">A handle to the window that will receive the hotkey messages</param>
    /// <param name="id">identifier of the hotkey to be freed</param>
    /// <param name="modifiers">keys pressed in combination with the hotkey ie ctrl, alt</param>
    /// <param name="virtualKey">Virtual key code of the hot key</param>
    /// <returns></returns>
    bool RegisterHotKeyWrapper(IntPtr handle, int id, int modifiers, int virtualKey);
    /// <summary>
    /// https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-unregisterhotkey
    /// </summary>
    /// <param name="handle">A handle to the window associated with the hotkey</param>
    /// <param name="id">identifier of the hotkey to be freed</param>
    /// <returns>success ior fail</returns>
    bool UnregisterHotKeyWrapper(IntPtr handle, int id);
  }
}