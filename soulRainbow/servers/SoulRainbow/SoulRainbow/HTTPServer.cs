using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace SoulRainbow
{
    public class HTTPServer
    {
        public HTTPServer()
        {
            setProperties();
        }

        private void setProperties()
        {
            this.listener = new HttpListener();
        }

        //this function establish the response body of the request(XML, txt, messaging, etc...)
        private void SetResponseContent(string response)
        {
            this.response = response;
        }

        public void start()
        {
            listener.Prefixes.Add("http://*:5555/");
            listener.Start();
            listener.BeginGetContext(onCallback, null);
        }

        private void onCallback(IAsyncResult ar)
        {
            HttpListenerContext context = listener.EndGetContext(ar);
            userIdentity(context.Request.RemoteEndPoint);

            //This line prevents server teardowns
            listener.BeginGetContext(onCallback, null);

            context.Response.Redirect(@"http://192.168.1.229/index");


            string responseString = "Conexion Exitosa";
            byte[] buffer = Encoding.ASCII.GetBytes(responseString);
            context.Response.ContentLength64 = buffer.Length;

            Stream output = context.Response.OutputStream;
            output.Write(buffer, 0, buffer.Length);

        } 

        private void userIdentity(object identity)
        {
            FileManager manager = new FileManager("clientsIdentity.txt");
            manager.Create();
            manager.addLine(identity.ToString());
        }

        private HttpListener listener;
        private string response;
        private string defaultDirectory;

        private void locateRequestedDirectory()
        {

        }
    }

    public class XMLServer : HTTPServer
    {
        public XMLServer()
        {
            
        }

        public void setXMLFilePath(string path)
        {
            this.XMLFilePath = path;
        }

        public void startServerXML()
        {
            start();
        }

        private void loadCommandsXML()
        {
            FileManager manager = new FileManager(XMLFilePath);
            this.XMLFileContent = manager.readAll().ToString();
        }

        private string XMLFileContent;
        private string XMLFilePath;
    }
}
