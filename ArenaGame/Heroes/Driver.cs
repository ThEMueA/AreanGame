using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Driver:Hero
    {
        public int beers;
        public double hitC;
    
        public Driver(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
           beers = 8;
            hitC = 0.01;
          
          
        }
        public override double Attack()
        {
            double dmg = 0;
            Random r = new Random();
            if (beers > 0)
            {
                beers--;
                hitC += 0.07;

                if (r.Next(7, 100) < hitC * 100) { dmg = base.Attack(); }
            }
            else beers--;
            return dmg;
        }
           
           public override double Defend(double damage)
        {
            Random r = new Random();
            if (r.Next(1, 10) < 4) { beers--; }

            return base.Defend(damage);
        }
    
    }
}
