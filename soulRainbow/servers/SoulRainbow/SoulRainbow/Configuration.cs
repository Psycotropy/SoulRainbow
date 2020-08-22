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

        public void setConfProperties(string PortLocal)
        {

            if (PortLocalVer(PortLocal) == true)
                this.PortLocal = PortLocal;
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
            FileManager manager = new FileManager(filePath);
            manager.Create();
        }

        public string readPort()
        {
            FileManager manager = new FileManager(filePath);
            return manager.readLineByString(PortLocal);
        }



        private string filePath;
        private string PortLocal;
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
                    StreamWriter sw = new StreamWriter(this.filePath);

                    sw.WriteLine(text);

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
