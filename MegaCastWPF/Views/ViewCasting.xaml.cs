using MegaCastWPF.ViewModel;
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

namespace MegaCastWPF.Views
{
    /// <summary>
    /// Logique d'interaction pour OffresCasting.xaml
    /// </summary>
    public partial class ViewCasting : UserControl
    {
        public ViewCasting()
        {
            InitializeComponent();
        }
        
        private void DelButton_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelCasting)this.DataContext).DelItem();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ModifButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
