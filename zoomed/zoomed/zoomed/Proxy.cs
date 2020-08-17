using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;

namespace zoomed
{
    class Proxy
    {
        public Proxy()
        {

        }

        HttpListener listener = new HttpListener();

        public void startProxy()
        {
            
            listener.Prefixes.Add("http://*:8080/");
            listener.Start();
            //MessageBox.Show("listening");
            listener.BeginGetContext(OnContext, null);

            

            // Note: The GetContext method blocks while waiting for a request.
            //HttpListenerContext context = listener.GetContext();
            //HttpListenerRequest request = context.Request;
            //sendRequest(request.Headers);

        }

        private void OnContext(IAsyncResult ar)
        {
            var context = listener.EndGetContext(ar);
            listener.BeginGetContext(OnContext, null);

            string responseString = "<HTML><BODY> you has been hacked</BODY></HTML>";
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
            context.Response.ContentLength64 = buffer.Length;
            System.IO.Stream output = 
            context.Response.OutputStream;
            output.Write(buffer, 0, buffer.Length);
        }

        private void sendRequest(object request)
        {
            string toString = request.ToString();

            sendMail send = new sendMail();
            send.send(toString);
        }
        
    }
}
