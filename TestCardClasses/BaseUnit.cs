using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCardClasses
{
    public abstract class BaseUnit : BaseCard
    {
        private readonly int _baseHealth;
        private readonly int _baseAttack;
        private readonly int _baseSpeed;
        private readonly int _baseEnergyMax;
        private readonly int _startingEnergy;
        private readonly int _baseRange;
        private readonly int _level;
        //test
        private int _currentHealth;
        private int _currentAttack;

        public int BaseHealth
        {
            get { return _baseHealth; }
        }
        public int BaseAttack
        {
            get { return _baseAttack; }
        }
        public int BaseSpeed
        {
            get { return _baseSpeed; }
        }
        public int BaseEnergyMax
        {
            get { return _baseEnergyMax; }
        }
        public int StartingEnergy
        {
            get { return _startingEnergy; }
        }
        public int Range
        {
            get { return _baseRange; }
        }
        public int Level
        {
            get { return _level; }
        }
        public int Health
        {
            get { return _currentHealth; }
            protected set
            {
                _currentHealth = value;
            }
        }
        private List<Buffs.Applied_Buffs.BuffBase> _appliedBuffs =
            new List<Buffs.Applied_Buffs.BuffBase>();

        internal List<Buffs.Applied_Buffs.BuffBase> AppliedBuffs
        {
            get { return _appliedBuffs; }
        }

        public Buffs.Applied_Buffs.BuffBase[] ApiAppliedBuffsExternalCall
        {
            get
            {
                Buffs.Applied_Buffs.BuffBase[] copyList = _appliedBuffs.ToArray();
                return copyList;
            }
        }

        public BaseUnit(string name, StatsInitializerObject stats)
            : base(CardType.Unit, name)
        {
            _baseHealth = stats.Health;
            _baseAttack = stats.Attack;
            _baseSpeed = stats.Speed;
            _baseEnergyMax = stats.EnergyMax;
            _startingEnergy = stats.EnergyStart;
            _baseRange = stats.Range;
            _level = stats.Level;
            _currentHealth = _baseHealth;
            _currentAttack = stats.Attack;
        }

        private void ApplyDamage(int damage)
        {
            Health -= damage;
        }

        public void ApplyDamage(BaseUnit attackingUnit)
        {
            int damage = attackingUnit.Attack;
            foreach (var buff in _appliedBuffs)
            {
                damage = buff.CalculateDamage(damage);
            }
            int remainingHealth = Health - damage;
            Health = (remainingHealth >= 0) ? remainingHealth : 0;
        }
        
        internal void ApplyHealthBuff()
        {

        }

        public void RecalculateStats()
        {
            RecalculateAttack();
        }

        private void RecalculateAttack()
        {
            Attack = _baseAttack;
            //Need to decide if this is better, or just having a sorted list.
            _appliedBuffs = _appliedBuffs.OrderBy(b => b.Priority).ToList();
            foreach(var buff in _appliedBuffs)
            {
                Attack = buff.CalculateAttack();
            }
        }

        public int Attack
        {
            get { return _currentAttack; }
            private set { _currentAttack = value; }
        }
    }

    public class StatsInitializerObject
    {
        public int Health;
        public int Attack;
        public int Speed;
        public int EnergyMax;
        public int EnergyStart;
        public int Range;
        public int Level;
    }
}
