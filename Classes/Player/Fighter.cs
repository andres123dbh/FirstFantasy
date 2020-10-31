using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_BonillaAndres.Classes.Player
{
    public class Fighter : Character
    {
        public Fighter()
        {
            Type = "Fighter";
        }
        public override String Taunt()
        {
            return "By my Lord";
        }
    }
}
