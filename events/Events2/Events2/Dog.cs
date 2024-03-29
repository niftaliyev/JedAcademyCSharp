namespace Events2;

public class Dog : Animal
{
    public Dog(string name, int weight, int hunger) : base(name, weight, hunger)
    {
    }

    private int hunger;
    public override int Hunger
    {
        get => hunger;
        set
        {
            hunger = value;
            if (hunger >= 100)
            {
                Console.WriteLine($"{Name} is hungry..");
                foodEvent?.Invoke(this);
            }
        }


    }
    public override event Program.FoodEvent foodEvent;

    public override void Eat(int foodKg)
    {
        Weight += foodKg;
        Hunger = 0;
    }
}
