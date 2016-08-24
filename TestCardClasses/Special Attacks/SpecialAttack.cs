using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCardClasses.Special_Attacks
{
    interface SpecialAttack
    {
        string Name { get; }
        string Description { get; }
    }

    public enum AttackType
    {
        RegularAttack = 0,
        PrimarySpecial = 1,
        SecondarySpecial = 2
    }
}
