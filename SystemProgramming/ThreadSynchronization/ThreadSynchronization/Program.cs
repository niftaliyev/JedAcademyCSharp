public class Program
{
    //test
    interface Test
    {
        public void Foo();
        public int Name { get; set; }
    }
    public static void Main()
    {
        int x = 0;
        object locker = new object();
        Semaphore semaphore = new Semaphore(1,1);
        Mutex mutex = new Mutex();
        var task1 = new Task(() =>
        {
            for (int i = 0; i < 1000000; i++)
            {
                //Monitor.Enter(locker);
                //x++;
                //Monitor.Exit(locker);
                //lock (locker)
                //{
                //    x++;
                //}
                semaphore.WaitOne();
                x++;
                semaphore.Release();

                //mutex.WaitOne();
                //x++;
                //mutex.ReleaseMutex();
            }
        });
        var task2 = new Task(() =>
        {
            for (int i = 0; i < 1000000; i++)
            {
                //Monitor.Enter(locker);
                //x++;
                //Monitor.Exit(locker);
                //lock (locker)
                //{
                //    x++;
                //}
                semaphore.WaitOne();
                x++;
                semaphore.Release();

                //mutex.WaitOne();
                //x++;
                //mutex.ReleaseMutex();
            }
        });
        task1.Start();
        task2.Start();
        Task.WaitAll(task1,task2);
        Console.WriteLine(x);
    }
}