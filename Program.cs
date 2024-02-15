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
            while (true)
            {
                Knight warrior1 = new Knight();
                Caster warrior2 = new Caster();

                warrior1.TakeDamage(50);
                warrior2.TakeDamage(50);
                warrior1.ShowInfo();
                warrior2.ShowInfo();

                ConsoleKeyInfo AbylityK = Console.ReadKey();
                ConsoleKeyInfo AbylityC = Console.ReadKey();

                if (AbylityK.Key == ConsoleKey.A)
                    warrior1.AvalonHeal();
                else if (AbylityC.Key == ConsoleKey.D)
                    warrior2.DamageBaff();
            }
        }
    }
}
