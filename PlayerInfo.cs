using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepik
{
    public class PlayerInfo
    {
        public int HP;
        public int Armor;
        public int Slots;
        public string Name;

        public PlayerInfo(string name,int hp, int armor, int slots)
        {
            Name = name;
            HP = hp;
            Armor = armor;
            Slots = slots;
        }
        public PlayerInfo() 
        {

        }

        public void ConsoleBitch()
        {
            Console.WriteLine($"Ваше имя = {Name} Ваше ХП равно = {HP} Ваша броня = {Armor} Кол-во слотов в инвентаре = {Slots}");
        }
    }
    
    public class GG
    {
    }
}
