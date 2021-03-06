﻿using System;
using System.Threading.Tasks;
using Gtk;

namespace TouchMPCGtk
{
    partial class SettingsWindow:Window
    {
        public SettingsWindow() : base(WindowType.Toplevel)
        {
            Build();
            ConnectButton.Clicked += OnConnectButtonClicked;
            CloseButton.Clicked += OnExitButtonClicked;

            Host.Text = TouchMPCGtk.Settings.Default.MpdHostname;
            PortNumber.Value= TouchMPCGtk.Settings.Default.MpdPort;
        }

        public Exception LatestException
        {
            set { ErrorText.Text = value.Message; }
        }
        private void OnConnectButtonClicked(object sender, EventArgs e)
        {
            Sensitive = false;
            TouchMPCGtk.Settings.Default.MpdPort = (int)PortNumber.Value;
            TouchMPCGtk.Settings.Default.MpdHostname = Host.Text;
            TouchMPCGtk.Settings.Default.Save();

            Task.Factory.StartNew(() =>
            {
                try
                {
                    MpdClient.GetSharedClient().Status();
                    Result = true;
                    Application.Invoke(delegate { Destroy();});
                }
                catch (Exception ex)
                {
                    LatestException = ex;
                    Application.Invoke(delegate { Sensitive = true; });
                }
            });
        }

        public bool Result = false;
        private void OnExitButtonClicked(object sender, EventArgs e)
        {
            Destroy();
        }
    }
}
