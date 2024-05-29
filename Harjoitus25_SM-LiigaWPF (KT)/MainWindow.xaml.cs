using System.Collections.Generic;
using System.IO;
using System.Windows;
using Newtonsoft.Json;

namespace Harjoitus25_SM_LiigaWPF__KT_
{
    public partial class MainWindow : Window
    {
        private List<Joukkue> joukkueet;

        public MainWindow()
        {
            InitializeComponent();
            LoadJoukkueet();
            dataGridJoukkueet.ItemsSource = joukkueet;
            dataGridPelaajat.ItemsSource = new List<Pelaaja>();
        }

        private void LoadJoukkueet()
        {
            string filePath = "joukkueet.json";
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                joukkueet = JsonConvert.DeserializeObject<List<Joukkue>>(json);
            }
            else
            {
                joukkueet = new List<Joukkue>
                {
                    new Joukkue { Nimi = "JYP", Kotikaupunki = "Jyväskylä", Pelaajat = new List<Pelaaja> { new Pelaaja { Etunimi = "Matti", Sukunimi = "Meikäläinen", Numero = 1 } } },
                    new Joukkue { Nimi = "HIFK", Kotikaupunki = "Helsinki", Pelaajat = new List<Pelaaja> { new Pelaaja { Etunimi = "Mikko", Sukunimi = "Mallikas", Numero = 2 } } }
                };
                SaveJoukkueet();
            }
        }

        private void SaveJoukkueet()
        {
            string json = JsonConvert.SerializeObject(joukkueet);
            File.WriteAllText("joukkueet.json", json);
        }

        private void dataGridJoukkueet_SelectionChanged(object sender, RoutedEventArgs e)
        {
            Joukkue selectedJoukkue = (Joukkue)dataGridJoukkueet.SelectedItem;
            if (selectedJoukkue != null)
            {
                dataGridPelaajat.ItemsSource = selectedJoukkue.Pelaajat;
            }
        }
    }
}
