using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCardClasses.Buffs.Applied_Buffs
{
    public sealed class SingleUseEnergyBuff : SingleUseBuff
    {
        private const int EnergyChange = 2;

        public override int CalculateEnergy(BaseUnit unit)//How do we want this? Would it go to max or the buff fails or go over energy?
        {
            if(unit.BaseEnergyMax <= unit.Energy + EnergyChange)//Does not allow to pass max energy
                return unit.Energy + EnergyChange;
            return unit.BaseEnergyMax;  //Return max energy if energy buff increases past max energy
        }
    }
}
