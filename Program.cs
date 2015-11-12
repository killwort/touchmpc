using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net.Config;
using LyricsCore.Configuration;
using Ninject;
using Ninject.Syntax;

namespace TouchMPC
{
    static class Program
    {
        public static IKernel Kernel;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            XmlConfigurator.Configure();
            Kernel=new StandardKernel(new LyricsModule(),new TouchMPCModule());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
