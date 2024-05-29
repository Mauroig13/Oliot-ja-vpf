using System.Windows;

namespace Harjoitus21Kauppalista
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonOsta_Click(object sender, RoutedEventArgs e)
        {
            // Asetetaan kaikki CheckBoxit valitsemattomiksi
            checkBoxMaito.IsChecked = false;
            checkBoxLeipa.IsChecked = false;
            checkBoxKahvi.IsChecked = false;
            checkBoxJuusto.IsChecked = false;
            checkBoxHedelmat.IsChecked = false;
            checkBoxVihannekset.IsChecked = false;
        }
    }
}