using System;
using System.Text;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;


namespace SoulRainbow
{
    public class HTTPServer
    {
        public HTTPServer()
        {
            setProperties();
        }
        
        
        //public void setItem(string)

        private void setProperties()
        {
            this.listener = new HttpListener();
            this.reader = new FileManager("config.conf");
            this.XMLconnections = new List<string>();
            
        }

        public List<string> getXmlListConnections()
        {
            return this.XMLconnections;
        }

        //this function establish the response body of the request(XML, txt, messaging, etc...)
        
        public void start()
        {

            string portLine = reader.readLineByString("XHR");
            string[] portLineSplit = portLine.Split(',');
            string port = portLineSplit[1];

            
            //setting prefixes for http
            listener.Prefixes.Add("http://*:" + port + "/");
            //listener.Prefixes.Add("https://*:8443/");
            listener.Start();
            listener.BeginGetContext(onCallback, null);
            

        }

        private void onCallback(IAsyncResult ar)
        {
            HttpListenerContext context = listener.EndGetContext(ar);
            

            //This line prevents server teardowns
            listener.BeginGetContext(onCallback, null);

            if (context.Request.RawUrl.Contains("/index"))
            {
                //reques for the fisical location of the virtual folder requested
                this.responseString = locateRequestedFile(context.Request.RawUrl);
                this.routingFile = "E:/github/RetainingControl/soulRainbow/SoulRainbow/www/routing.txt";
                //context.Response.ContentType = "application/xml";
                //Enables CORS to be able to recive GET to transfer XML files
                //TODO: when we have a domain change '*' to 'www.domain.com'
                context.Response.AppendHeader("Access-Control-Allow-Origin", "*");
                
                MessageBox.Show(context.Request.Headers.ToString());
                //send the request to be displayed in the program connections list

                var data = new ProcessEventArgs();
                data.clientIP = context.Request.UserHostAddress;
                data.additionalInfo = context.Request.Headers.Get("Access-Control-Request-Headers");
                OnClientRecieved(data);

                //AsyncHelpers helpers = new AsyncHelpers();
                //helpers.requestWriter(context);
 
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
                context.Response.Redirect(@"https://192.168.1.229:8443/index");
                context.Response.Close();
                
            }

        } 

        protected virtual void OnClientRecieved(ProcessEventArgs e)
        {
            clientRecieved?.Invoke(this, e);
        }

        //this method add the news clients in queque form to clientsIdentity.txt
        //TODO: make a method to dump this file over Active Connections Panel 
 

        //this method provides the fisical directory equivalent of the virtual directory using routing.txt like index
        private string locateRequestedFile(string url)
        {
            FileManager manager = new FileManager("E:/github/RetainingControl/soulRainbow/SoulRainbow/www/routing.txt");
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
        private FileManager reader;
        private string responseString;
        private string routingFile;
        private List<string> XMLconnections;

        //Event Handlers
        public event EventHandler<ProcessEventArgs> clientRecieved;

    }

    public class ProcessEventArgs : EventArgs
    {
        public string clientIP { get; set; }
        public string additionalInfo { get; set; }
    }

    class AsyncHelpers
    {
        
         public void requestWriter(HttpListenerContext request)
        {
            MessageBox.Show("La peticion es: " + request.Request.Headers.ToString());

            string accessControlHeader = request.Request.Headers.Get("Access-Control-Request-Headers");
            //MessageBox.Show(accessControlHeader);

            if (accessControlHeader.Contains("soulrainbow"))
            {
                string[] accessControlHeaderSplited = accessControlHeader.Split('|');
                string channelType = accessControlHeaderSplited[1];

                switch (channelType)
                {
                    case "XML":
                        XMLrequestWriter(request);
                        break;
                    default:
                        return;
                }
            }

        }

        private void XMLrequestWriter(HttpListenerContext request)
        {
            Directory.CreateDirectory("ClientsInformation");
            FileManager managerXML = new FileManager("ClientsInformation\\connectionsListXML.txt");
            managerXML.Create();

            string HostHeader = request.Request.UserHostAddress;

            //XMLconnections.Add("new connection" + HostHeader);


            string[] connectionListXMl = { };

        }
    }


    public class XMLServer : HTTPServer
    {
        public XMLServer()
        {

        }


        public List<string> getXMLconnections()
        {
            return getXmlListConnections();
        }

        public void startServerXML()
        {
            start();
        }
    }
    public class TrikiServer : HTTPServer
    {
        public void startServerTriki()
        {
            start();
        }
    }
}
