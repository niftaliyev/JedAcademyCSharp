public static class Program
{
    public static void Main()
    {
        Start();
        Loop();
    }

    static async void Start()
    {
        Console.WriteLine("Start in method");
        var result = await GetResultAsync();
        Console.WriteLine(result);
        Console.WriteLine("Finish in method");



        //Console.WriteLine("Start");
        //var result = GetResultSync();
        //Console.WriteLine(result);
        //Console.WriteLine("Finish");


        //Console.WriteLine("Start");
        //GetResultThread();
        //Console.WriteLine("Finish");

        //Console.WriteLine("Start");
        //GetResultTask();
        //Console.WriteLine("Finish");


    }

    static Task<int> GetResultAsync()
    {
        return Task.Run(() => 
        {
            Thread.Sleep(2500);
            var result = 42;
            return result;
        });
    }


    static void GetResultTask()
    {
        Task.Run(() => 
        {
            Thread.Sleep(2500);
            var result = 42;
            Console.WriteLine($"result is {result}");
        });
    }

    static void GetResultThread()
    {
        Thread thread = new Thread(() =>
        {
            Thread.Sleep(2500);
            var result = 42;
            Console.WriteLine($"result is {result}");
        });
        thread.Start();
    }

    static int GetResultSync()
    {
        Thread.Sleep(2500);
        var result = 42;
        return result;
    }





    public static void Loop()
    {
        int x = 0;
        while (true)
        {
            Console.WriteLine(++x);
            Thread.Sleep(600);
        }
    }
}