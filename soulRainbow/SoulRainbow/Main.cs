using System;
using System.Windows.Forms;
using SoulRainbow.views;
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
            this.xmlRequestView = new xmlView();
            this.dnsRequestView = new dnsView();
            
            //initialazing XML dialog deafaults
            XMLDialog.InitialDirectory = @"";
            XMLDialog.Title = "Browse Xml Files";
            XMLDialog.DefaultExt = "xml";
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

        private void button_WS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under construction");
        }

        private void button_DNS_Click(object sender, EventArgs e)
        {
            hideControls();
            this.dnsRequestView.Parent = this;
            this.dnsRequestView.Dock = DockStyle.Fill;
            this.dnsRequestView.Show();
            this.dnsRequestView.BringToFront();
            
            
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
            hideControls();
            this.xmlRequestView.Parent = this;
            this.xmlRequestView.Dock = DockStyle.Fill;
            this.xmlRequestView.Show();
            this.xmlRequestView.BringToFront();
        }

        private void hideControls()
        {
            foreach(Control control in this.Controls)
            {
                if (control.Name.Contains("View"))
                {
                    control.Hide();
                }
            }
        }
        //classes variables and program variables 
        private Triki trikiStart;
        private Configuration myConfiguration;
        private OpenFileDialog XMLDialog;
        private OpenFileDialog serverPathDialog;
        private xmlView xmlRequestView;
        private dnsView dnsRequestView;
    }
}
