using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perpustakaan
{
    internal static class Program
    {
        public static Home FrmUtama;
        public static Collection FrmCust;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmUtama = new Home();
            FrmCust = new Collection();

            FrmCust.MdiParent = FrmUtama;

            Application.Run(FrmUtama);
        }
    }
}
