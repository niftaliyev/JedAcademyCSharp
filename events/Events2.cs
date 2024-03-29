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
    //delegate void CatHungryDelegate(Cat cat);

    class HungryCatEventArgs : EventArgs
    {
        public DateTime Date { get; set; }
    }

    class Cat
    {
        private int hunger;

        public Cat(string name, float weight)
        {
            Name = name;
            Weight = weight;
            Hunger = 0;
        }

        public string Name { get; set; }
        public float Weight { get; set; }
        public int Hunger 
        { 
            get => hunger;
            set
            {
                hunger = value;
                if (hunger >= 100)
                {
                    Hungry?.Invoke(this, new HungryCatEventArgs { Date = DateTime.Now });
                }
            }
        }

        public void Eat(float foodKg)
        {
            Weight += foodKg;
            Hunger = 0;
        }

        public event EventHandler<HungryCatEventArgs> Hungry;
    }

    class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void FeedCat(object sender, HungryCatEventArgs e)
        {   
            if (sender is Cat cat)
            {
                Console.WriteLine($"{cat.Name} is hungry at {e.Date}. Weight: {cat.Weight}");
                if (cat.Weight < 5)
                    cat.Eat(1);
                else
                    cat.Eat(0.2f);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Mestan", 2);
            Person person1 = new Person("Vahid");
            Person person2 = new Person("Sabit");

            cat.Hungry += person1.FeedCat;
            cat.Hungry += person2.FeedCat;

            while (true)
            {
                Thread.Sleep(20);
                cat.Hunger++;
                //if (cat.Hunger >= 100)
                //{
                //    person1.FeedCat(cat);
                //    person2.FeedCat(cat);
                //}
            }
        }
    }
}
