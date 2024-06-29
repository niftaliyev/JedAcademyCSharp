using MyWebHost.MyWebHost;
using System.Net;

public class Program
{
    public static void Main()
    {
        var host = new WebHost(80);
        host.Run();
    }

}