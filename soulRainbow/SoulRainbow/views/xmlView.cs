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
    public partial class xmlView : UserControl
    {
        public xmlView()
        {
            InitializeComponent();
        }

        private void HTTPServer_clientRecieved(object sender, ProcessEventArgs e)
        {
            string clientIP = e.ClientIP;
            string additionalInfo = e.AdditionalInfo;
            list_ActConnections.Items.Add("client ip: " + clientIP + " additional Info: " + additionalInfo);
        }

        private void HTTPServer_XMlclientRecieved(object sender, XMLclientEventArgs e)
        {
            string clientIP = e.ClientIP;
            string additionalInfo = e.AdditionalInfo;
            list_ActConnections.Items.Add("client XML request, client ip: " + clientIP + " additional Info: " + additionalInfo);
        }
        
        private void button_listen_Click(object sender, EventArgs e)
        {
            this.HTTPServer = new HTTPServer();
            HTTPServer.clientRecieved += HTTPServer_clientRecieved;
            HTTPServer.XMLclientRecieved += HTTPServer_XMlclientRecieved;
            HTTPServer.start();
        }
        private void button_stop_Click(object sender, EventArgs e)
        {
            HTTPServer.stop();
        }

        private void button_triki_Click(object sender, EventArgs e)
        {
            Triki triki = new Triki();
            triki.Show();
        }

        private void button_configuration_Click(object sender, EventArgs e)
        {
            XHRconfig config = new XHRconfig();
            config.Show();
        }

        private HTTPServer HTTPServer;

    }
}
