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
            this.host = Dns.GetHostEntry("AUDIOCAST");
            this.ipAddress = host.AddressList[0];
            this.localEndpoint = new IPEndPoint(IPAddress.Any, 11000);
        }

        public void startEndpoint()
        {
            UdpClient server = new UdpClient(localEndpoint);

            server.BeginReceive(onAccept, null);
            
        }

        private void onAccept(IAsyncResult ar)
        {
            MessageBox.Show("cliente recivido");
        }

        static void acceptEventArgs_Completed(object sender, EventArgs e)
        {
            MessageBox.Show("se ha disparado");
        }

        private IPHostEntry host;
        private IPAddress ipAddress;
        private IPEndPoint localEndpoint;

    }
}
