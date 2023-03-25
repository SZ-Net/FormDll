using System.Windows.Forms;

namespace ClientLink
{
    class MessageBoxUI
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

        public static DialogResult ShowYesNo(string msg,string tip)
        {
            return MessageBox.Show(msg, tip, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }


}
