using System;
using System.Numerics;

namespace GameUnits
{
    // the class is abstract because you cant just have a unit, you need to specify which type
    public abstract class Unit
    {
        private int movement;
        // it is virtual so the unit always has a base health, which can be modified in later classes
        public virtual int Health { get; set; }
        public abstract float Cost { get; }
        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }
        public void Move(Vector2 vector)
        {
            Console.WriteLine($"{vector.X * movement}, {vector.Y * movement}");
        }
        public void Move()
        {
            Console.WriteLine($"{movement}");
        }
        public virtual string ToString()
        {
            return $"{this}: HP={Health} COST={Cost}";
        }
    }
}
