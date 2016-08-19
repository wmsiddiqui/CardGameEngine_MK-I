using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCardClasses.Buffs.Applied_Buffs
{
    public sealed class AttackBuff500 : TimedBuff
    {
        private const int _duration = 10;
        private const bool _stackable = true;

        public AttackBuff500() :
           base(_stackable, _duration)
        {
            _priority = 3;
        }

        public override int CalculateAttack()
        {
            return 500;
        }
        //Need a mechanism for applying buffs. Cards should not directly create buffs.

    }
}
