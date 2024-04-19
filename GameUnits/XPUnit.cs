using System;

namespace GameUnits
{
    public abstract class XPUnit : Unit
    {
        // Xp set is protected so only the hierarchy members can modify it
        public int XP { get; protected set; }

        public XPUnit(int mov, int health) : base(mov, health)
        {
            XP = 0;
        }

        public override string ToString()
        {
            return base.ToString() + $" XP={XP}";
        }
    }
}
