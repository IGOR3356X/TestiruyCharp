using System;
using System.Collections.Generic;

namespace Stepik
{
    internal class Programm
    {
        static void Main()
        {
            PlayerInfo GoodGame = new PlayerInfo();
            PlayerInfo[] BayBay = { new PlayerInfo("Тайлер Дырден", 100, 50, 5), new PlayerInfo("Тайлер Дырден2", 50, 20, 2) };
            for (int i = 0; i < BayBay.Length; i++)
            {
                BayBay[i].ConsoleBitch();
            }
        }
    }
}
