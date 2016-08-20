namespace TestCardClasses.Buffs.Applied_Buffs
{
    public abstract class ConditionalBuff : BuffBase
    {
        protected delegate bool ActiveCondition();
        protected ActiveCondition _activeCondition;

        public ConditionalBuff(bool stackable)
            : base(stackable)
        {
            _activeCondition = Condition;
        }

        protected virtual bool Condition()
        {
            return true;
        }

        public virtual bool IsActive()
        {
            if (_activeCondition())
            {
                return true;
            }

            return false;
        }
    }
}
