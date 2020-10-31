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
        private String type;

        public enum Races { Dwarf, Elf, Hobbit, Human, Orc}

        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
        public int Experience { get => experience; set => experience = value; }
        public string Race { get => race; set => race = value; }
        public string Type { get => type; set => type = value; }

        public abstract String Taunt();



        public virtual String ShowCharacter()
        {
            return "Name: " + name + "\nType: " + type + "\nLevel: " + level + "\nXP: " 
                + experience + "\nRace: " + race +"\nEquipped weapon: " + ListEquipment[0].Name 
                + "\nEquipped amor: " + ListEquipment[1].Name;
        }

        public string ShowInformation()
        {
            return "This is a level" + level;
        }

        public int Attack(List<Weapon> listEquipment)
        {
            var random = new Random();
            int randomNumber = random.Next(1, 9);
            int totalDamage = randomNumber + listEquipment[0].Damage;
            return totalDamage;
        }
    }
}
