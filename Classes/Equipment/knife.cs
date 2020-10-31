using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_BonillaAndres.Classes.Equipment
{
    class knife : Weapon
    {
        public knife(int damage) : base(damage)
        {
            Name = "knife";
            Type = "Weapon";
            Use = "Attack";
        }

    }
}
