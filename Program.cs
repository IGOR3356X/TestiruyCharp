using System;
using System.Collections.Generic;

namespace Stepik
{
    internal class Programm
    {
        static void Main()
        {
            //PlayerInfo GoodGame = new PlayerInfo();
            //PlayerInfo[] BayBay = { new PlayerInfo("Тайлер Дырден", 100, 50, 5), new PlayerInfo("Тайлер Дырден2", 50, 20, 2) };
            //for (int i = 0; i < BayBay.Length; i++)
            //{
            //    BayBay[i].ConsoleBitch();
            //}
            Knight warrior1 = new Knight();
            Caster warrior2 = new Caster();
            GameOptions options = new GameOptions();
            warrior1.ShowInfo();
            warrior2.ShowInfo();
            options.FirstHod();
            while (true)
            {
                ConsoleKeyInfo AbylityK = Console.ReadKey();
                ConsoleKeyInfo AbylityC = Console.ReadKey();
                ConsoleKeyInfo KnightAtk = Console.ReadKey();
                ConsoleKeyInfo CasterAtk = Console.ReadKey();

                if (KnightAtk.Key == ConsoleKey.W)
                    warrior2.TakeDamage(warrior1.Damage);
                if (CasterAtk.Key == ConsoleKey.E)
                    warrior1.TakeDamage(warrior2.Damage);
                if (AbylityK.Key == ConsoleKey.A)
                    warrior1.AvalonHeal();
                if (AbylityC.Key == ConsoleKey.D)
                    warrior2.DamageBaff();

                Console.WriteLine("Рыцарь:");
                warrior1.ShowInfo();
                Console.WriteLine("Кастер:");
                warrior2.ShowInfo();
            }
        }
    }
}
