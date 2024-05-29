using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Harjoitus_23
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Kiuas kiuas = new Kiuas();

        public MainWindow()
        {
            InitializeComponent();

            // Alustetaan kiuas tietyillä arvoilla
            kiuas.VaihdaLämpötila(10);
            kiuas.VaihdaKosteutta(10);
            kiuas.OnkoPäällä = false; // Kiuas on alussa false
        }

        private void btn_LämpötilaUp_Click(object sender, RoutedEventArgs e)
        {
            int uusiLämpötila = kiuas.Lämpötila + 5; // Lisäätän ensin nykyseen lämpötilaan 5 lisää
            kiuas.VaihdaLämpötila(uusiLämpötila); // kutsutaan kiukaan toimintoa jossa tarkistetaan onko se 10-120 välillä
            tb_Lämpötila.Text = kiuas.Lämpötila.ToString(); // lisätään lämpötila teksti kenttään nykyinen lämpötila
        }

        private void btn_LämpötilaDown_Click(object sender, RoutedEventArgs e)
        {
            int uusiLämpötila = kiuas.Lämpötila - 5; // vähennetään ensin nykyseen lämpötilaan viidellä
            kiuas.VaihdaLämpötila(uusiLämpötila); // kutsutaan kiukaan toimintoa jossa tarkistetaan onko se 10-120 välillä
            tb_Lämpötila.Text = kiuas.Lämpötila.ToString(); // lisätään lämpötila teksti kenttään nykyinen lämpötila
        }

        private void Input_Kosteus_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // tämän avulla Kosteus TextBox ottaa sisään VAIN numeroita, kirjaimia ei voida kirjoittaa
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Input_Kosteus_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Input_Kosteus.Text != "") // != tarkoittaa että a EI OLE YHTÄKUIN b
            {
                kiuas.VaihdaKosteutta(int.Parse(Input_Kosteus.Text));
                tb_Kosteus.Text = kiuas.Kosteus.ToString();
            }
        }
    }
}
