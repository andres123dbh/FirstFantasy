﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_BonillaAndres.Classes.Equipment
{
    class Axe : Weapon
    {
        public Axe(int damage) : base(damage)
        {
            Name = "Axe";
            Type = "Weapon";
            Use = "Attack";
        }
    }
}
