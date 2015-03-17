using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace GolabiProxyServer
{
    class ProxyTCPListener
    {
        private TcpListener _Listener;
        private ConnectionInfo _Info;

        public ProxyTCPListener(ConnectionInfo info)
        {
            this._Info = info;
            this._Listener = new TcpListener(this._Info.LocalIP, this._Info.LocalPort);
        }

        public void StartServer(GolabiServerUI messageCenter, string key)
        {
            this._Listener.Start();
        }

        public void AcceptConnection()
        {
            if (this._Listener.Pending())
            {
                Socket newClient = this._Listener.AcceptSocket();
                this._Info.MessageCenter.setMessage("ClientAccepted...");
                ClientConnection client = new ClientConnection(newClient, this._Info);
                client.StartHandling();
            }
        }
    }
}
