using System;
using System.Windows.Forms;

namespace SoulRainbow
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            //inititalazing object type variables
            this.XHRconfiguration = new XHRconfig();
            this.myConfiguration = new Configuration();
            this.XMLDialog = new OpenFileDialog();
            this.serverPathDialog = new OpenFileDialog();
            this.trikiStart = new Triki();

            //initialazing XML dialog deafaults
            XMLDialog.InitialDirectory = @"";
            XMLDialog.Title = "Browse Xml Files";
            XMLDialog.DefaultExt = "xml";
            setMenuToFalse();
        }

        private void setMenuToFalse()
        {
            this.optionXHR = false;
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
            if (this.optionXHR)
            {
                XHRconfiguration.Show();
            }
            else
            {
                return;
            }

            
        }

        private void button_listen_Click(object sender, EventArgs e)
        {
            this.optionXHR = true;

            if (this.optionXHR == true)
            {
                try
                {
                    if (this.commandFile.Length > 0)
                    {
                        //MessageBox.Show("pwn");
                        XMLServer server = new XMLServer();
                        server.setXMLFilePath(this.commandFile);
                        server.startServerXML();
                    }
                    else
                    {
                        MessageBox.Show("Debe elegir un archivo con comandos XML");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("We are in troubles for more info: " + ex);
                }
                
            }

        }

        private void button_WS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under construction");
        }

        private void button_XmlRequest_Click(object sender, EventArgs e)
        {
            panel1.Controls.Add(loadXML);
            this.optionXHR = true;
        }

        private void Button_loadXml_click(object sender, EventArgs e)
        {
            XMLDialog.InitialDirectory = "E:/github/RetainingControl/soulRainbow/SoulRainbow/www/";
            //show dialog to select XML file
            XMLDialog.ShowDialog();
            this.commandFile = XMLDialog.FileName;
            //verify if in the dialog the user selects a file
            if (this.commandFile.Length > 0)
            {
                list_ActConnections.Items.Add("Using XML file : " + this.commandFile);
            }            
            setMenuToFalse();
            
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

        private void button_triki_Click(object sender, EventArgs e)
        {
            trikiStart.Show();
        }

        private XHRconfig XHRconfiguration;
        private Triki trikiStart;
        private Configuration myConfiguration;
        private OpenFileDialog XMLDialog;
        private OpenFileDialog serverPathDialog;
        private string commandFile;

        //menu selection flags
        private bool optionXHR;

        
    }

}
