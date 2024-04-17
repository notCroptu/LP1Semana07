using System;

namespace GameUnits
{
    class SettlerUnit : Unit
    {
        public constant override float Cost { get; } = 5;

        public SettlerUnit() : base(1, 3)
        {
        }
    }
}
