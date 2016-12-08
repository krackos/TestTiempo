using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTiempo.Characters 
{
    public class Moster : Character
    {
        public Moster() {
            HealthPoints = 5000;
        }
        public Moster(int attack) : base(attack) {
            HealthPoints = 5000;
        }
        public void Graveyard() {
            Revive(5000);
            
        }
    }
}
