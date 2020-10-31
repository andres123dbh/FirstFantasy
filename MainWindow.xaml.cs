using FirstFantasy_BonillaAndres.Classes.Equipment;
using FirstFantasy_BonillaAndres.Classes.Player;
using FirstFantasy_BonillaAndres.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace FirstFantasy_BonillaAndres
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            String option = CboxCharacter.Text;

            Character myCharacter;

            Potion a = new Potion(2);
            MessageBox.Show(a.Type + a.Use + a.Damage);
            

            /*
            switch (option)
            {
                case "Cleric":
                    myCharacter = new Cleric();
                    break;

                case "Fighter":
                    myCharacter = new Fighter();
                    break;

                case "Rouge":
                    myCharacter = new Rouge();
                    break;

                case "Wizard":
                    myCharacter = new Wizard();
                    break;

                default:
                    myCharacter = null;
                    MessageBox.Show("You MUST select a type");
                    break;
            }

            if (myCharacter != null)
            {
                txtOutput.Text = myCharacter.ShowCharacter();
            }
            */
        }
    }
}
