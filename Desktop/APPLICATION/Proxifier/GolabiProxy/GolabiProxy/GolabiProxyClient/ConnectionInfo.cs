using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace GolabiProxyClient
{
    class ConnectionInfo
    {
        public IPAddress ServerIP { get; set; }
        public IPAddress LocalIP { get; set; }
        public int ServerPort { get; set; }
        public int LocalPort { get; set; }
        public string Key { get; set; }
        public GolabiClientUI MessageCenter { get; set; }
        public bool EncryptionEnabled { get; set; }

        public ConnectionInfo(string serverIP, string serverPort, string localIP, string localPort, string Key, GolabiClientUI messageCenter, bool encryptionEnabled)
            : this(IPAddress.Parse(serverIP), int.Parse(serverPort), IPAddress.Parse(localIP), int.Parse(localPort), Key, messageCenter, encryptionEnabled)
        {
        }

        public ConnectionInfo(IPAddress serverIP, int serverPort, IPAddress localIP, int localPort, string key, GolabiClientUI messageCenter, bool encryptionEnabled)
        {
            this.ServerIP = serverIP;
            this.ServerPort = serverPort;
            this.LocalIP = localIP;
            this.LocalPort = localPort;
            this.Key = key;
            this.MessageCenter = messageCenter;
            this.EncryptionEnabled = encryptionEnabled;
        }
    }
}
