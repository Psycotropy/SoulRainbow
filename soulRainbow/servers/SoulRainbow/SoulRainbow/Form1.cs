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
            configurationForm = new Form2();
            my_configuration = new Configuration();
            my_server = new Server();
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
            port = Int32.Parse(my_configuration.readConfigFile());
            //setting server parameters
            my_server.SetUserPort(port);
            //starting server listen ...
            my_server.serverStart(); 
            
        }

        Form2 configurationForm;
        Configuration my_configuration;
        Server my_server;
        int port;

        private void button_WS_Click(object sender, EventArgs e)
        {

        }

        private void button_XmlRequ_Click(object sender, EventArgs e)
        {
            this.loadXML.Name = "Buton_loadXml";
            this.loadXML.Dock = DockStyle.Top;
            this.loadXML.Text = "Load XML file";
            panel1.Controls.Add(loadXML);
            
            /*this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            panel1.Controls.Add(button1);*/
        }


    }
}
