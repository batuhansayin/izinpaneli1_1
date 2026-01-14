using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace izinpaneli1_1
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Programın Form1 ile başlamasını sağlayan komut burası:
            Application.Run(new Form1());
        }
    }
}