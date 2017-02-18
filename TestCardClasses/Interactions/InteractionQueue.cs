using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCardClasses.Interactions
{
    public class InteractionQueue
    {
        private Queue<IInteractionAction> _actionQueue = new Queue<IInteractionAction>();

        private void RegisterActions(IEnumerable<IInteractionAction> actions)
        {
            //This poses a new question:
            //  What happens when the speed of a unit changes while in the queue?
            //  Does the queue get re-ordered, or stay as-is for that turn?
            //  For example, Unit A, B, and C have the speeds 1,2, and 3, respectively.
            //  Unit C casts a buff on unit A, increasing Unit A's speed by 3.
            //  Unit A's speed is now 4. But the next in the queue is Unit B's action. 
            //  Does the queue get re-ordered?
            _actionQueue.Clear();
            var orderedActions = actions.OrderBy(a => a.Priority);
            foreach(var action in orderedActions)
            {
                _actionQueue.Enqueue(action);
            }
        }

        private void ResolveQueue()
        {
            while (_actionQueue.Count != 0)
            {
                ReorderQueue(); //Needed? Only if priority changes
                var action = _actionQueue.Dequeue();
                if (action is AttackAction)
                {
                    //Processors.DamageProcessor.
                }
            }
        }

        public void ReorderQueue()
        {
            RegisterActions(_actionQueue);
        }
    }
    public interface IInteractionAction
    {
        int Priority { get; }
        BaseUnit Source { get; }
        Game_Components.Attackable Target { get; }
    }
}
