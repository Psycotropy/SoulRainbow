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
            this.dnsServer = new DNSServer();
        }

        private void button_listen_Click(object sender, EventArgs e)
        {
            this.dnsServer.startEndpoint();
        }

        private DNSServer dnsServer;
    }
}
