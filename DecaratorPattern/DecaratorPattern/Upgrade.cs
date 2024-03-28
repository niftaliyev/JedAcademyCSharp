namespace Decorator
{
    //Decorator
    abstract class Upgrade : Weapon
    {
        Weapon weapon = null;

        private int accuracy; // +15
        private int damage;
        private int capacity;

        public override int Accuracy
        {
            get => weapon.Accuracy + accuracy;
            set => accuracy = value;
        }

        public override int Damage
        {
            get => weapon.Damage + damage;
            set => damage = value;
        }

        public override int Capacity
        {
            get => weapon.Capacity + capacity;
            set => capacity = value;
        }

        public Weapon SetUpgrade(Weapon weapon)
        {
            this.weapon = weapon;
            return this;
        }

        public Weapon RemoveUpgrade()
        {
            return weapon;
        }
    }
}