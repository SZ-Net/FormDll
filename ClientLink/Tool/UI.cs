using System.Windows.Forms;

namespace DLLClientLink
{
    class UI
    {
        public static void Show(string msg)
        {
            MessageBox.Show(msg, "ClientLink", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowWarning(string msg)
        {
            MessageBox.Show(msg, "ClientLink", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void ShowError(string msg)
        {
            MessageBox.Show(msg, "ClientLink", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowYesNo(string msg)
        {
            return MessageBox.Show(msg, "ClientLink", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }


}
