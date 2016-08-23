using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCardClasses.Buffs.Applied_Buffs
{
    /// <summary>
    /// This buff is for altering "consumable" stats, like health and energy
    /// </summary>
    public abstract class SingleUseBuff : BuffBase
    {
        public SingleUseBuff()
        {

        }

        public virtual int CalculateHealth(BaseUnit unit)
        {
            return unit.Health;
        }
        public virtual int CalculateEnergy(BaseUnit unit)
        {
            return unit.Energy;
        }
    }
}
