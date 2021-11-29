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
using System.Windows.Shapes;
using MegaCastWPF.ViewModel;
using Megacasting.DBLib;



namespace MegaCastWPF.Windows.Artiste
{
    /// <summary>
    /// Logique d'interaction pour AddArtistWindow.xaml
    /// </summary>
    public partial class AddArtistWindow : Window
    {
        
        public AddArtistWindow()
        {
            InitializeComponent();
            Megacasting.DBLib.Artiste artiste = new Megacasting.DBLib.Artiste();
            this.DataContext = artiste;
        }

        private void ButtonAnnuler_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ButtonValider_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
