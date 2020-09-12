using System;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;
using System.Drawing.Text;

namespace SoulRainbow
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            //inititalazing object type variables
            //this.XHRconfiguration = new XHRconfig();
            this.myConfiguration = new Configuration();
            this.XMLDialog = new OpenFileDialog();
            this.serverPathDialog = new OpenFileDialog();
            this.trikiStart = new Triki();

            this.HTTPServer = new HTTPServer();
            HTTPServer.clientRecieved += HTTPServer_clientRecieved;
            HTTPServer.start();


            //initialazing XML dialog deafaults
            XMLDialog.InitialDirectory = @"";
            XMLDialog.Title = "Browse Xml Files";
            XMLDialog.DefaultExt = "xml";
            setMenuToFalse();
        }

        private void HTTPServer_clientRecieved(object sender, ProcessEventArgs e)
        {
            string clientIP = e.clientIP;
            string additionalInfo = e.additionalInfo;
            list_ActConnections.Items.Add("client ip: " + clientIP + " additional Info: " + additionalInfo);
        }

        private void setMenuToFalse()
        {
            this.optionXHR = false;
        }

        public ListBox list_connections()
        {
            return this.list_ActConnections;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel_general_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_connections_Click(object sender, EventArgs e)
        {

        }

        private void button_configuration_Click(object sender, EventArgs e)
        {
            XHRconfig configurationXML = new XHRconfig();
            configurationXML.Show();
        }

        private void button_listen_Click(object sender, EventArgs e)
        {
            this.optionXHR = true;

            if (this.optionXHR == true)
            {
                try
                {
                    XMLServer server = new XMLServer();
                    server.startServerXML();



                }
                catch (Exception ex)
                {
                    MessageBox.Show("We are in troubles for more info: " + ex);
                }

            }

        }

        private void button_WS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under construction");
        }



        private void button_DNS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under construction");
            
        }

        private void button_messaging_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under construction");
        }

        private void button_CORS2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under construction");
        }

        private void button_XmlRequest_Click(object sender, EventArgs e)
        {
            
        }


        private void button_triki_Click(object sender, EventArgs e)
        {
            trikiStart.Show();
            
        }


        


        //classes variables and program variables 
        private XHRconfig XHRconfiguration;
        private Triki trikiStart;
        private Configuration myConfiguration;
        private OpenFileDialog XMLDialog;
        private OpenFileDialog serverPathDialog;
        private HTTPServer HTTPServer;
        
        //Events handlers
       

        //menu selection flags
        private bool optionXHR;
    }
        

}
