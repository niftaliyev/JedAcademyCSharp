public static class Program
{
    public static void Main()
    {
        Singleton.Instance.Data.Add(1);
        Singleton.Instance.Data.Add(2);
        Singleton.Instance.Data.Add(3);
        Singleton.Instance.Data.Add(33);

        foreach (var item in Singleton.Instance.Data)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine(); Console.WriteLine();
        Singleton.Instance.Data.Remove(1);
        Singleton.Instance.Data.Remove(2);
        foreach (var item in Singleton.Instance.Data)
        {
            Console.WriteLine(item);
        }
        //Singleton singleton = new Singleton();
    }


    class Singleton
    {
        static private Singleton instance = null;
        public List<int> Data { get; set; }
        static public Singleton Instance
        {
            get 
            { 
                if (instance == null)
                    instance = new Singleton();

                return instance;
            
            }
        }
        private Singleton()
        {
            Data = new List<int>();
        }

    }
}