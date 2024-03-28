using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Decorator
{

    class Program
    { 
        static void Main(string[] args)
        {
            Weapon weapon = new M16();
            weapon.Info();

            Upgrade upgrade = new Scope(); //1 scope +15  Accuracy
            weapon = upgrade.SetUpgrade(weapon);
            weapon.Info();

            Upgrade upgrade2 = new Suppressor(); // Accuracy = 5; Damage = -1;
            weapon = upgrade2.SetUpgrade(weapon);
            weapon.Info();
        }
    }
}