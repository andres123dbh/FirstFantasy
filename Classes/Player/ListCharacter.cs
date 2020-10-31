using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_BonillaAndres.Classes.Player
{
    class ListCharacter
    {
        private List<Character> listAllCharacters = new List<Character>();

        public List<Character> ListAllCharacters { get => listAllCharacters; set => listAllCharacters = value; }
    }
}
