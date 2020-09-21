using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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
            this.ConfigurationProcessor = new ConfigurationDialogs();

            serverPathDialog.Description = "Select your server root folder";
            
        }


        private void button_browse_Click(object sender, EventArgs e)
        {
            serverPathDialog.ShowDialog();
            this.textBox_serverPath.Text = serverPathDialog.SelectedPath;
        }

        private void button_saveXHR_Click(object sender, EventArgs e)
        {
            try
            {
                //add port to the conf file 
                this.port = textBox_Port.Text;
                this.folderPath = this.textBox_serverPath.Text;

                XHRconfiguration.setConfProperties("XHR", this.port);
                XHRconfiguration.setServerPath(this.folderPath);
                XHRconfiguration.configurate();

                //retrive all the fisical path of dirs and files using the virtualDirGenerator method
                List<string> subDirectories = new List<string>();
                subDirectories = ConfigurationProcessor.directoryScanner(this.folderPath);

                List<string> Files = new List<string>();
                Files = ConfigurationProcessor.fileScanner(this.folderPath);

                //generate dictionary related to the value of the dictionary with its key calling the physical directory
                XHRconfiguration.directoryScanner(this.textBox_serverPath.Text, subDirectories, Files);

                //XHRconfiguration.routingFileGenerator(this.textBox_serverPath.Text, dirs);
            }catch(Exception ex)
            {
                MessageBox.Show("We have some problems here try rebooting the tool and configurate your parameters before start listening" + ex);
            }

        }

        //configuration input values
        private string port;
        private string folderPath;

        //classes variables
        private FolderBrowserDialog serverPathDialog;
        private Configuration XHRconfiguration;
        private ConfigurationDialogs ConfigurationProcessor;
        
                 
    }
}
