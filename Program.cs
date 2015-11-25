using System;
using GLib;
using Gtk;
using log4net;
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

            try
            {
                ExceptionManager.UnhandledException += ExceptionManager_UnhandledException;
                Application.Init();

                Action run = () =>
                {
                    var win = new MainWindow();
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
                        if (win.Result)
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
            catch (Exception e)
            {
                LogManager.GetLogger(typeof(Program)).Fatal("Unhandled error", e);
            }
        }

        private static void ExceptionManager_UnhandledException(UnhandledExceptionArgs args)
        {
            LogManager.GetLogger(typeof (Program)).Fatal(string.Format("Unhandled error {0}", args.ExceptionObject), args.ExceptionObject as Exception);
        }
    }
}
