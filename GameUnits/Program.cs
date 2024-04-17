using System;
using System.Numerics;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            MilitaryUnit a = new MilitaryUnit(2, 4, 2);
            SettlerUnit b = new SettlerUnit();
            Unit c = new MilitaryUnit(1, 2, 3);

            a.Move(new Vector2(4, -1));

            Console.WriteLine($"before: {a.Cost}");
            a.Attack(b);
            Console.WriteLine($"after: {a.Cost}");
            Console.WriteLine($"XP: {a.XP}");
            Console.WriteLine($"Health: {c.Health}");

            Console.WriteLine($"B COST: {b.Cost}");

        }
    }
}
