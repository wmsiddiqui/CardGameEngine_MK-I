using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCardClasses.Interactions
{
    public class AttackAction : InteractionAction
    {
        private int _priority;
        private readonly BaseUnit _attacker;
        //private readonly BaseUnit _defender; //this should be slot
        public int Priority
        {
            get { return _priority; }
            private set { _priority = value; }
        }

        AttackAction(BaseUnit attacker)
        {
            _attacker = attacker;
        }


    }
}
