using System;

namespace GameUnits
{
    class SettlerUnit : Unit
    {
        public override float Cost { get; } = 5f;

        public SettlerUnit() : base(1, 3)
        {
        }
    }
}
