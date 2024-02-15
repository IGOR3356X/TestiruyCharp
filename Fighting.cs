using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepik
{
    internal class Fighting
    {
        
    }
    class Basestats
    {
        protected int HP;
        protected int Armor;
        protected int Damage;

        public Basestats(int hp, int armor, int damage)
        {
            HP = hp;
            Armor = armor;
            Damage = damage;
        }

        public void TakeDamage(int damage)
        {
            int Defence = Armor - damage;
            if (Defence <= 0)
            {
                HP += Defence;
                Armor = 0;
                Defence -= Defence * 2;
                Console.WriteLine($"Броня сломана, получено урона {Defence}");
            }
            else
            {
                Console.WriteLine("Урон не прошёл");
            }
        }
    }
    class Knight : Basestats
    {
        public Knight() : base(100, 50, 15) { }
        public void AvalonHeal() 
        {
            HP += 20;
            Console.WriteLine($"Рыцарь использовал авалон его текущее ХП = {HP}");
        }
        public void ShowInfo()
        {
            if (HP < 0)
                Console.WriteLine("Рыцарь умер");
            else
                Console.WriteLine($"Текущее зоровье рыцаря: {HP}");
        }
    }
    class Caster : Basestats
    {
        public Caster(): base(70, 25, 30) { }

        public void DamageBaff() 
        {
            Damage += 10;
            Console.WriteLine($"Кастер использовал усиление заклинаний его урон = {Damage}");
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Текущее зоровье кастера {HP}");
        }
    }
}
