using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCardClasses.Processors
{
    public class DamageProcessor
    {
        public void CalculateDamage(BaseUnit defendingUnit, BaseUnit attackingUnit)
        {
            defendingUnit.ApplyDamage(attackingUnit);
        }

        public void ProcessAttackAction(Interactions.AttackAction attack)
        {
            //TODO
        }
    }
}
