using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCardClasses.Buffs.Applied_Buffs
{
    public class ConditionalBuff : BuffBase
    {
        protected delegate bool ActiveCondition();
        protected ActiveCondition _activeCondition;

        public ConditionalBuff(bool stackable)
            : base(stackable)
        {
            _activeCondition = Condition;
        }

        protected virtual bool Condition()
        {
            return true;
        }

        public virtual bool IsActive()
        {
            if (_activeCondition())
            {
                return true;
            }

            return false;
        }
    }
}
