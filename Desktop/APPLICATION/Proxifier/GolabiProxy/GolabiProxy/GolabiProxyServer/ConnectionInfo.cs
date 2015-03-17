using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace GolabiProxyServer
{
    class ConnectionInfo
    {
        public IPAddress LocalIP { get; set; }
        public int LocalPort { get; set; }
        public string Key { get; set; }
        public GolabiServerUI MessageCenter { get; set; }
        public bool EncryptionEnabled { get; set; }

        public ConnectionInfo(string localIP, string localPort, string Key, GolabiServerUI messageCenter, bool encryptionEnabled)
            : this(IPAddress.Parse(localIP), int.Parse(localPort), Key, messageCenter,encryptionEnabled)
        {
        }

        public ConnectionInfo(IPAddress localIP, int localPort, string key, GolabiServerUI messageCenter, bool encryptionEnabled)
        {
            this.LocalIP = localIP;
            this.LocalPort = localPort;
            this.Key = key;
            this.MessageCenter = messageCenter;
            this.EncryptionEnabled = encryptionEnabled;
        }
    }
}
