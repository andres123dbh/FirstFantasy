using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_BonillaAndres.Classes.Equipment
{
    class Axe : Weapon
    {
        public Axe(int damage) : base(damage)
        {
            Type = "Weapon-Axe";
            Use = "Attack";
        }
    }
}
