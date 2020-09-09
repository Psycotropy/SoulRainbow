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
            this.virtualDirsManager = new FileManager("routing.txt");
            serverPathDialog.Description = "Select your server root folder";


            //Directory browser properties setting
            
        }


        private void button_browse_Click(object sender, EventArgs e)
        {
            serverPathDialog.ShowDialog();
            this.textBox_serverPath.Text = serverPathDialog.SelectedPath;
        }

        private void button_saveXHR_Click(object sender, EventArgs e)
        {
            //add port to the conf file 
            this.port = textBox_Port.Text;
            this.folderPath = this.textBox_serverPath.Text;

            directoryScanner(this.textBox_serverPath.Text);
            XHRconfiguration.setConfProperties("XHR", this.port);
            XHRconfiguration.configurate();

            //retrive all the fisical path of dirs and files using the virtualDirGenerator method
            List<string> subDirectories = new List<string>();
            subDirectories = directoryScanner(this.folderPath);

            List<string> Files = new List<string>();
            Files = fileScanner(this.folderPath);

            foreach (string filepath in Files)
            {
                //MessageBox.Show("filepath: " + filepath);
            }

            //TODO: generate a routing.txt file with the dictionary data
            //generate dictionary related to the value of the dictionary with its key calling the physical directory
            XHRconfiguration.directoryScanner(this.textBox_serverPath.Text, subDirectories, Files);

            //XHRconfiguration.routingFileGenerator(this.textBox_serverPath.Text, dirs);

        }

        /// <summary>
        /// this method is responsible of make the routing.txt file that is used by HTTPServer to establish the virtual/ fisical directories.
        /// </summary>
        /// <param name="path"></param>
        private List<string> directoryScanner(string path)
        {
            //all directories and subdirectories in this array
            List<string> subDirs = new List<string>();


            subDirs = Directory.GetDirectories(path, "*.*", SearchOption.AllDirectories).ToList<string>();

            return subDirs;

        }

        private List<string> fileScanner(string path)
        {
            //all the files of the subdirs in this array
            List<string> files = new List<string>();

            files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories).ToList<string>();

            return files;
        }


        //configuration input values
        private string port;
        private string folderPath;

        //classes variables
        private FolderBrowserDialog serverPathDialog;
        private Configuration XHRconfiguration;
        private FileManager virtualDirsManager;
                 
    }
}
