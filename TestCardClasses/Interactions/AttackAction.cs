using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCardClasses.Interactions
{
    public class AttackAction : IInteractionAction
    {
        private readonly BaseUnit _attacker;
        //private readonly BaseUnit _defender; //this should be slot
        public int Priority
        {
            get { return Source.Speed; }
        }
        public BaseUnit Source
        {
            get { return _attacker; }
        }

        public Game_Components.Attackable Target { get; }

        AttackAction(BaseUnit attacker, Specials.Attacks.AttackType attackType)
        {
            _attacker = attacker;
        }
    }
}
