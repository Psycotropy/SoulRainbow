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

            if (context.Request.RawUrl.Contains("/index"))
            {
                //reques for the fisical location of the virtual folder requested
                this.responseString = locateRequestedFile(context.Request.RawUrl);
                this.file = "E:/Tools/soulRainbow/servers/SoulRainbow/SoulRainbow/www/routing.txt";
                context.Response.ContentType = "application/xml";
                //Enables CORS to be able to recive GET to transfer XML files
                //TODO: when we have a domain change '*' to 'www.domain.com'
                context.Response.AppendHeader("Access-Control-Allow-Origin", "*");
 
                
                //converts to ASCII 
                byte[] buffer = Encoding.ASCII.GetBytes(this.responseString);
                context.Response.ContentLength64 = buffer.Length;

                //send response content to the stream
                Stream output = context.Response.OutputStream;
                output.Write(buffer, 0, buffer.Length);
            }
            else
            {
                //in case if the url dont include the virtual directory root folder redirects by default to them 
                context.Response.Redirect(@"http://192.168.1.229:5555/index");
                context.Response.Close();

            }

        } 

        //this method add the news clients in queque form to clientsIdentity.txt
        //TODO: make a method to dump this file over Active Connections Panel 
        private void userIdentity(object identity)
        {
            FileManager manager = new FileManager("clientsIdentity.txt");
            manager.Create();
            manager.addLine(identity.ToString());
        }

        //this method provides the fisical directory equivalent of the virtual directory using routing.txt like index
        private string locateRequestedFile(string url)
        {
            FileManager manager = new FileManager("E:/Tools/soulRainbow/servers/SoulRainbow/SoulRainbow/www/routing.txt");
            //read the requested file
            string[] fileReading = manager.readAll();
            string requestedDirectory;
            string responseString;
            //go throught the file searching for the fisical directory equivalent
            for (int i = 0; i < fileReading.Length; i++)
            {
                if (fileReading[i].Contains(url))
                {
                    //if finds a match separate in two by a coma (this is the format of routing.txt {\virtualdir\etc\, c:\windows\www\etc..})
                    string[] foo = fileReading[i].Split(',');
                    //get the fisical path
                    requestedDirectory = foo[1];
                    manager = new FileManager(requestedDirectory);
                    //reads all the file what will be displayed like html, xml, txt, etc..
                    fileReading = manager.readAll();
                    //joins " " character to converts to string the read file
                    //TODO: search a best method to do same
                    responseString = string.Join(" ", fileReading);
                    return responseString;
                }
            }
            //in case that not find coincidences for virtual directory in fisical return 404 like response string
            return "404";
        }

        private HttpListener listener;
        private string response;
        private string responseString;
        private string file;
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
