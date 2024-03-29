using static Program;

namespace Events2;

public abstract class Animal
{
    public Animal(string name, int weight, int hunger)
    {
        Name = name;
        Weight = weight;
        this.Hunger = hunger;
    }
    public string Name { get; set; }
    public int Weight { get; set; }
    public abstract int Hunger { get; set; }
    public abstract void Eat(int foodKg);
    public abstract event FoodEvent foodEvent;

}
