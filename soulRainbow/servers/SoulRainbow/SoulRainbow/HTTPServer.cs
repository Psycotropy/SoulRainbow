using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;

namespace SoulRainbow
{
    class HTTPServer
    {
        public HTTPServer()
        {
            setProperties();
        }

        private void setProperties()
        {
            this.listener = new HttpListener();
            this.clientsCabinetPath = "";
        }

        public void start()
        {
            listener.Prefixes.Add("*192.168.1.229");
            listener.Start();
            listener.BeginGetContext(onCallback, null);
        }

        private void onCallback(IAsyncResult ar)
        {
            HttpListenerContext context = listener.EndGetContext(ar);
            userIdentity(context.User);
            HttpListenerResponse response = context.Response;
            
            

        } 

        private void userIdentity(object identity)
        {
            FileManager manager = new FileManager("clientsIdentity.txt");
            manager.Create();

            manager.addLine(identity.ToString());

        }



        private HttpListener listener;
        private string clientsCabinetPath;
    }
}
