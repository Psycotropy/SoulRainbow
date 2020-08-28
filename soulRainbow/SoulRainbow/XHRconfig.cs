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
    public partial class XHRconfig : Form
    {
        public XHRconfig()
        {
            InitializeComponent();

            //classes variables initialazing
            this.serverPathDialog = new FolderBrowserDialog();
            this.XHRconfiguration = new Configuration();
            serverPathDialog.Description = "Select your server root folder";
        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            serverPathDialog.ShowDialog();
            this.textBox_serverPath.Text = serverPathDialog.SelectedPath;
        }

        private void button_saveXHR_Click(object sender, EventArgs e)
        {
            this.port = textBox_Port.Text;
            this.folderPath = this.textBox_serverPath.Text;

            XHRconfiguration.setConfProperties("XHR", this.port);
            XHRconfiguration.configurate();
        }

        

        //configuration input values
        private string port;
        private string folderPath;

        //classes variables
        private FolderBrowserDialog serverPathDialog;
        private Configuration XHRconfiguration;

        
    }
}
