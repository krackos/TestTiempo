using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTiempo.Characters;

namespace TestTiempo
{
    class Program
    {
        public static void Main(string[] args)
        {
            BasicRPG rpgGame = new BasicRPG();

            #region From the RPG Test
            rpgGame.PrintStatus();
            System.Console.WriteLine();
            rpgGame.RageOfGod();
            rpgGame.PrintStatus();
            System.Console.ReadLine();
            #endregion

            #region Other Story line
            System.Console.WriteLine("The hero is wearing dead ring (auto call a phoenix feather from your bag).");
            rpgGame.UseReviveItem();
            System.Console.WriteLine();

            rpgGame.PrintStatus();
            System.Console.WriteLine("Hero uses jump skill.");
            rpgGame.HeroJump();
            System.Console.WriteLine("God attacks again.");
            rpgGame.RageOfGod();
            System.Console.WriteLine();
            rpgGame.PrintStatus();
            System.Console.ReadLine();

            System.Console.WriteLine("But the Hero is from other religion");
            System.Console.WriteLine("So God has called Graveyard to revive the monsters");
            rpgGame.UseReviveItem();
            //Someone joins to the fight
            Hero Elf = new Hero(3100);
            Elf.Name = "Hero 2";
            rpgGame.AddCharacter(Elf);
            System.Console.WriteLine("Cross Attack!!");
            rpgGame.HeroFight();
            rpgGame.PrintStatus();
            System.Console.WriteLine("God gets tired. He lefts the heroes cross the door.");
            System.Console.ReadLine();
            #endregion
        }

    }
}
