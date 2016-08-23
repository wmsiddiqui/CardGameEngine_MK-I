using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCardClasses.Buffs.Applied_Buffs
{
    public abstract class TimedBuff : PersistingBuff
    {
        private readonly int _duration;
        private int _turnsRemaining;



        public TimedBuff(bool stackable, int duration)
            :base(stackable)
        {
            _duration = duration;
        }
    }
}
