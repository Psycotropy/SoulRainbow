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
            Dictionary<string,string> dirs = virutalDirGenerator(subDirectories, Files);

            XHRconfiguration.routingFileGenerator(this.textBox_serverPath.Text, dirs);

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

        private Dictionary<string, string> virutalDirGenerator(List<string> directories, List<string> files)
        {
            Dictionary<string, string> virtualDirs = new Dictionary<string, string>();
            List<string> foo = new List<string>();

            char[] delimiter = {'\\'};

            //select a single path in directory
            foreach(string dirs in directories)
            {
                //break the path into words without the '\'
                string[] directorySplited = dirs.Split(delimiter);

                //cycle through each of the folder names
                for (int i = 0; i < directorySplited.Length; i++)
                {

                    //until it finds the key name of the root directory (www) breaking the path in two
                    if (directorySplited[i].Contains("www"))
                    {

                        //variable used to generate the virtual directories starting from /index
                        string virtualDirConcatenated = "/index/";


                        int j;

                        //loop through each directory name after www folder
                        for (j = 1; j < directorySplited.Length - i; j++)
                        {
                            //this if add the '\' to directory path
                            if (j >= 2)
                            {
                                virtualDirConcatenated = "/index/";
                            }

                            //in case if virtual dir is in case it finds root directory for the subsequent concatenation
                            if (j != 1)
                            {
                                virtualDirConcatenated = virtualDirConcatenated + directorySplited[i + j] + "/";
                            }
                            else
                            {
                                virtualDirConcatenated = virtualDirConcatenated.Substring(0, 6);
                            }
                               
                        }

                        /*uncomment in case of debugging
                        //MessageBox.Show("virtual dir added: " + virtualDirConcatenated);

                        */

                        //TODO: add the corresponded fisical path to the virtualDirs
                        
                        foreach (string fisicalPath in files)
                        {
                            //MessageBox.Show("fisical path: " + fisicalPath);
                            if (fisicalPath.Substring(6).Contains(virtualDirConcatenated.Substring(6)) || virtualDirConcatenated.Length == 6)
                            {
                                MessageBox.Show("fisical path relationed: " + fisicalPath);
                                foo.Add(fisicalPath);



                                Regex reg = new Regex("^[0-9]*$");

                                foreach (KeyValuePair<string, string> virtualDir in virtualDirs)
                                {
                                    if (reg.IsMatch(virtualDir.Key))
                                    {
                                        string key = virtualDir.Key;
                                        string value = fisicalPath;


                                        virtualDirs.Add(key, value);
                                    }
                                }
                            }

                        }

                        virtualDirs.Add(virtualDirConcatenated, "2");
                    }
                }   
            }

            foreach(KeyValuePair<string,string> virtualDir in virtualDirs)
            {
                MessageBox.Show("Key: " + virtualDir.Key + " value: " + virtualDir.Value);
            }

            foreach (string fisicalPath in foo)
            {
                MessageBox.Show(fisicalPath);
            }

            
            return virtualDirs;
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
