using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WillowCreekNotes
{
    static class Program
    {
        public static NoteSystem System;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            System = new NoteSystem();
            System.Startup();
            Application.Run(new GlobalToolWindow());
        }
    }
}
