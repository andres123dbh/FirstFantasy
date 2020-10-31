using FirstFantasy_BonillaAndres.Classes.Equipment;
using FirstFantasy_BonillaAndres.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy_BonillaAndres.Classes.Player
{
    public abstract class Character : EquipmentPlayer , IDescribible
    {
        private String name;
        private int level;
        private int experience;
        private String race;

        enum Races { Dwarf, Elf, Hobbit, Human, Orc}

        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
        public int Experience { get => experience; set => experience = value; }
        public string Race { get => race; set => race = value; }

        public abstract String Taunt();

        public virtual String ShowCharacter()
        {
            return "Name: " + name + " Level: " + level + " XP: " + experience;
        }

        public string ShowInformation()
        {
            return "This is a level" + level;
        }

        public int Attack(List<Weapon> listEquipment)
        {
            var random = new Random();
            int randomNumber = random.Next(1, 9);
            return 1;
        }
    }
}
