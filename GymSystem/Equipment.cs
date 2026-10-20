using System;
using System.Collections.Generic;
using System.Text;

namespace GymSystem
{
    internal class Equipment
    {

        private int equipmentId;
        private string name;
        private bool isAvailable;


        public int EquipmentId
        {
            get { return equipmentId; }
            set { equipmentId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
        }

        Equipment(int equipmentId, string name, bool isAvailable)
        {
            this.EquipmentId = equipmentId;
            this.Name = name;
            this.IsAvailable = isAvailable;
        }


    }
}
