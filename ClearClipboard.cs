using System;
using System.Windows.Forms;

public static class ClearClipboard
{
    [STAThread]
    public static void Main()
    {
        Clipboard.Clear();
    }
}