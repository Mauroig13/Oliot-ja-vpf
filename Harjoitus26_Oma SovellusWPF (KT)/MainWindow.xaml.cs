using Harjoitus26_Oma_SovellusWPF__KT_;
using System;
using System.Windows;

namespace Harjoitus26_Oma_SovellusWPF__KT_
{
    public partial class MainWindow : Window
    {
        private Tehtavalista tehtavalista;

        public MainWindow()
        {
            InitializeComponent();
            tehtavalista = new Tehtavalista();
        }

        private void ButtonLisaaTehtava_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (radioButtonKerta.IsChecked == true)
                {
                    KertaTehtava kertaTehtava = new KertaTehtava { Nimi = textBoxNimi.Text, Kuvaus = textBoxKuvaus.Text };
                    tehtavalista.LisaaTehtava(kertaTehtava);
                }
                else if (radioButtonToistuva.IsChecked == true)
                {
                    DateTime aloitusPvm = datePickerAloitusPvm.SelectedDate ?? DateTime.Today;
                    TimeSpan toistojakso = TimeSpan.FromDays((double)comboBoxToistojakso.SelectedValue);

                    ToistuvaTehtava toistuvaTehtava = new ToistuvaTehtava { Nimi = textBoxNimi.Text, Kuvaus = textBoxKuvaus.Text, AloitusPvm = aloitusPvm, Toistojakso = toistojakso };
                    tehtavalista.LisaaTehtava(toistuvaTehtava);
                }

                MessageBox.Show("Tehtävä lisätty onnistuneesti.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Virhe: {ex.Message}");
            }
        }

        private void ButtonSuoritaTehtavat_Click(object sender, RoutedEventArgs e)
        {
            tehtavalista.SuoritaKaikkiTehtavat();
        }
    }
}
