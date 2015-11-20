using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GLib;
using Gtk;
using log4net.Config;
using MusicData.Configuration;
using Ninject;
using Action = System.Action;

namespace TouchMPCGtk
{
    class Program
    {
        public static IKernel Kernel;
        public static MainWindow MainWindow;
        [STAThread]
        static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            Kernel = new StandardKernel(new LyricsModule(), new TouchMPCModule());

            Application.Init();

            Action run = () =>
            {
                var win=new MainWindow();
                MainWindow = win;
                win.Show();
                win.Destroyed += (s, ev) =>
                {
                    Application.Quit();
                };
            };

            Exception errorConnect = null;
            try
            {
                MpdClient.GetSharedClient().Status();
            }
            catch (Exception e)
            {
                errorConnect = e;
            }
            if (errorConnect != null)
            {
                var win = new SettingsWindow {LatestException = errorConnect};
                win.Show();
                win.Destroyed += (s, ev) =>
                {
                    if(win.Result)
                        run();
                    else
                        Application.Quit();
                };
            }
            else
            {
                run();
            }
            Application.Run();

        }
    }
}
