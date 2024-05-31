using ArenaGame.Weapons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Knight: Hero
    {
        private double hitCount;
        private double damageCoef;
        private int ammo = 0;
        public Knight(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
            hitCount = 0;
            damageCoef = 0.6;
         if(weapon is Revolver) { ammo = 7; }
        }

        public override double Attack()
        {
            double damage=0;
            if (base.Weapon is Revolver) { if (ammo > 0) { damage = base.Attack(); if (ammo == 4) damage = 1;ammo--; } return damage; }
            else
            {
                damage = base.Attack();
                double realDamage = damage * damageCoef;
                if (damageCoef < 1) damageCoef += 0.1;
                return realDamage;
            }
        }

        public override double Defend(double damage)
        {
            hitCount++;
            if (hitCount == 3)
            {
                hitCount = 0;
                return 0;
            }
            return base.Defend(damage);
        }
    }
}
