namespace ClassLibrary;

public class Animal : Object
{
    public Animal(string name = "Empty", int age = 0)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; }
    public int Age { get; set; }

    public virtual string Say()
    {
        return "????";
    }

    public virtual void Info()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
    }
}
