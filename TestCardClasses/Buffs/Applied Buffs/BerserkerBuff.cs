using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCardClasses.Buffs.Applied_Buffs
{
    public sealed class BerserkerBuff : ConditionalBuff
    {
        private const bool stackable = false;

        public BerserkerBuff() 
            : base(stackable)
        {
            
        }

        

        protected override bool Condition()
        {
            if(ParentUnit.Health < ParentUnit.BaseHealth / 2.0)
                return true;
            return false;
        }
    }
}
