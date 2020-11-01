using FirstFantasy_BonillaAndres.Classes.Equipment;
using FirstFantasy_BonillaAndres.Classes.Player;
using FirstFantasy_BonillaAndres.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Drawing;
using System.Data;

namespace FirstFantasy_BonillaAndres
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ListCharacter listCharacters;
        public MainWindow()
        {
            InitializeComponent();
            listCharacters = new ListCharacter();

        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            String optionCharacter = CboxCharacter.Text;
            String optionWeapon = CboxWeapon.Text;
            String optionAmor = CboxAmor.Text;
            String optionRace = CboxRace.Text;
            String name = txtName.Text;

            Character myCharacter;

            switch (optionCharacter)
            {
                case "Cleric":
                    myCharacter = new Cleric();
                    myCharacter.Name = name;
                    myCharacter.Level = 0;
                    myCharacter.Experience = 0;
                    break;

                case "Fighter":
                    myCharacter = new Fighter();
                    myCharacter.Name = name;
                    myCharacter.Level = 0;
                    myCharacter.Experience = 0;
                    break;

                case "Rouge":
                    myCharacter = new Rouge();
                    myCharacter.Name = name;
                    myCharacter.Level = 0;
                    myCharacter.Experience = 0;
                    break;

                case "Wizard":
                    myCharacter = new Wizard();
                    myCharacter.Name = name;
                    myCharacter.Level = 0;
                    myCharacter.Experience = 0;
                    break;

                default:
                    myCharacter = null;
                    MessageBox.Show("You MUST select a type");
                    break;
            }

            switch (optionRace)
            {
                case "Dwarf":
                    myCharacter.Race = Character.Races.Dwarf.ToString();
                    break;

                case "Elf":
                    myCharacter.Race = Character.Races.Elf.ToString();
                    break;

                case "Hobbit":
                    myCharacter.Race = Character.Races.Hobbit.ToString();
                    break;

                case "Human":
                    myCharacter.Race = Character.Races.Human.ToString();
                    break;

                case "Orc":
                    myCharacter.Race = Character.Races.Orc.ToString();
                    break;

                default:
                    MessageBox.Show("You MUST select a race");
                    break;
            }

            switch (optionWeapon)
            {
                case "Axe":
                    Axe axe = new Axe(9);
                    myCharacter.ListEquipment.Add(axe);
                    break;

                case "Sword":
                    Sword sword = new Sword(6);
                    myCharacter.ListEquipment.Add(sword);
                    break;

                case "Potion":
                    Potion potion = new Potion(10);
                    myCharacter.ListEquipment.Add(potion);
                    break;

                case "Staff":
                    Staff staff = new Staff(8);
                    myCharacter.ListEquipment.Add(staff);
                    break;

                case "knife":
                    knife knife = new knife(5);
                    myCharacter.ListEquipment.Add(knife);
                    break;

                default:
                    MessageBox.Show("You MUST select a weapon");
                    break;
            }

            switch (optionAmor)
            {
                case "Helmet":
                    Helmet helmet = new Helmet(3);
                    myCharacter.ListEquipment.Add(helmet);
                    break;

                case "Shirt":
                    Shirt shirt = new Shirt(4);
                    myCharacter.ListEquipment.Add(shirt);
                    break;

                case "Pant":
                    Pant pant = new Pant(2);
                    myCharacter.ListEquipment.Add(pant);
                    break;

                default:
                    MessageBox.Show("You MUST select an amor");
                    break;
            }

            if (checkAxe.IsChecked == true)
            {
                Axe axe = new Axe(9);
                myCharacter.Inventory.Add(axe);
                checkAxe.IsChecked = false;
            }

            if (checkHelmet.IsChecked == true)
            {
                Helmet helmet = new Helmet(3);
                myCharacter.Inventory.Add(helmet);
                checkHelmet.IsChecked = false;
            }

            if (checkKnife.IsChecked == true)
            {
                knife knife = new knife(5);
                myCharacter.Inventory.Add(knife);
                checkKnife.IsChecked = false;
            }

            if (checkPant.IsChecked == true)
            {
                Pant pant = new Pant(2);
                myCharacter.Inventory.Add(pant);
                checkPant.IsChecked = false;
            }

            if (checkPotion.IsChecked == true)
            {
                Potion potion = new Potion(10);
                myCharacter.Inventory.Add(potion);
                checkPotion.IsChecked = false;
            }

            if (checkShirt.IsChecked == true)
            {
                Shirt shirt = new Shirt(4);
                myCharacter.Inventory.Add(shirt);
                checkShirt.IsChecked = false;
            }

            if (checkStaff.IsChecked == true)
            {
                Staff staff = new Staff(8);
                myCharacter.Inventory.Add(staff);
                checkStaff.IsChecked = false;
            }

            if (checkSword.IsChecked == true)
            {
                Sword sword = new Sword(6);
                myCharacter.Inventory.Add(sword);
                checkSword.IsChecked = false;
            }

            if(name == "")
            {
                myCharacter = null;
                MessageBox.Show("You MUST write a name");
            }

            if (myCharacter != null && myCharacter.ListEquipment.Count == 2 && myCharacter.Race != null)
            {
                
                var listAllCharacters = listCharacters.ListAllCharacters;
                listAllCharacters.Add(myCharacter);
                txtName.Text = null;
                nullListCharacter();
                
            }
            
        }

        private void lvDataBinding_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var var2 = lvDataBinding.SelectedIndex;
            var count = lvDataBinding.Items.Count;
            if (count != 0)
            {
                var listAllCharacters = listCharacters.ListAllCharacters;
                txtName1.Text = listAllCharacters[var2].Name;
                txtType.Text = listAllCharacters[var2].Type;
                txtRace.Text = listAllCharacters[var2].Race;
                txtEquippedWeapon.Text = listAllCharacters[var2].ListEquipment[0].Name;
                txtEquippedAmor.Text = listAllCharacters[var2].ListEquipment[1].Name;
                txtId.Text = (var2 + 1).ToString();
                var text = "";
                int countId = 1;
                foreach (Weapon w in listAllCharacters[var2].Inventory)
                {
                    text += countId + ". " + w.Name + "\n";
                    countId += 1;
                }
                txtInventory.Text = text;
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtIdCharacter.Text != "" && txtIdEquipment.Text != "")
            {
                var listAllCharacters = listCharacters.ListAllCharacters;
                int idCharacter = Int32.Parse(txtIdCharacter.Text) - 1;
                int idEquipment = Int32.Parse(txtIdEquipment.Text) - 1;
                var listTemporal = listAllCharacters[idCharacter].Inventory[idEquipment];
                if (listAllCharacters[idCharacter].Inventory[idEquipment].Type == "Weapon")
                {
                    listAllCharacters[idCharacter].Inventory[idEquipment] = listAllCharacters[idCharacter].ListEquipment[0];
                    listAllCharacters[idCharacter].ListEquipment[0] = listTemporal;
                    txtIdCharacter.Text = null;
                    txtIdEquipment.Text = null;
                    nullListCharacter();
                    MessageBox.Show("Successful Change");

                }
                else if (listAllCharacters[idCharacter].Inventory[idEquipment].Type == "Amor")
                {
                    listAllCharacters[idCharacter].Inventory[idEquipment] = listAllCharacters[idCharacter].ListEquipment[1];
                    listAllCharacters[idCharacter].ListEquipment[1] = listTemporal;
                    txtIdCharacter.Text = null;
                    txtIdEquipment.Text = null;
                    nullListCharacter();
                    MessageBox.Show("Successful Change");
                }
            }
            else
            {
                MessageBox.Show("Id Character or Id Equipment Empty");
            }
        }

        public void nullListCharacter()
        {
            var listAllCharacters = listCharacters.ListAllCharacters;
            txtName1.Text = null;
            txtType.Text = null;
            txtRace.Text = null;
            txtEquippedWeapon.Text = null;
            txtEquippedAmor.Text = null;
            txtInventory.Text = null;
            txtId.Text = null;
            lvDataBinding.ItemsSource = null;
            lvDataBinding.ItemsSource = listAllCharacters;
        }
    }
}