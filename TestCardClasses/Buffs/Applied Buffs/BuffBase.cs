using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCardClasses.Buffs.Applied_Buffs
{
    public abstract class BuffBase
    {
        private readonly bool _stackable;
        private int _turnsRemaining;
        protected int _priority;
        private BuffBase _parentBuff = null;
        private BaseUnit _parentUnit = null;
        protected List<BaseUnit> _unitsApplied = null;

        public bool Stackable
        {
            get { return _stackable; }
        }

        protected BuffBase(bool stackable)
        {
            _stackable = stackable;
        }

        public BaseUnit ParentUnit
        {
            get { return _parentUnit; }
            set
            {
                if (_parentUnit == null)
                {
                    _parentUnit = value;
                }
            }
        }

        public virtual int AttackProcessor(BaseUnit attacker)
        {
            return attacker.BaseAttack;
        }

        public virtual int DamageProcessor(BaseUnit defender, BaseUnit attacker)
        {
            return attacker.BaseAttack;
        }

    }
}
