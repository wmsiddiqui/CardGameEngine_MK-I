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
            :base(false)
        {

        }
    }
}
