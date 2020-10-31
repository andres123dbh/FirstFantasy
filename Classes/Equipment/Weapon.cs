using FirstFantasy_BonillaAndres.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_BonillaAndres.Classes.Equipment
{
    public abstract class Weapon : IDescribible
    {
        private int damage;
        private string type;
        private string use;
        private string name;

        public string Type { get => type; set => type = value; }
        public string Use { get => use; set => use = value; }
        public int Damage { get => damage; set => damage = value; }
        public string Name { get => name; set => name = value; }

        public Weapon (int damage)
        {
            this.damage = damage;
        }
        public string Attack()
        {
            return "Attack";
        }

        public string Attack(int times)
        {
            string message = "";
            for(int i = 0; i < times; i++)
            {
                message += Attack() + " ";
            }
            return message;
        }

        public string ShowInformation()
        {
            return "This is a weapon";
        }

        
    }
}
