namespace Polymorphism;

public abstract class Animal
{
    public Animal(string name = "Empty")
    {
        Name = name;
    }

    public string Name { get; set; }


    public virtual string Info()
    {
        return "test";
    }

    public abstract void Say();
}
