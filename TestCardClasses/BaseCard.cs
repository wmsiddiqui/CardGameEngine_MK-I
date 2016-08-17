using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCardClasses
{
    public abstract class BaseCard
    {
        private readonly CardType _cardType;
        private readonly string _name;

        public string Name
        {
            get { return _name; }
        }
        public BaseCard(CardType type, string name)
        {
            _cardType = type;
            _name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
    public enum CardType
    {
        Unit = 1,
        Armor = 2,
        Buff = 3
    }
}
