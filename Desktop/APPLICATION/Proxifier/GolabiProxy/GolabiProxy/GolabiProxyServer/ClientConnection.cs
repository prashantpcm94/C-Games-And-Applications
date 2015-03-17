using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using EncryptionLibrary;

namespace GolabiProxyServer
{
    class ClientConnection
    {
        private Socket clientSocket;
        private ConnectionInfo _Info;
        private Thread handler;

        public ClientConnection(Socket client, ConnectionInfo info)
        {
            this._Info = info;
            client.SendTimeout = 12000;
            client.ReceiveTimeout = 1200;
            this.clientSocket = client;
        }

        public void StartHandling()
        {
            handler = new Thread(Handler);
            handler.Priority = ThreadPriority.Highest;
            handler.Start();
        }

        private void Handler()
        {
            bool recvRequest = true;
            string EOL = "\r\n";

            string requestPayload = "";
            string requestTempLine = "";
            List<string> requestLines = new List<string>();
            byte[] requestBuffer = new byte[1];
            byte[] responseBuffer = new byte[1];

            requestLines.Clear();

            try
            {
                while (recvRequest)
                {
                    this.clientSocket.Receive(requestBuffer);
                    string fromByte = UTF8Encoding.UTF8.GetString(requestBuffer);
                    requestPayload += fromByte;
                    requestTempLine += fromByte;

                    if (requestPayload.EndsWith("farhadserverfinish"))
                    {
                        recvRequest = false;
                    }

                }

                string recivedDec;

                if (this._Info.EncryptionEnabled)
                {
                    recivedDec = Encryption.Decrypt(requestPayload.Replace("farhadserverfinish", ""), this._Info.Key);
                }
                else
                {
                    recivedDec = requestPayload.Replace("farhadserverfinish", "");
                }

                requestPayload = "";
                requestTempLine = "";

                int counter = 0;
                //State 0: Handle Request from Client
                while (counter < recivedDec.Length)
                {
                    string fromByte = recivedDec[counter].ToString();
                    counter++;
                    requestPayload += fromByte;
                    requestTempLine += fromByte;

                    if (requestTempLine.EndsWith(EOL))
                    {
                        requestLines.Add(requestTempLine.Trim());
                        requestTempLine = "";
                    }

                    if (requestPayload.EndsWith(EOL + EOL))
                    {
                        break;
                    }

                }
                //State 1: Rebuilding Request Information and Create Connection to Destination Server
                if (requestLines.Count == 0)
                {
                    return;
                }

                string remoteHost = requestLines[0].Split(' ')[1].Replace("http://", "").Split('/')[0];
                string requestFile = requestLines[0].Replace("http://", "").Replace(remoteHost, "");
                requestLines[0] = requestFile;

                this._Info.MessageCenter.setMessage(string.Format("Request to {0}", remoteHost));

                requestPayload = "";
                foreach (string line in requestLines)
                {
                    requestPayload += line;
                    requestPayload += EOL;
                }

                Socket destServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                destServerSocket.Connect(remoteHost, 80);
                destServerSocket.ReceiveTimeout = 12000;
                destServerSocket.SendTimeout = 12000;

                //State 2: Sending New Request Information to Destination Server and Relay Response to Client
                destServerSocket.Send(ASCIIEncoding.ASCII.GetBytes(requestPayload));

                if(false)
                while (destServerSocket.Receive(responseBuffer) != 0)
                {
                    int tmp = responseBuffer[0];
                    tmp += 2;
                    if (tmp > 255)
                    {
                        tmp -= 256;
                    }
                    responseBuffer[0] = (byte)tmp;
                    this.clientSocket.Send(responseBuffer);
                }

                while (destServerSocket.Receive(responseBuffer) != 0)
                {
                    this.clientSocket.Send(responseBuffer);
                }

                destServerSocket.Disconnect(false);
                this.clientSocket.Disconnect(false);
            }
            catch (Exception ex)
            {
                this._Info.MessageCenter.setMessage(ex.Message);
            }
        }
    }
}
