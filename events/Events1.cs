//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Xml.Serialization;

namespace ConsoleApp2
{
    delegate void Print(string text);

    class Timer
    {
        //public event Print TimerFinish;

        private event Print timerFinish;
        public event Print TimerFinish
        {
            add
            {
                timerFinish += value;
                Console.WriteLine("New subscriber!");
            }
            remove
            {
                timerFinish -= value;
                Console.WriteLine(":(");
            }
        }

        public void Start(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
            }
            timerFinish?.Invoke("Done!");
        }
    }



    class Program
    {
        static int counter;

        static void Main(string[] args)
        {
            //ObservableCollection<int> numbers = new ObservableCollection<int>();
            //numbers.CollectionChanged += Numbers_CollectionChanged;
            //numbers.CollectionChanged += Numbers_CollectionChanged2;
            //while (true)
            //{
            //    Console.Write("Enter your number: ");
            //    int number = int.Parse(Console.ReadLine());
            //    numbers.Add(number);
            //    Console.WriteLine("Press ESC to exit or any key to continue...");
            //    if (Console.ReadKey(true).Key == ConsoleKey.Escape)
            //        break;
            //}
            //numbers.Clear();
            //Console.WriteLine(counter);






            Timer timer = new Timer();
            timer.TimerFinish += PrintRed;
            timer.TimerFinish += PrintUpper;
            timer.Start(3);
            timer.TimerFinish -= PrintRed;
            timer.Start(3);






            //Test t = new Test();
            //t.TextPrint += PrintRed;
            //t.TextPrint += PrintUpper;
            //t.Timer();
            //t.TextPrint -= PrintRed;
            //t.Timer();



            //Print print = PrintRed;
            //print += PrintUpper;

            //print?.Invoke("Hello!");
        }

        private static void Numbers_CollectionChanged2(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                counter++;
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                counter--;
            }
        }

        private static void Numbers_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (var item in e.NewItems)
                {
                    Console.WriteLine(item + " Added");
                    File.AppendAllText("numbers.txt", item.ToString());
                }
            }
            else if (e.Action == NotifyCollectionChangedAction.Reset)
            {
                Console.WriteLine("List was cleared!");
            }
        }

        static void PrintRed(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void PrintUpper(string text)
        {
            Console.WriteLine(text.ToUpper());
        }
    }
}

