using System;

namespace GameUnits
{
    class MilitaryUnit : XPUnit
    {
        public override int Health
        { 
            get
            {
                return base.Health + XP;
            }
            set
            {
                base.Health = value;
            }
        }
        public override float Cost
        {
            get
            {
                return AttackPower + XP;
            }
        }
        public int AttackPower { get; }
        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {
            AttackPower = attackPower;
        }

        public void Attack(Unit u)
        {
            XP++;
            u.Health -= AttackPower;
        }

        public override string ToString()
        {
            return base.ToString() + $" AP={AttackPower}";
        }
    }
}
