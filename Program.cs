using System;
using System.Windows.Forms;
using log4net.Config;
using LyricsCore.Configuration;
using Ninject;

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
            try
            {
                MpdClient.GetSharedClient().Status();
            }
            catch (Exception e)
            {
                var wnd = new SettingsWindow {LatestException = e};
                Application.Run(wnd);
                if (wnd.DialogResult != DialogResult.OK) return;
            }
            Application.Run(new MainWindow());
        }
    }
}
