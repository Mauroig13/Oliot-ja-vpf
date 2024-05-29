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

namespace Harjoitus_15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int autot = 0;
        int kuormaAutot = 0;

        public MainWindow()
        {
            InitializeComponent();
            TB_Auto.Text = autot.ToString();
            TB_Kuormaauto.Text = kuormaAutot.ToString();
        }

        private void btn_Kuormaauto_Click(object sender, RoutedEventArgs e)
        {
            kuormaAutot++; // Lisätään kuorma autoille yksi arvo lisää
            TB_Kuormaauto.Text = kuormaAutot.ToString();
        }

        private void btn_Auto_Click(object sender, RoutedEventArgs e)
        {
            autot++;
            TB_Auto.Text = autot.ToString();
        }
    }
}
