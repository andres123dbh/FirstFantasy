using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_BonillaAndres.Classes.Player
{
    public class Wizard : Character
    {
        public Wizard()
        {
            Type = "Wizard";
        }
        public override String Taunt()
        {
            return "By the Magic";
        }

    }
    
}
