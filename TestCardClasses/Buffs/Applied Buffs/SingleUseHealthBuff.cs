using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCardClasses.Buffs.Applied_Buffs
{
    public sealed class SingleUseHealthBuff : SingleUseBuff
    {
        private const int HealthChange = 2;

        public override int CalculateHealth(BaseUnit unit)
        {
            return unit.Health + HealthChange;
        }
    }
}
