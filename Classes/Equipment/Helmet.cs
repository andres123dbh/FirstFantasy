using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_BonillaAndres.Classes.Equipment
{
    class Helmet : Weapon
    {
        public Helmet(int damage) : base(damage)
        {
            Name = "Helmet";
            Type = "Amor";
            Use = "Protect";
        }

    }
}
