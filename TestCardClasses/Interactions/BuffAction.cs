using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCardClasses.Interactions
{
    public class BuffAction : IInteractionAction
    {
        private int _priority;
        private readonly BaseUnit sourceUnit;
        private readonly Game_Components.Attackable targetUnit;

        public int Priority
        {
            get { return Source.Speed; }
        }
        public BaseUnit Source
        {
            get { return sourceUnit; }
        }
        public Game_Components.Attackable Target
        {
            get { return targetUnit; }
        }

        public BuffAction(BaseUnit source, Game_Components.Attackable target = null)
        {
            if (target == null)
                targetUnit = (Game_Components.Attackable) source;
            if (source == null)
                throw new Exception("Invalid source");
            sourceUnit = source;
            _priority = source.Speed;
        }
    }
}
