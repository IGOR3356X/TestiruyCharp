using System;

namespace Stepik
{
    internal class Fighting
    {

    }
    class Basestats
    {
        public int HP { get;protected set; }
        public int Armor { get; protected set; }
        public int Damage { get; protected set; }
        public string Name { get; protected set; }

        public Basestats(int hp, int armor, int damage, string name)
        {
            HP = hp;
            Armor = armor;
            Damage = damage;
            Name = name;
        }

        public void TakeDamage(int damage)
        {
            int BlockDMG = Armor - damage; // Блок урона = 50 - 75 = -25
            if (BlockDMG <= 0)
            {
                Armor = 0;
                HP -= Math.Abs(BlockDMG);
                Console.WriteLine($"Броня сломана урона получено {Math.Abs(BlockDMG)}");
            }
            else
            {
                Armor -= BlockDMG;
            }
        }
    }
    class Knight : Basestats
    {
        public Knight() : base(100, 50, 15, "Рыцарь") { }
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
                Console.WriteLine($"Текущее статы Рыцаря: {HP}, {Armor}");
        }
    }
    class Caster : Basestats
    {
        public Caster() : base(70, 25, 30, "Кастер") { }

        public void DamageBaff()
        {
            Damage += 10;
            Console.WriteLine($"Кастер использовал усиление заклинаний его урон = {Damage}");
        }
        public void ShowInfo()
        {
            if (HP < 0)
                Console.WriteLine("Кастер умер");
            else
                Console.WriteLine($"Текущее статы Кастера: {HP}, {Armor}");
        }
    }
    class GameOptions
    {
        public void FirstHod()
        {
            Random rand = new Random();
            if (rand.Next(0,2) > 0)
                Console.WriteLine($"Первым ходит Кастер");
            else
                Console.WriteLine("Первым ходит Рыцарь");
        }
    }
}
