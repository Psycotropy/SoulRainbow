using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace SoulRainbow
{
    class DNSServer
    {
        public DNSServer()
        {
            this.socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        }

        public void startEndpoint()
        {
            //byte[] buffer = new byte[1024];
            this.endpoint = new IPEndPoint(IPAddress.Any, 11000);
            socket.Bind(this.endpoint);
            socket.BeginReceiveFrom(buffer, 0, 512, SocketFlags.None, ref endpoint, onAccept, socket);
        }

        private void onAccept(IAsyncResult ar)
        {
            int payload = this.socket.EndReceiveFrom(ar, ref this.endpoint);
            Array.Resize<byte>(ref buffer, payload);

            var data = new dnsClientEventArgs();
            data.name = ((IPEndPoint)endpoint).Address.ToString();
            data.message = Encoding.ASCII.GetString(buffer);

            onClientReceived(data);

            this.buffer = new byte[512];
            socket.BeginReceiveFrom(buffer, 0, 512, SocketFlags.None, ref endpoint, onAccept, socket);
        }

        protected virtual void onClientReceived(dnsClientEventArgs e)
        {
            dnsClientReceived?.Invoke(this, e);
        }

        private Socket socket;
        private EndPoint endpoint;
        byte[] buffer = new byte[512];

        public EventHandler<dnsClientEventArgs> dnsClientReceived;

    }

    public class dnsClientEventArgs : EventArgs
    {
        public string name { get; set; }
        public string message { get; set; }
        
    }
}
