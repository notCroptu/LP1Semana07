using System;

namespace GameUnits
{
    class SpyUnit : XPUnit
    {
        public override float Cost { get; } = 12.5f;
        public SpyUnit() : base(8, 2)
        {
        }

        public void GetSecretInfo(Unit unit)
        {
            if (unit is SpyUnit) XP += 3;
            else if (unit is MilitaryUnit) XP += 2;
            else XP++;
        }
    }
}
