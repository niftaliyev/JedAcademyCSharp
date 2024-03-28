using MediatR;

namespace Decorator
{
    //Component
    abstract class Weapon
    {
        public virtual int Accuracy { get; set; }
        public virtual int Damage { get; set; }
        public virtual int Capacity { get; set; }

        public void Info()
        {
            Console.WriteLine($"Accuracy: {Accuracy}");
            Console.WriteLine($"Damage: {Damage}");
            Console.WriteLine($"Capacity: {Capacity}");
            Console.WriteLine();
        }
    }
}