namespace ClassLibrary;

public class Cat : Animal
{
    public int Lives { get; set; }
    public Cat(int lives)
    {
        Lives = lives;
    }
    public Cat(string name, int age, int lives) : base(name,age)
    {
        Lives = lives;
    }
    public override string Say()
    {
        return "MewMew";
    }
    public override void Info()
    {
        base.Info();
        Console.WriteLine($"Lives: {Lives}");
    }
}
