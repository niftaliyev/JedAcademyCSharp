using System.Net;

namespace MyWebHost.MyWebHost
{
    class LoggerMiddleware : IMiddleware
    {
        public HttpHandler Next { get; set; }

        public void Handle(HttpListenerContext context)
        {
            Console.WriteLine("LoggerMiddleware is working");
            Console.WriteLine($"{context.Request.RawUrl} {context.Request.HttpMethod} {context.Request.UserHostAddress}");
            Next?.Invoke(context);
        }
    }
}
