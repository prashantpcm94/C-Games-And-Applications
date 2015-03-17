using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace GolabiProxyClient
{
    class ProxyTCPListener : IDisposable
    {
        private TcpListener _Listener;
        private ConnectionInfo _Info;
        private List<ClientConnection> _Clients;

        public ProxyTCPListener(ConnectionInfo info)
        {
            this._Info = info;
            
            this._Listener = new TcpListener(this._Info.LocalIP, this._Info.LocalPort);

            this._Clients = new List<ClientConnection>();
        }

        public void StartServer()
        {
            this._Listener.Start();
        }

        public void AcceptConnection()
        {
            if (this._Listener.Pending())
            {
                Socket newClient = this._Listener.AcceptSocket();
                this._Info.MessageCenter.setMessage("ClientAccepted...");
                ClientConnection _Client = new ClientConnection(newClient, this._Info);
                _Client.StartHandling();
                _Clients.Add(_Client);
            }
            Thread.Sleep(200);
        }

        public void Dispose()
        {
            foreach (ClientConnection client in _Clients)
            {
                client.StopHandling();
            }
            _Listener.Stop();
        }
    }


}
