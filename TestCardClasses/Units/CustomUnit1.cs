using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCardClasses.Units
{
    public sealed class CustomUnit1 : BaseUnit
    {
        private const string name = "Custom Unit 1";

        private static StatsInitializerObject stats = new StatsInitializerObject()
        {
            Health = 5,
            Attack = 2,
            Speed = 2,
            EnergyMax = 2,
            EnergyStart = 2,
            Range = 2,
            Level = 2
        };

        public CustomUnit1()
          :  base(name, stats)
        {
            //Consider using a factory pattern
        }
    }
}
