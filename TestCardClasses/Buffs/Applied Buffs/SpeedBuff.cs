namespace TestCardClasses.Buffs.Applied_Buffs
{
    public sealed class SpeedBuff : TimedBuff
    {
        private const int _duration = 10;
        private const bool _stackable = true;

        public SpeedBuff() :
           base(_stackable, _duration)
        {
            _priority = 2;
        }
        public override int CalculateSpeed()
        {
            return ParentUnit. + 2;
        }
    }
}