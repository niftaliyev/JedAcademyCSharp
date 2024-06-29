using System.Net;

namespace MyWebHost.MyWebHost;

class StaticFilesMiddleware : IMiddleware
{
    public HttpHandler Next { get; set; }

    public void Handle(HttpListenerContext context)
    {
        Console.WriteLine("StaticFilesMiddleware is working");
        Console.WriteLine(context.Request.RawUrl);
        if (Path.HasExtension(context.Request.RawUrl))
        {

            var filename = context.Request.RawUrl.Substring(1);
            try
            {
                if (File.Exists($"wwwroot/{filename}"))
                {
                    var bytes = File.ReadAllBytes($"wwwroot/{filename}");
                    if (bytes.Length > 0)
                    {
                        if (Path.GetExtension(context.Request.RawUrl) == ".html")
                            context.Response.AddHeader("Content-Type", "text/html");

                        else if (Path.GetExtension(context.Request.RawUrl) == ".jpg")
                            context.Response.AddHeader("Content-Type", "image/jpg");

                        context.Response.OutputStream.Write(bytes);

                    }
                }


                else
                {
                    context.Response.AddHeader("Content-Type", "text/html");
                    var bytesNotFound = File.ReadAllBytes("wwwroot/error.html");
                    context.Response.OutputStream.Write(bytesNotFound);

                }

            }

            catch (Exception)
            {

                throw;
            }

            Next?.Invoke(context);
        }
    }
}
