﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_BonillaAndres.Classes.Player
{
    public class Cleric : Character
    {
        public Cleric()
        {
            Type = "Cleric";
        }
        public override String Taunt()
        {
            return "By the Gods";
        }

    }

}
