namespace Polymorphism;

public class Leon : Cat
{
    public Leon(string name) : base(name)
    {
    }

    public override string Info()
    {
        return $"{Name} say blllll";
    }


}
