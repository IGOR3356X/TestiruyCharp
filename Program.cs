using System;
using System.Collections.Generic;

namespace Stepik
{
    internal class Programm
    {
        static void Main()
        {
            Console.WriteLine("Добро пожалосать в КОНСОЛЬ РПГ!");

            Knight warrior1 = new Knight();
            Caster warrior2 = new Caster();
            GameOptions options = new GameOptions();
            warrior1.ShowInfo();
            warrior2.ShowInfo();
            options.FirstHod();
            while (true)
            {
                var KeyInput = Console.ReadKey().Key;
                
                Console.WriteLine();

                if (KeyInput == ConsoleKey.W)
                {
                    Console.WriteLine("Рыцарь наносит удар");
                    warrior2.TakeDamage(warrior1.Damage);
                }
                if (KeyInput == ConsoleKey.E)
                {
                    Console.WriteLine("Кастер наносит удар");
                    warrior1.TakeDamage(warrior2.Damage);

                }
                if (KeyInput == ConsoleKey.A)
                    warrior1.AvalonHeal();
                if (KeyInput == ConsoleKey.D)
                    warrior2.DamageBaff();

                warrior1.ShowInfo();
                warrior2.ShowInfo();

                if ((warrior1.HP <= 0) || (warrior2.HP <= 0))
                    break;
            }
            Console.WriteLine("Игры кончились!!!!");
            Console.ReadKey();
        }
    }
}
    //ConsoleKeyInfo AbylityK = Console.ReadKey();
    //ConsoleKeyInfo AbylityC = Console.ReadKey();
    //ConsoleKeyInfo KnightAtk = Console.ReadKey();
    //ConsoleKeyInfo CasterAtk = Console.ReadKey();
    //switch(KeyInput.Key)
    //{
    //    case ConsoleKey.Q:
    //        break;
    //}
    //PlayerInfo GoodGame = new PlayerInfo();
    //PlayerInfo[] BayBay = { new PlayerInfo("Тайлер Дырден", 100, 50, 5), new PlayerInfo("Тайлер Дырден2", 50, 20, 2) };
    //for (int i = 0; i < BayBay.Length; i++)
    //{
    //    BayBay[i].ConsoleBitch();
    //}
