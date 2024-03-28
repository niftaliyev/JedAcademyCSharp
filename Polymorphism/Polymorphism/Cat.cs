namespace Polymorphism;

public class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }

    //public override string Info()
    //{
    //    return $"{Name} say myaw";
    //}

    public void Jump()
    {
        Console.WriteLine($"{Name} jumped");
    }

    public override void Say()
    {
        Console.WriteLine($"{Name} Mewww");
    }
}
