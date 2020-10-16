using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoulRainbow.views
{
    public partial class dnsView : UserControl
    {
        public dnsView()
        {
            InitializeComponent();

            //initialize classes
            
        }

        private void button_listen_Click(object sender, EventArgs e)
        {
            this.dnsServer = new DNSServer();
            this.dnsServer.dnsClientReceived += dnsClient_Received;
            this.dnsServer.startEndpoint();
        }

        private void dnsClient_Received(object sender, dnsClientEventArgs e)
        {
            string Name = e.name;
            string Message = e.message;
            this.list_ActConnections.Items.Add("Client " + Name + " says: " + Message);
        }

        private DNSServer dnsServer;
    }
}
