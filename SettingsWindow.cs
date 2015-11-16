using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using TouchMPC.Properties;

namespace TouchMPC
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
            txHost.Text = Settings.Default.MpdHostname;
            nPort.Value = Settings.Default.MpdPort;
        }

        public Exception LatestException
        {
            set { lblError.Text = value.Message; }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
            Close();
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            Enabled = false;
            Settings.Default.MpdPort =(int) nPort.Value;
            Settings.Default.MpdHostname = txHost.Text;
            Settings.Default.Save();

            Task.Factory.StartNew(() =>
            {
                try
                {
                    MpdClient.GetSharedClient().Status();
                    Invoke(new Action(() =>
                    {
                        DialogResult=DialogResult.OK;
                        Close();
                    }));
                }
                catch (Exception ex)
                {
                    Invoke(new Action(() =>
                    {
                        LatestException = ex;
                        Enabled = true;
                    }));
                }
            });
        }
    }
}
