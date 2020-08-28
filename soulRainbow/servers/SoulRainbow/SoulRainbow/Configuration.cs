using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace SoulRainbow
{
    class Configuration
    {
        public Configuration()
        {
            this.filePath = "config.conf";
            this.clientsCabinetPath = "clients.txt";
            
        }

        public void setConfProperties(string channelName, string PortLocal)
        {

            if (PortLocalVer(PortLocal) == true)
            {
                this.PortLocal = PortLocal;
                this.channelName = channelName;
            }
            else
                MessageBox.Show("The valid port range is between 0 - 65.535");

        }


        // this method verifies if Port numeber is valid
        private bool PortLocalVer(string portLocal)
        {
            if (Int32.Parse(portLocal) >= 0 || Int32.Parse(portLocal) < 65.535)
                return true;
            else
                return false;
        }

        public void configurate()
        {
            string configToAdd = this.channelName + "," + this.PortLocal;

            FileManager manager = new FileManager(filePath);

            //Get all in memory about actual configuration
            List<string> actualConfigList = new List<string>(manager.readAll());


            //search for old configuration that has to be changed in the configuration file and removes it 
            try
            { 
                foreach (string line in actualConfigList)
                {
                    
                    string []channel = line.Split(',');
                    if (channel[0].Contains(this.channelName))
                    {
                        //verfies if the part number is a digit 
                        if (channel[1].All<char>(char.IsDigit))
                        {

                            actualConfigList.Remove(line);

                        }
                                                    
                    }

                }
            }
            catch (Exception)
            {
                //this was empty beacause not exists the remove of repeated line throws an exception. 
            }


            //delete the actual configuration file
            File.Delete(this.filePath);

            //again creates the config file but empty
            manager.Create();

            //load the config without the repeated line
            foreach(string line in actualConfigList)
            {
                manager.addLine(line);
            }
                   
            //Add the new configuration to the config file
            manager.addLine(configToAdd);
            
        }

        public string readPort()
        {
            FileManager manager = new FileManager(filePath);
            return manager.readLineByString(PortLocal);
        }



        private string filePath;
        private string PortLocal;
        private string channelName;
        private string clientsCabinetPath;
        

    }


    public class FileManager
    {
        public FileManager(string filePath)
        {
            setFilePath(filePath);
        }


        private void setFilePath(string filePath)
        {
            this.filePath = filePath;
        }

        public void Create()
        {
            if (!File.Exists(this.filePath))
            {
                StreamWriter sw = File.CreateText(this.filePath);
                sw.Close();
            }
            else
            { 
                return;
            }
        }

        public void addLine(string text)
        {
            if (File.Exists(this.filePath))
            {
                try
                {
                    FileStream sw = new FileStream(this.filePath, FileMode.Append);

                    byte[] buffer = Encoding.ASCII.GetBytes(text + "\r\n");
                    sw.Write(buffer, 0, buffer.Length);
                               
                    
                    sw.Close();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public string[] readAll()
        {
            StreamReader sr = new StreamReader(filePath);

            string[] lines = File.ReadAllLines(filePath);

            sr.Close();

            return lines;
        }

        public string readLineByString(string query)
        {
            StreamReader sr = new StreamReader(this.filePath);

            try
            {
                //use de read all function to later select the line that contains the searched query
                string[] fileLines = readAll();
                int fileLenght = fileLines.Length;

                for (int i = 0; i < fileLenght; i++)
                {
                    if (fileLines[i].Contains(query))
                        return fileLines[i];
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return null;
        }

        

        private string filePath;
        
    }
}
