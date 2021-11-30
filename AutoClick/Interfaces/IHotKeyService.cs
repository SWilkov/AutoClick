
namespace AutoClick.Interfaces
{
  public interface IHotKeyService
  {
    bool RegisterHotKeyWrapper(IntPtr handle, int id, int modifiers, int virtualKey);
    bool UnregisterHotKeyWrapper(IntPtr handle, int id);
  }
}