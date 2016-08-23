using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCardClasses.Buffs.Applied_Buffs
{
    public abstract class LingeringBuffs : PersistingBuff
    {
        LingeringBuffs(bool stackable)
            :base(stackable)
        { }
    }
}
