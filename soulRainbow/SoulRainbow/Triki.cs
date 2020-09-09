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
    public partial class Triki : Form
    {
        public Triki()
        {
            InitializeComponent();

            //class variables
            this.server = new HTTPServer();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            try
            {
                server.start();
                this.label_info.Text = "Started listening for cookies on port...";
            }
            catch(Exception ex)
            {
                MessageBox.Show("some problem occurs, for more info: " + ex);
            }
            
        }

        private HTTPServer server;
    }
}
