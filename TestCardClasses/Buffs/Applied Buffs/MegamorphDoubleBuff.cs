using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCardClasses.Buffs.Applied_Buffs
{
    public sealed class MegamorphDoubleBuff : TimedBuff
    {
        private const int _duration = 10;
        private const bool _stackable = false;

        public MegamorphDoubleBuff() :
           base(_stackable, _duration)
        {
            _priority = 2;
        }

        public override int CalculateAttack()
        {
            return ParentUnit.Attack * 2;
        }
    }
}
