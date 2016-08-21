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
        protected int _priority = 10;
        private BuffBase _parentBuff = null;
        private BaseUnit _parentUnit = null;
        protected List<BuffBase> _childBuffs = null;

        public bool Stackable
        {
            get { return _stackable; }
        }

        protected BuffBase(bool stackable)
        {
            _stackable = stackable;
        }
        public int Priority
        { get { return _priority; } }

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
        public virtual int CalculateAttack()
        {
            return _parentUnit.BaseAttack;
        }
        public virtual int CalculateSpeed()
        {
            return _parentUnit.BaseSpeed;
        }
        public virtual int CalculateDamage(int attackerAttack)
        {
            return attackerAttack;
        }
    }
}
