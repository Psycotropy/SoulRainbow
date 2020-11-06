using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SoulRainbow
{
    class DNSServer
    {
        public DNSServer()
        { 
        }

        public void startEndpoint()
        {
            //this.socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            
            this.socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            this.endpoint = new IPEndPoint(IPAddress.Any, 53);
            buffer = new byte[512];
            socket.Bind(this.endpoint);
            socket.DontFragment = true;

            socket.BeginReceiveMessageFrom(buffer, 0, 512, SocketFlags.None, ref endpoint, onAccept, null);

        }

        private void onAccept(IAsyncResult ar)
        {
            IPPacketInformation packet;
            SocketFlags flags = SocketFlags.Partial;

            int size = socket.EndReceiveMessageFrom(ar, ref flags, ref this.endpoint, out 
                packet );

            UnsafeNetworkThread dnsHelper = new UnsafeNetworkThread();
            string dnsQuery = dnsHelper.readNetworkBuffer(ref buffer);

            var data = new dnsClientEventArgs();
            data.name = ((IPEndPoint)endpoint).Address.ToString();
            data.message = $"size : " + size.ToString() + " content: " +
                dnsQuery + " read : ";

            onClientReceived(data);

            byte[] message = Encoding.ASCII.GetBytes("hola cliente");
            socket.SendTo(message, endpoint);

            socket.BeginReceiveMessageFrom(buffer, 0, 512, SocketFlags.None, ref endpoint, onAccept, null);
        }




        protected virtual void dataRecivedCompleted(object sender, dnsClientEventArgs e)
        {
            var data = new dnsClientEventArgs();
            data.name = e.name;
            data.message = e.message;
            onClientReceived(data);
        }

        protected virtual void onClientReceived(dnsClientEventArgs e)
        {
            dnsClientReceived?.Invoke(this, e);
        }

        public EventHandler<dnsClientEventArgs> dnsClientReceived;

        private Socket socket;
        private EndPoint endpoint;
        byte[] buffer;
    }

    public unsafe class UnsafeNetworkThread
    {
        public string readNetworkBuffer(ref byte[] buffer)
        {
            char[] query = new char[512];

            for(int i = 0; i < buffer.Length; i++)
            {
                byte elemento = buffer[i];
                byte[] bufferTemporal = new byte[512];
                bufferTemporal[0] = elemento;
                char[] temporalArray = Encoding.ASCII.GetChars(bufferTemporal);

                for (int j = 0; j < 1; j++)
                {
                    query[i] = temporalArray[j];
                }
            }


            string[] copiedQuery = new string[512];
            for(int i = 0; i < query.Length; i++)
            {
                char actualChar = query[i];
                char* actualCharPtr= &actualChar;

                char copiedChar;
                char* copiedCharPtr = &copiedChar;
                Buffer.MemoryCopy(actualCharPtr, copiedCharPtr, 8, 7);

                if (char.IsLetterOrDigit(copiedChar))
                {
                    copiedQuery[i] = "" + copiedChar;

                }
            }
            string queryStringed = string.Join("", copiedQuery);

            return queryStringed;
        }

        
    }

    public class dnsClientEventArgs : EventArgs
    {
        public string name { get; set; }
        public string message { get; set; }

    }
}
