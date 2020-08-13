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
            filePath = "config.conf";
            
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



        public void createConfFile()
        {
            

            if (File.Exists(filePath))
            {
                //MessageBox.Show("Existe");
                addConfigFileCont();
            }
            else
            {
                StreamWriter sw = File.CreateText(filePath);
                addConfigFileCont();
            }
        }

        private void addConfigFileCont()
        {
            try{
                StreamWriter sw = new StreamWriter(filePath);

                sw.WriteLine("{0}", PortLocal);

                sw.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Message: ", e.ToString());
            }
            
        }

        //use flag system to read especific part of the config line
        public string readConfigFile()
        {

            //open and charging of config line
            StreamReader sr = new StreamReader(filePath);

            string line = sr.ReadLine();

            sr.Close();

           // MessageBox.Show("There has been a problem with the configuration line " + line);

            

            return line;
        }

        string filePath;

        string PortLocal;
        

    }
}
