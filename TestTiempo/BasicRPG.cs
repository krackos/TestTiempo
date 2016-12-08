using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTiempo.Characters;

namespace TestTiempo
{
    class BasicRPG
    {
        private List<Character> lstCharacters;
        public int FightDamage { get; set; }
        public BasicRPG() {
            lstCharacters = new List<Character>()
            {
                new Hero() { Name= "Heroe 1"},
                new Moster() { Name="Monster 1"},
                new Moster() { Name="Monster 2"}
            };
            FightDamage = 3000;
        }

        public void PrintStatus() {
            GetCharacter((character) => { System.Console.WriteLine(character.Status()); });
        }

        public void HeroJump() {
            GetCharacter((character) => {
                if (character is Hero) ((Hero)character).Jump();
            });
        }

        public void UseReviveItem() {
            GetCharacter((character) =>
            {
                if (character is Hero)
                    ((Hero)character).PhoenixFleather();
                else
                    ((Moster)character).Graveyard();
            });
        }

        public void RageOfGod() {
            GetCharacter((character) => { character.TakeDamage(FightDamage); });
        }

        public void HeroFight() {
            int power = 0;
            GetCharacter((character) => { if (character is Hero) power += character.AttackPower; });
            
            GetCharacter((character) => {
                if (character is Moster)
                    character.TakeDamage(power);
            }); 
        }

        public void AddCharacter(Character character) {
            lstCharacters.Add(character);
            System.Console.WriteLine("{0} joins to the Fight.", character.Name);
        }

        private void GetCharacter(Action<Character> characterAction ) {
            foreach (var character in lstCharacters)
            {
                if (characterAction != null)
                    characterAction(character);
            }
        }
    }
}
