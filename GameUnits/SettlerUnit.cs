using System;

namespace GameUnits
{
    class SettlerUnit : Unit
    {
        public override float Cost
        {
            get { return 5; }
        }
        public SettlerUnit() : base(1, 2)
        {
        }
    }
}
