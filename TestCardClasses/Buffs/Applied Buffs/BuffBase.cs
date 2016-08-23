using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCardClasses.Buffs.Applied_Buffs
{
    public abstract class BuffBase
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }
    }
}
