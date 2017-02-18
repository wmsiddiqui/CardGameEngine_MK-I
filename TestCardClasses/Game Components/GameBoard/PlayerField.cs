using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCardClasses.Game_Components.GameBoard
{
    public class PlayerField
    {
        private readonly FieldCardContainer[] Units = new FieldCardContainer[5];
        readonly Player.IPlayer OwningPlayer;

        public PlayerField()
        {
            for(int i = 0; i < 5; i++)
            {
                Units[i] = new FieldCardContainer(i);
            }
        }

        /// <summary>
        /// Returns unit at specific position. Leftmost position is 1, rightmost is 5
        /// </summary>
        /// <param name="FieldPosition">Slot Number between 1 and 5</param>
        /// <returns></returns>
        public FieldCardContainer GetContainerAtSlot(int FieldPosition)
        {
            if (FieldPosition < 0 || FieldPosition > 4)
                throw new IndexOutOfRangeException("Field only has 5 slots");
            return Units[FieldPosition];
        }

        public BaseUnit GetUnitAtSlot(int FieldPosition)
        {
            return GetContainerAtSlot(FieldPosition).UnitCard;
        }

        //this should not do this
        public void AddUnit(BaseUnit unit, int slot)
        {
            if(slot < 0 || slot > 4)
            {
                throw new IndexOutOfRangeException("Slot is out of range");
            }
            var container = Units[slot];
            container.UnitCard = unit;
        }
    }
}
