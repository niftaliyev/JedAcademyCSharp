using Events;
using System.Collections.ObjectModel;
using static Program;
using System.Collections.Specialized;
public class Program
{
    public delegate void Print(string text);
    public delegate void ChangeMyList(int number);
    public static void Main()
    {
        //Functions functions = new Functions();
        //Timer timer = new Timer();
        //timer.timerFinish += functions.PrintRed;
        //timer.timerFinish += functions.PrintUpper;
        //timer.Start();
        //timer.timerFinish -= functions.PrintRed;
        //timer.timerFinish += functions.SayHello;
        //timer.Start();

        //MyList myList = new MyList();

        //myList.changeMyList += (x) => Console.WriteLine($"add {x}");
        //while (true)
        //{
     
        //    Console.Write("Enter number: ");
        //    int number = int.Parse(Console.ReadLine());
        //    myList.Add(number);

        //    Console.WriteLine("press esc to exit");
        //    if (Console.ReadKey(true).Key == ConsoleKey.Escape)
        //        break;

        //}
        //Console.WriteLine();
        //myList.PrinArray();

        ObservableCollection<int> numbers = new ObservableCollection<int>();
        numbers.CollectionChanged += Numbers_CollectionChanged;
        numbers.CollectionChanged += Numbers_CollectionChanged2;

        while (true)
        {

            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            numbers.Add(number);

            Console.WriteLine("press esc to exit");
            if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                break;

        }
        numbers.Clear();

    }

    private static void Numbers_CollectionChanged2(object? sender, NotifyCollectionChangedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private static void Numbers_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {
        if (e.Action == NotifyCollectionChangedAction.Add)
        {
            foreach (var item in e.NewItems)
            {
                Console.WriteLine(item + " Added");
                File.AppendAllText("numbers.txt",item.ToString());
            }
        }
        else if(e.Action == NotifyCollectionChangedAction.Reset)
        {
            Console.WriteLine("List was cleared!!!");
        }
    }
}

public class MyList
{
    public event ChangeMyList changeMyList;
    private List<int> numbers = new List<int>();

    public void Add(int number)
    {

        numbers.Add(number);
        changeMyList?.Invoke(number);
    }

    public void PrinArray()
    {
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }
    }
}

public class Timer
{
    public event Print timerFinish;

    public void Start()
    {
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
        timerFinish?.Invoke("Done!");
    }
}