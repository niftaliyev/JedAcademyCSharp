using static Program;

namespace Events2;

public class Cat : Animal
{
    private int hunger;

    public Cat(string name, int weight, int hunger) : base(name, weight, hunger)
    {
    }


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

    public override event FoodEvent foodEvent;

    public override void Eat(int foodKg)
    {
        Weight += foodKg;
        Hunger = 0;
    }

}
