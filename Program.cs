using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassMan
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var main = new FMain();
            main.FormClosing += (_, e) =>
            {
                if (main.ReallyQuit)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                    main.Hide();
                }
            };
            Application.Run(main);
        }
    }
}