using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_BonillaAndres.Classes.Player
{
    public class Rouge : Character
    {
        public Rouge()
        {
            Type = "Rouge";
        }
        public override String Taunt()
        {
            return "By Meeee";
        }

    }
}
