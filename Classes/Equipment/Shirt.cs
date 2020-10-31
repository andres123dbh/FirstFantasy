using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_BonillaAndres.Classes.Equipment
{
    class Shirt : Weapon
    {
        public Shirt(int damage) : base(damage)
        {
            Name = "Shirt";
            Type = "Amor";
            Use = "Protect";
        }

    }
}
