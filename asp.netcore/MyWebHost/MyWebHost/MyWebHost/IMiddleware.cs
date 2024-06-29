using System.Net;

namespace MyWebHost.MyWebHost
{
    delegate void HttpHandler(HttpListenerContext context);

    interface IMiddleware
    {
        public HttpHandler Next { get; set; }
        public void Handle(HttpListenerContext context);
    }
}


