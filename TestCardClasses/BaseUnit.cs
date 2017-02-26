using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCardClasses
{
    public interface IBaseUnit
    {
        //TODO: THis is wrong!!! We need to abstract into interfaces for testing!
        int BaseHealth { get; }
        int BaseAttack { get; }
        int BaseSpeed { get; }
        int BaseEnergyMax { get; }
        int StartingEnergy { get; }
        int Range { get; }
        int Level { get; }
        Buffs.Applied_Buffs.PersistingBuff[] ApiAppliedBuffsExternalCall { get; }
        void ApplySingleUseBuffs(Buffs.Applied_Buffs.SingleUseBuff buff);
        //internal List<Buffs.Applied_Buffs.PersistingBuff> AppliedBuffs { get; }
    }
    public abstract class BaseUnit : BaseCard, IBaseUnit
    {
        private readonly int _baseHealth;
        private readonly int _baseAttack;
        private readonly int _baseSpeed;
        private readonly int _baseEnergyMax;
        private readonly int _startingEnergy;
        private readonly int _baseRange; //0-5
        private readonly int _level;
        
        //dynamic-state stats
        private int _currentHealth;
        private int _currentAttack;
        private int _currentSpeed;
        private int _currentEnergy;


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
            protected set { _currentHealth = value; }
        }
        public int Energy
        {
            get { return _currentEnergy; }
            protected set { _currentEnergy = value; }
        }
        public int Attack
        {
            get { return _currentAttack; }
            private set { _currentAttack = value; }
        }

        public int Speed
        {
            get { return _currentSpeed; }
            private set { _currentSpeed = value; }
        }

        private List<Buffs.Applied_Buffs.PersistingBuff> _appliedBuffs =
            new List<Buffs.Applied_Buffs.PersistingBuff>();

        internal List<Buffs.Applied_Buffs.PersistingBuff> AppliedBuffs
        {
            get { return _appliedBuffs; }
        }

        public Buffs.Applied_Buffs.PersistingBuff[] ApiAppliedBuffsExternalCall
        {
            get
            {
                Buffs.Applied_Buffs.PersistingBuff[] copyList = _appliedBuffs.ToArray();
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
            _currentSpeed = stats.Speed;
        }

        private void ApplyDamage(int damage)
        {
            Health -= damage;
        }

        //TODO: WRONG! Only units can do damage???
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
        
        internal void ApplySingleUseBuffs(Buffs.Applied_Buffs.SingleUseBuff buff)
        {
            Health = buff.CalculateHealth(this);
            Energy = buff.CalculateEnergy(this);
        }

        public void RecalculateStats()
        {
            RecalculateAttack();
            RecalculateSpeed();
        }

        private void RecalculateAttack()
        {
            Attack = BaseAttack;
            //Need to decide if this is better, or just having a sorted list.
            _appliedBuffs = _appliedBuffs.OrderBy(b => b.Priority).ToList();
            foreach(var buff in _appliedBuffs)
            {
                Attack = buff.CalculateAttack();
            }
        }
        private void RecalculateSpeed()
        {
            Speed = BaseSpeed;
            _appliedBuffs = _appliedBuffs.OrderBy(b => b.Priority).ToList();
            foreach(var buff in _appliedBuffs)
            {
                Speed = buff.CalculateSpeed();
            }
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
