using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Car:IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }
        public Car(string name)
        {
            Name = name;
            AttackDamage = 111111;
            BlockingPower = 21;
        }

    }
}
