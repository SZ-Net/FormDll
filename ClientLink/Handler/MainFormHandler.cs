using DLLClientLink.Mode;
using DLLClientLink.Resx;
using DLLClientLink.Tool;
using NHotkey;
using NHotkey.WindowsForms;
using System;
using System.Windows.Forms;

namespace DLLClientLink.Handler
{
    /// <summary>
    /// 当对一个类应用 sealed 修饰符时，此修饰符会阻止其他类从该类继承。
    /// </summary>
    public sealed class MainFormHandler
    {
        private static readonly Lazy<MainFormHandler> instance = new Lazy<MainFormHandler>(() => new MainFormHandler());
        public static MainFormHandler Instance => instance.Value;

        public void RegisterGlobalHotkey(Config config, EventHandler<HotkeyEventArgs> handler, Action<bool, string> update)
        {
            if (config.globalHotkeys == null)
            {
                return;
            }

            foreach (var item in config.globalHotkeys)
            {
                if (item.KeyCode == null)
                {
                    continue;
                }

                Keys keys = (Keys)item.KeyCode;
                if (item.Control)
                {
                    keys |= Keys.Control;
                }
                if (item.Alt)
                {
                    keys |= Keys.Alt;
                }
                if (item.Shift)
                {
                    keys |= Keys.Shift;
                }

                try
                {
                    HotkeyManager.Current.AddOrReplace(((int)item.GlobalHotkey).ToString(), keys, handler);
                    var msg = string.Format(ResUI.RegisterGlobalHotkeySuccessfully, $"{item.GlobalHotkey.ToString()} = {keys}");
                    update(false, msg);
                }
                catch (Exception ex)
                {
                    var msg = string.Format(ResUI.RegisterGlobalHotkeyFailed, $"{item.GlobalHotkey.ToString()} = {keys}", ex.Message);
                    update(false, msg);
                    Utils.SaveLog(msg);
                }
            }
        }

    }
}
