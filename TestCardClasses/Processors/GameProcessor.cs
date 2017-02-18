using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCardClasses.Processors
{
    public class GameProcessor
    {
        private readonly DamageProcessor _damageProcessor = new DamageProcessor();

        private void ProcessAttack(Interactions.AttackAction attackAction)
        {
            //TODO: Logic here to determine type of attack
            _damageProcessor.ProcessAttackAction(attackAction);
        }
    }
}
