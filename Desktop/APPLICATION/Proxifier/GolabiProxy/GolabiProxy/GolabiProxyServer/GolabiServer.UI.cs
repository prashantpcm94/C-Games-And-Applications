using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace GolabiProxyServer
{
    public partial class GolabiServerUI : Form
    {
        public GolabiServerUI()
        {
            InitializeComponent();
        }

        ProxyTCPListener proxyListener;
        delegate void SetTextCallback(string msg);
        Thread StartListenApp;

        private void startAcc()
        {
            ConnectionInfo info = new ConnectionInfo(ListenIP.Text, ListenPort.Text, KeyInput.Text, this, Encrypt.Checked);

            proxyListener = new ProxyTCPListener(info);

            proxyListener.StartServer(this, KeyInput.Text);

            while (true)
            {
                proxyListener.AcceptConnection();
            }
        }

        

        public void setMessage(string msg)
        {
            if (this.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setMessage);
                this.Invoke(d, new object[] { msg });
                return;
            }

            Messages.Text += msg + "\r\n";
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (StartListenApp == null || StartListenApp.ThreadState == ThreadState.Stopped)
            {
                StartListenApp = new Thread(new ThreadStart(startAcc));
                StartListenApp.Start();
            }
            else
            {
                setMessage("Cannot start again...");
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (StartListenApp != null)
                StartListenApp.Abort();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Stop.PerformClick();
            this.Close();
            this.Dispose();
        }

        private void Encrypt_CheckedChanged(object sender, EventArgs e)
        {
            KeyInput.Enabled = Encrypt.Checked;
        }
    }
}
