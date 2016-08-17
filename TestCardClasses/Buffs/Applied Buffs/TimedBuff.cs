using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCardClasses.Buffs.Applied_Buffs
{
    public class TimedBuff : BuffBase
    {
        private readonly int _duration;
        
        public TimedBuff(bool stackable, int duration)
            :base(stackable)
        {
            _duration = duration;
        }
    }
}
