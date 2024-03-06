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

        public virtual void TakeDamage(int damage)
        {
            int BlockDMG = Armor - damage; // Блок урона = 50 - 75 = -25
            if (BlockDMG <= 0)
            {
                Armor = 0;
                HP -= Math.Abs(BlockDMG);
                Console.WriteLine($"Броня сломана. {Name} получил {Math.Abs(BlockDMG)} урона");
            }
            else
            {
                Armor -= BlockDMG;
                Console.WriteLine($"У {Name} осталось = {Armor} ед брони");
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
        public override void TakeDamage(int damage)
        {
            int BlockDMG = Armor - damage/2; // Блок урона = 50 - 75 = -25
            if (BlockDMG <= 0)
            {
                Armor = 0;
                HP -= Math.Abs(BlockDMG);
                Console.WriteLine($"Броня сломана. {Name} получил {Math.Abs(BlockDMG)} урона");
            }
            else
            {
                Armor -= BlockDMG;
                Console.WriteLine($"У {Name} осталось = {Armor} ед брони");
            }
        }
        public void ShowInfo()
        {
            if (HP < 0)
                Console.WriteLine("Рыцарь умер");
            else
                Console.WriteLine($"Текущее статы Рыцаря(ХП/Броня/Урон): {HP}, {Armor}, {Damage}");
        }
    }
    class Caster : Basestats
    {
        public Caster() : base(70, 25, 30, "Кастер") { }

        public override void TakeDamage(int damage)
        {
            Random random = new Random();
            if (random.NextDouble() <= 0.3)
            { 
                Console.WriteLine("Кастер уклонился от удара");
                return;
            }
            else
            {
                int BlockDMG = Armor - damage; // Блок урона = 50 - 75 = -25
                if (BlockDMG <= 0)
                {
                    Armor = 0;
                    HP -= Math.Abs(BlockDMG);
                    Console.WriteLine($"Броня сломана. {Name} получил {Math.Abs(BlockDMG)} урона");
                }
                else
                {
                    Armor -= BlockDMG;
                    Console.WriteLine($"У {Name} осталось = {Armor} ед брони");
                }
            }
        }

        public void DamageBaff()
        {
            Damage += 10;
            Console.WriteLine($"Кастер использовал усиление заклинаний его урон = {Damage}");
        }
        public void ShowInfo()
        {
            if (HP < 0)
                Console.WriteLine($"Кастер умер");
            else
                Console.WriteLine($"Текущее статы Кастера(ХП/Броня/Урон): {HP}, {Armor}, {Damage}");
        }
    }
    class God
    {

    }
    class GameOptions
    {
        public void FirstHod()
        {
            Random rand = new Random();
            if (rand.Next(0,2) > 0)
                Console.WriteLine("Первым ходит Кастер");
            else
                Console.WriteLine("Первым ходит Рыцарь");
        }
    }
}
