using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_BonillaAndres.Classes.Equipment
{
    class Staff : Weapon
    {
        public Staff(int damage) : base(damage)
        {
            Name = "Staff";
            Type = "Weapon";
            Use = "Attack";
        }

    }
}
