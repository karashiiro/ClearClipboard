using System;
using System.Windows.Forms;

namespace ClearClipboard
{
    public static class ClearClipboard
    {
        [STAThread]
        public static void Main()
        {
            Clipboard.Clear();
        }
    }
}