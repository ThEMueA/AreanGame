using ArenaGame.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Assassin : Hero
    {
        private int ammo = 0;
        public Assassin(string name, double armor, double strenght, IWeapon weapon) : 
            base(name, armor, strenght, weapon)
        {
            if (weapon is Revolver) { ammo = 7; }
        }

        public override double Attack()
        {
            double damage = 0;
            if (base.Weapon is Revolver) { if (ammo > 0) { damage = base.Attack()/0.80; if (ammo == 4) damage = 1; ammo--; } return damage; }
            else
            {
                damage = base.Attack();

                double probability = random.NextDouble();
                if (probability < 0.10)
                {
                    damage *= 3;
                }
                return damage;
            }
        }
    }
}
