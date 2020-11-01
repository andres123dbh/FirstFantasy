using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_BonillaAndres.Classes.Equipment
{
    class Potion : Weapon
    {
        public Potion(int damage) : base(damage)
        {
            Name = "Potion of Heal";
            Type = "Weapon";
            Use = "Heal";
        }
    }
}
