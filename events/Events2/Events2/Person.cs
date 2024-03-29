namespace Events2;

public class Person
{
    public Person(string name)
    {
        Name = name;
    }

    public string Name { get; set; }

    public void FeedAnimal(Animal animal)
    {
        Thread.Sleep(1000);
        Console.WriteLine($"{Name} feed {animal.Name}");
        animal.Eat(0);
    }
}
