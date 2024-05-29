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

namespace Harjoitus_20
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Opiskelija> Opiskelijat = new List<Opiskelija>();

        public MainWindow()
        {
            InitializeComponent();

            dg_Opiskelijat.ItemsSource = Opiskelijat;
        }

        private void btn_LisääOpiskelija_Click(object sender, RoutedEventArgs e)
        {
            // Otetaan talteen kaikkien Input (TextBox) kenttien arvot, jotta koodi olisi luettavampi
            string etunimi = Input_Etunimi.Text;
            string sukunimi = Input_Sukunimi.Text;
            string puhelinnumero = Input_Puhelinnumero.Text;
            string sähköposti = Input_Sähköposti.Text;
            string opiskelijaID = Input_OpiskelijaID.Text;

            // Luodaan opiskelija ja lisätään se opiskelijat listaan
            Opiskelijat.Add(new Opiskelija(etunimi, sukunimi, puhelinnumero, sähköposti, opiskelijaID));
            dg_Opiskelijat.ItemsSource = Opiskelijat; // Päivitetään opiskelijat datagrid kontrolli

            // Siivotaan syöte kentät antamalla niille tyhjän "" teksti arvon

            Input_Etunimi.Text = "";
            Input_Sukunimi.Text = "";
            Input_Puhelinnumero.Text = "";
            Input_Sähköposti.Text = "";
            Input_OpiskelijaID.Text = "";
        }
    }
}
