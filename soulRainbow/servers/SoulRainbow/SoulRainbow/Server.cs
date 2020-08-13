using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;

namespace SoulRainbow
{
    class Server
    {
        public Server()
        {
            SetVariables();
        }

        //In this method we are setting the fundamental variables of the class.
        private void SetVariables()
        {
            this.connectionsInfoKeys = 1;
            this.connectionsInfoKeys = 1;

            connectionsInfo = new Dictionary<int, string>();
            connectionsSockets = new Dictionary<int, TcpClient>();
        }

        public void SetUserPort(int port)
        {
            this.port = port;
        }

        public string GetConnectionInfo()
        {
            return this.connectionInfo;
        }

        public void serverStart()
        {

            //Creates a new Tcp listen instance at port .
            TcpListener.Create(port);

            //server was defined listen at port in any interfaces 
            server = new TcpListener(IPAddress.Parse("192.168.1.229"), port);

            server.Start(5);
            //accepting the client connection request
            server.BeginAcceptTcpClient(AcceptCallBack, server);
        }



        private void AcceptCallBack(IAsyncResult result)
        {
            TcpClient connection;
            //NetworkStream stream;


            try
            {
                connection = server.EndAcceptTcpClient(result);
                MessageBox.Show("Client connected");

            }
            catch (ObjectDisposedException ex)
            {
                MessageBox.Show("Caught, problem with creating socket for connection {0}", ex.ToString());

                return;
            }


            httpHandler(connection);
        }

        private void httpHandler(TcpClient connection)
        {
            //flag 1: means do the client stream read process..

            connectionInfo = streamReader(connection);
            //verifies if the connection is HTTP or socket
            if (Regex.IsMatch(connectionInfo, "^GET", RegexOptions.IgnoreCase))
            {
                string responseKey = httpWebSocketResponseKey(connectionInfo);

                MessageBox.Show("The client says: " + connectionInfo);

                StreamWriter(connection, responseKey);

                connectionsInfo.Add(connectionsInfoKeys, connectionInfo);

                connectionsSockets.Add(connectionsSocketKeys, connection);

                this.connectionsInfoKeys++;
            }

            NetworkStream stream = connection.GetStream();

            string i = streamReader(connection);
            MessageBox.Show(i);

            


        }

        private string httpWebSocketResponseKey(string header)
        {
            //Search in the header for the web socket key
            string pattern = "Sec-WebSocket-Key: (.*)";
            string webSocketKey = Regex.Match(header, pattern).Groups[1].Value.Trim();

            //concatenates the WS key obtained with the special GUID specified by RFC 6455
            string webSocketKeyAdd = webSocketKey + webSocketGuid;

            //compute SHA-1 and Base64 for the new value
            byte[] wskaSha1 = System.Security.Cryptography.SHA1.Create().ComputeHash(Encoding.UTF8.GetBytes(webSocketKeyAdd));

            string wskaSha1Base64 = Convert.ToBase64String(wskaSha1);

            //HTTP 1.1 defines the sequence CR LF as the end-of line marker

            string response = "HTTP/1.1 101 Web Socket Protocol Handshake\r\n" +
            "Connection: Upgrade: websocket\r\n" +
            "Sec-WebSocket-Accept: " + wskaSha1Base64 + "\r\n\r\n";

            return response;




        }

        //This returns the connections messages or failing that an error message 
        private string streamReader(TcpClient connection)
        {
            NetworkStream stream = connection.GetStream();

            byte[] bytes = new byte[connection.ReceiveBufferSize];

            if (stream.CanRead)
            {
                stream.Read(bytes, 0, (int)connection.ReceiveBufferSize);

                return connectionInfo = Encoding.UTF8.GetString(bytes);
            }
            else
            {
                return "Problem in reading the stream";
            }

        }

        private void StreamWriter(TcpClient connection, string message)
        {
            byte[] response = Encoding.UTF8.GetBytes(message);
            NetworkStream stream = connection.GetStream();

            if (stream.CanWrite)
            {
                stream.Write(response, 0, response.Length);
            }
            else
            {
                MessageBox.Show("Problem with writing in the stream");
            }
        }



        int port;
        string connectionInfo;
        TcpListener server;
        TcpClient client;
        Dictionary<int, string> connectionsInfo;
        Dictionary<int, TcpClient> connectionsSockets;
        int connectionsInfoKeys;
        int connectionsSocketKeys;
        const string webSocketGuid = "258EAFA5-E914-47DA-95CA-C5AB0DC85B11";
    }
}