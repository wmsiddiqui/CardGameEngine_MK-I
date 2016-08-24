using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCardClasses.Interactions
{
    public class InteractionQueue
    {
        private Queue<InteractionAction> _actionQueue = new Queue<InteractionAction>();

        private void RegisterActions(List<InteractionAction> actions)
        {
            var orderedActions = actions.OrderBy(a => a.Priority);
            foreach(var action in orderedActions)
            {
                _actionQueue.Enqueue(action);
            }
        }
    }
    public interface InteractionAction
    {
        int Priority { get; }
    }
}
