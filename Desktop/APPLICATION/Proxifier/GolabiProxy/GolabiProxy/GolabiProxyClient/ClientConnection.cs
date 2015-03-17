using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using EncryptionLibrary;

namespace GolabiProxyClient
{
    class ClientConnection
    {
        private Socket clientSocket;
        private ConnectionInfo _Info;
        private Thread handler;
        private bool _ContinueRecive;

        public ClientConnection(Socket client, ConnectionInfo info)
        {
            this._Info = info;
            client.SendTimeout = 12000;
            client.ReceiveTimeout = 12000;
            this.clientSocket = client;
            _ContinueRecive = true;
        }

        public void StartHandling()
        {
            handler = new Thread(new ThreadStart(Handler));
            handler.Priority = ThreadPriority.Highest;
            handler.Start();
        }

        public void StopHandling()
        {
            _ContinueRecive = false;

            handler.Abort();
        }

        private void Handler()
        {
            bool recvRequest = true;
            string EOL = "\r\n";

            string requestPayload = "";
            List<string> requestLines = new List<string>();
            byte[] requestBuffer = new byte[1];
            byte[] responseBuffer = new byte[1];

            requestLines.Clear();

            try
            {
                //State 0: Handle Request from Client
                while (recvRequest && _ContinueRecive)
                {
                    if (this.clientSocket.Receive(requestBuffer) == 0)
                    {
                        break;
                    }
                    string fromByte = UTF8Encoding.UTF8.GetString(requestBuffer);
                    requestPayload += fromByte;
                    if (requestPayload.EndsWith(EOL + EOL))
                    {
                        recvRequest = false;
                    }
                }

                //State 1: Creating a new socket to connect to server
                Socket destServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                destServerSocket.Connect(this._Info.ServerIP,this._Info.ServerPort);
                destServerSocket.ReceiveTimeout = 12000;
                destServerSocket.SendTimeout = 12000;

                //State 2: Sending New Request Information to Destination Server and Relay Response to Client
                if (this._Info.EncryptionEnabled)
                {
                    destServerSocket.Send(ASCIIEncoding.ASCII.GetBytes(Encryption.Encrypt(requestPayload, this._Info.Key) + "farhadserverfinish"));
                }
                else
                {
                    destServerSocket.Send(ASCIIEncoding.ASCII.GetBytes(requestPayload + "farhadserverfinish"));
                }

                if (false)
                {
                    while (destServerSocket.Receive(responseBuffer) != 0)
                    {
                        int tmp = responseBuffer[0];
                        tmp -= 2;
                        if (tmp < 0)
                        {
                            tmp += 256;
                        }
                        responseBuffer[0] = (byte)tmp;
                        this.clientSocket.Send(responseBuffer);
                    }

                }
                else
                {
                    while (destServerSocket.Receive(responseBuffer) != 0)
                    {
                        this.clientSocket.Send(responseBuffer);
                    }
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
