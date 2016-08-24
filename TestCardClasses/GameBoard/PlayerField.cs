using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCardClasses.GameBoard
{
    class PlayerField
    {
        private BaseUnit[] Units = new BaseUnit[5];
        readonly Player.IPlayer OwningPlayer;

        /// <summary>
        /// Returns unit at specific position. Leftmost position is 1, rightmost is 5
        /// </summary>
        /// <param name="FieldPosition">Slot Number between 1 and 5</param>
        /// <returns></returns>
        public BaseUnit GetUnitAtSlot(int FieldPosition)
        {
            if (FieldPosition < 1 || FieldPosition > 5)
                throw new IndexOutOfRangeException("Field only has 5 slots");
            return Units[FieldPosition - 1];
        }
    }
}
