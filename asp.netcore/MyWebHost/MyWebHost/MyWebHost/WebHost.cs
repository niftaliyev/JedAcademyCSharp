using System.Net;

namespace MyWebHost.MyWebHost;

public class WebHost
{
    private int port;
    private HttpListener httpListener;

    public WebHost(int port)
    {
        this.port = port;
    }

    public void Run()
    {
        httpListener = new HttpListener();
        httpListener.Prefixes.Add($"http://localhost:{port}/");
        httpListener.Start();

        Console.WriteLine($"Server started on port {port}");

        while (true)
        {
            var context = httpListener.GetContext();
            Task.Run(() =>
            {
                HandleRequest(context);
            });
        }
    }



    public void HandleRequest(HttpListenerContext context)
    {
        //create middleware's
        LoggerMiddleware loggerMiddleware = new LoggerMiddleware();
        StaticFilesMiddleware staticFilesMiddleware = new StaticFilesMiddleware();


        staticFilesMiddleware.Next = loggerMiddleware.Handle;
        loggerMiddleware.Next = context => context.Response.Close();

        staticFilesMiddleware.Handle(context);
    }



}
