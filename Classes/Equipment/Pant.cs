using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_BonillaAndres.Classes.Equipment
{
    class Pant : Weapon
    {
        public Pant(int damage) : base(damage)
        {
            Name = "Pant";
            Type = "Amor";
            Use = "Protect";
        }
    }
}
