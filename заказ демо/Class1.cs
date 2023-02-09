using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace заказ_демо
{


   
 class Class1
    {
        [STAThread]
        static void forms()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var thread = new Thread(ThreadStart);
            // allow UI with ApartmentState.STA though [STAThread] above should give that to you
            thread.TrySetApartmentState(ApartmentState.STA);
            thread.Start();

            Application.Run(new Main());
        }

        private static void ThreadStart()
        {
            Application.Run(new Main()); // <-- other form started on its own UI thread
        }
    }
}
