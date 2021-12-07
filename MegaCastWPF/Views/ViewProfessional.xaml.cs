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
    /// Logique d'interaction pour ViewProfessional.xaml
    /// </summary>
    public partial class ViewProfessional : UserControl
    {
        public ViewProfessional()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelProfessional)this.DataContext).AddItem();
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelProfessional)this.DataContext).SaveItem();
        }

        private void ButtonDel_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelProfessional)this.DataContext).DelItem();
        }
    }
}
