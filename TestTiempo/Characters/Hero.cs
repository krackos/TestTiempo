using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTiempo.Characters
{
    public class Hero : Character
    {
        public Hero() {
            HealthPoints = 2000;
        }

        public Hero(int attack) : base(attack) {
            HealthPoints = 2000;
        }

        public void PhoenixFleather() {
            Revive(2000);
        }

        public void Jump() {
            HealthPoints *= 2;
            System.Console.WriteLine("{0} Health increase to: {1}", Name,HealthPoints);
        }
    }
}
