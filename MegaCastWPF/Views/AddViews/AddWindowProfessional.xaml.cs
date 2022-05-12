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
using MegaCastWPF.Proxy;

namespace MegaCastWPF.Views.AddViews
{
    /// <summary>
    /// Logique d'interaction pour addProfessionalWindow.xaml
    /// </summary>
    public partial class AddWindowProfessional :Window
    {
        public AddWindowProfessional()
        {
            InitializeComponent();
            Megacasting.DBLib.Personne professionnel = new Megacasting.DBLib.Personne();
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
