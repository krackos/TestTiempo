using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTiempo.Characters
{
    public class Character : ICharacters1
    {
        private bool isDead = false;
        private int ATP = 2000;
        public string Name { get; set; }

        public int HealthPoints { get; set; }
        public int AttackPower {
            get { return ATP; }
        }
        public Character() {}
        public Character(int attack) {
            ATP = attack;
        }
        
        public void TakeDamage(int damage)
        {
            if (!isDead && HealthPoints > damage)
                HealthPoints -= damage;
            else
                isDead = true;
        }
        public string Status()
        {
            //return (isDead ? Name + " is Dead" : "Name: " + Name + ", Health: " + HealthPoints);
            // same from above but this is readable
            if (isDead)
                return Name + " is Dead";
            else
                return "Name: " + Name + ", Health: " + HealthPoints;
        }

        protected void Revive(int health) {
            if (isDead) {
                HealthPoints = health;
                isDead = false;
                System.Console.WriteLine("{0} revive!!", Name);
            }
        }
    }
}
