using Events2;

public class Program
{
    public delegate void FoodEvent(Animal text);
    public static void Main()
    {
        List<Animal> animals = new List<Animal>();
        Animal mestan = new Cat("Mestan",10,100);
        Animal tom = new Cat("Tom",8,100);
        Animal toplan = new Dog("Toplan", 15,100);
        animals.Add(mestan);
        animals.Add(tom);
        animals.Add(toplan);


        Person person = new Person("Anur");
        Person person2 = new Person("MirCefer");

        foreach (var animal in animals)
        {
            if (animal is Cat cat)
            {
                animal.foodEvent += person.FeedAnimal;
            }
            else if (animal is Dog dog)
            {
                animal.foodEvent += person2.FeedAnimal;

            }
        }


        while (true)
        {
            foreach (var animal in animals)
            {
                animal.Hunger += 10;
            }
            Thread.Sleep(1000);
            Console.WriteLine();
        }

       
    }
}