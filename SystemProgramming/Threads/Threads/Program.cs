using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;


//test
public class Program
{
    public static void Main()
    {
        //Console.WriteLine("Start");

        //Thread thread = new Thread(() =>
        //{
        //    Thread.Sleep(5000);
        //    Console.WriteLine("Hello");
        //});
        //thread.Start();
        //thread.IsBackground = false;
        //Console.WriteLine("End");
        //Console.ReadKey();

        //new Thread(() =>
        //{
        //    Thread.Sleep(5000);
        //    Console.WriteLine("Hello");
        //}).Start();

        //Console.WriteLine("Start");
        //Thread thread = new Thread(CountWords);
        //thread.Start(@"D:\JedAcademyCSharp\Threads\Threads\text.txt");
        //Console.WriteLine("End");

        //Console.WriteLine("Start");
        //Task task = new Task(() =>
        //{
        //    var filename = @"D:\JedAcademyCSharp\Threads\Threads\text.txt";
        //    var text = File.ReadAllText(filename);
        //    var words = text.Split(' ');
        //    Console.WriteLine(words.Length);
        //});
        //task.Start();
        //Console.WriteLine("End");
        //Console.ReadKey();


        //Console.WriteLine("Start");
        //Task.Run(() => 
        //{
        //    var filename = @"D:\JedAcademyCSharp\Threads\Threads\text.txt";
        //    var text = File.ReadAllText(filename);
        //    var words = text.Split(' ');
        //    Console.WriteLine(words.Length);
        //});
        //Loop();
        //Console.WriteLine("Start");
        //var timer = new Timer(x =>
        //{
        //    Console.WriteLine("Hi");
        //},null,0,1000);
        //Console.WriteLine("End");
        //Console.ReadKey();  

        //Console.WriteLine("Start");
        //Task.Run(() =>
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("Hi");
        //        Thread.Sleep(1000);
        //    }
        //});
        //Console.ReadKey();

        Console.WriteLine("Start");


            Task.Run(() =>
            {
                try
                {
                    int x = 0;
                    Console.WriteLine(5 / x);
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            });
 
        Console.WriteLine("End");
        //Console.ReadKey();
    }

    static void Func()
    {
        Console.WriteLine("Test Thread..");
    }

    static void CountWords(object? data)
    {
        var filename = data as string;
        var text = File.ReadAllText(filename);
        var words = text.Split(' ');
        Console.WriteLine(words.Length);
    }

    static void Loop()
    {
        int x = 0;
        while (true)
        {
            x++;
            Console.WriteLine(x);
            Thread.Sleep(1000);
        }
    }
}