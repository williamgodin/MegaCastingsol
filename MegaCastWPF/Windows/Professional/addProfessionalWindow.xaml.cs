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
using MegaCastWPF.Windows.Professional;

namespace MegaCastWPF.Windows.Professional
{
    /// <summary>
    /// Logique d'interaction pour addProfessionalWindow.xaml
    /// </summary>
    public partial class addProfessionalWindow : Window
    {
        public addProfessionalWindow()
        {
            InitializeComponent();
            Megacasting.DBLib.Professionnel professionnel = new Megacasting.DBLib.Professionnel();
            this.DataContext = professionnel;
        }

        private void ButtonAnnuler_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ButtonValider_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
