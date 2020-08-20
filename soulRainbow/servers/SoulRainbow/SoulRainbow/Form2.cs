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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //save button
        private void button1_Click(object sender, EventArgs e)
        {
            Configuration my_configuration = new Configuration();
            my_configuration.setConfProperties(textBox_port.Text);
            my_configuration.configurate();

            this.Close();
        }
    }
}
