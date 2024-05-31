using ArenaGame.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Dio:Hero
    {
        private double anger;
        private double damageCoef;
       
        public Dio(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
             anger = 0;
            damageCoef = 0.2;
            
        }

        public override double Attack()
        {
            double damage = 0;
            Random r = new Random();
            if (anger > 3) { damageCoef = 1.6;
                //time stop
                if (r.Next(1, 100) < 30) { return base.Attack()*13; } }
                damage = base.Attack();
                double realDamage = damage * damageCoef;
                if (damageCoef < 1) damageCoef += 0.1;
                return realDamage;
            
        }

        public override double Defend(double damage)
        {
            anger++;
            return base.Defend(damage);
        }
    }
}

