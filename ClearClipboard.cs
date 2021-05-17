using System.Threading;
using System.Windows.Forms;

var t = new Thread(Clipboard.Clear);
t.SetApartmentState(ApartmentState.STA);
t.Start();
t.Join();
