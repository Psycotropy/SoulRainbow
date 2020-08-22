using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoulRainbow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //inititalazing object type variables
            this.configurationForm = new Form2();
            this.myConfiguration = new Configuration();
            this.myServer = new Server();
            this.XMLDialog = new OpenFileDialog();
            XMLDialog.InitialDirectory = @"E:\Tools\soulRainbow\servers\SoulRainbow\SoulRainbow\XMLcommandExamples";
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
            configurationForm.Show();
        }

        private void button_listen_Click(object sender, EventArgs e)
        {


            if (this.optionXHR == true)
            {

                if (this.commandFile.Length > 0)
                {
                    XMLServer server = new XMLServer();
                    server.setXMLFilePath(this.commandFile);
                    server.startServerXML();
                }
                else
                {
                    MessageBox.Show("Debe elegir un archivo con comandos XML");
                }
            }

            /*port = Int32.Parse(myConfiguration.readPort());
            MessageBox.Show(port.ToString());
            //setting server parameters
            myServer.SetUserPort(port);
            //starting server listen ...
            myServer.serverStart();*/
        }

        private void button_WS_Click(object sender, EventArgs e)
        {

        }

        private void button_XmlRequest_Click(object sender, EventArgs e)
        {
            panel1.Controls.Add(loadXML);
        }

        private void Button_loadXml_click(object sender, EventArgs e)
        {
            //show dialog to select XML file
            XMLDialog.ShowDialog();
            this.commandFile = XMLDialog.FileName;
            //verify if in the dialog the user selects a file
            if (this.commandFile.Length > 0)
            {
                list_ActConnections.Items.Add("Using XML file : " + this.commandFile);
            }            
            setMenuToFalse();
            this.optionXHR = true;
        }


        private Form2 configurationForm;
        private Configuration myConfiguration;
        private Server myServer;
        private int port;
        private OpenFileDialog XMLDialog;
        private string commandFile;

        //menu selection flags
        private bool optionXHR;

    }

}
