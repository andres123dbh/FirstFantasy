using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Drawing;

namespace FirstFantasy_BonillaAndres.Classes.Equipment
{
    public abstract class EquipmentPlayer
    {
        private List<Weapon> listEquipment = new List<Weapon>();
        private List<Weapon> inventory = new List<Weapon>();

        public List<Weapon> ListEquipment { get => listEquipment; set => listEquipment = value; }
        public List<Weapon> Inventory { get => inventory; set => inventory = value; }
    }
}
