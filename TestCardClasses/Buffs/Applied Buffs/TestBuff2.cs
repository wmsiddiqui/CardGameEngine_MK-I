using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCardClasses.Buffs.Applied_Buffs
{
    public sealed class TestBuff2 : TimedBuff
    {
        private const int _duration = 10;
        private const bool _stackable = true;

        public TestBuff2() :
           base(_stackable, _duration)
        { }

        public override int AttackProcessor(BaseUnit attacker)
        {
            return 500;
        }
        //Need a mechanism for applying buffs. Cards should not directly create buffs.

    }
}
