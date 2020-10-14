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
            this.socket = new Socket(SocketType.Dgram, ProtocolType.Udp);
            this.localEndpoint = new IPEndPoint(IPAddress.Any, 53);
        }

        public void startEndpoint()
        {
            byte[] buffer = new byte[512];

            socket.Bind(this.localEndpoint);
            socket.BeginReceive(buffer, 0, 512, SocketFlags.None, new AsyncCallback(onAccept), null); 
        }

        private void onAccept(IAsyncResult ar)
        {
            MessageBox.Show("cliente recibido");
            byte[] data = new byte[512];
            int payload = this.socket.Receive(data);
            Array.Resize<byte>(ref data, payload);
            MessageBox.Show("Client says: " + Encoding.ASCII.GetString(data));
            
        }

        static void acceptEventArgs_Completed(object sender, EventArgs e)
        {
            MessageBox.Show("se ha disparado");
        }

        private IPEndPoint localEndpoint;
        private Socket socket;

    }
}
