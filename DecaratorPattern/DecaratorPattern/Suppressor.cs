namespace Decorator
{
    //ConcreteDecorator
    class Suppressor : Upgrade
    {
        public Suppressor()
        {
            Accuracy = 5;
            Damage = -1;
        }
    }
}