namespace Polymorphism;

public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
        
    }
    public override string Info()
    {
        return $"{Name} say haw haw";
    }

    public override void Say()
    {
        Console.WriteLine($"{Name} HawHaw");
    }
}
