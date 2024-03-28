namespace ClassLibrary;

public class Dog : Animal
{
    public int Weight { get; set; }
    public Dog(string name, int age, int weight) : base(name, age)
    {

        Weight = weight;

    }
    public override string Say()
    {
        return "HavHav";
    }

    public override void Info()
    {
        base.Info();
        Console.WriteLine($"Weight: {Weight}");

    }
}
