using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCardClasses.Specials.Attacks
{
    class SharpShot : SpecialAttack, AttackAttributes.SniperAttack
    {
        private readonly string _name;
        private readonly string _description;

        public string Name
        {
            get { return _name; }
        }
        public string Description
        {
            get { return _description; }
        }
    }
}
