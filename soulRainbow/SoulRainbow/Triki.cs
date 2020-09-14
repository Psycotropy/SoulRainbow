using System;
using System.Windows.Forms;

namespace SoulRainbow
{
    public partial class Triki : Form
    {
        public Triki()
        {
            InitializeComponent();
            
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under construction");
            /*try
            {
                //server.startServerTriki();
                this.label_info.Text = "Started listening for cookies on port...";
            }
            catch(Exception ex)
            {
                MessageBox.Show("some problem occurs, for more info: " + ex);
            }*/
        }        
    }
}
