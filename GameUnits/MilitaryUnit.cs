using System;

namespace GameUnits
{
    class MilitaryUnit : Unit
    {
        public override int Health
        { 
            get
            {
                return base.Health + XP;
            }
            set
            {
                base.Health -= value;
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
        public int XP { get; private set; }
        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {
            AttackPower = attackPower;
            XP = 0;
        }

        public void Attack(Unit u)
        {
            XP++;
            u.Health--;
        }
    }
}
