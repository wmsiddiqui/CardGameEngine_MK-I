using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCardClasses.Game_Components.GameBoard
{
    public class FieldCardContainer : Attackable
    {
        private BaseUnit _unitCard = null;
        private int? _tempEnergy = null;
        private int? _tempAttack = null;
        private int? _tempSpeed = null;
        private int? _tempRange = null;

        private readonly int _slotNumber;

        public BaseUnit UnitCard
        {
            get { return _unitCard; }
            set
            {
                if (value != null && _unitCard == null)
                    _unitCard = value;
                else
                    throw new Exception("Card slot is full or unit is null");
            }
        }
        public int? TempEnergy
        {
            get { return _tempEnergy; }
            set { _tempEnergy = value; }
        }
        public int? TempAttack
        {
            get { return _tempAttack; }
            set { _tempAttack = value; }
        }
        public int? TempSpeed
        {
            get { return _tempSpeed; }
            set { _tempSpeed = value; }
        }
        public int? TempRange
        {
            get { return _tempRange; }
            set { _tempRange = value; }
        }
        public FieldCardContainer(int slot)
        {
            _slotNumber = slot;
        }
    }
}
