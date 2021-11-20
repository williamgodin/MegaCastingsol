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
    /// Logique d'interaction pour ViewBoadcaster.xaml
    /// </summary>
    public partial class ViewBroadcaster : UserControl
    {
        public ViewBroadcaster()
        {
            InitializeComponent();
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addwindow = new AddWindow();
            addwindow.ShowDialog();
            ((ViewModelBroadcaster)this.DataContext).AddItem();
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelBroadcaster)this.DataContext).SaveItem();
        }
        private void DelButton_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelBroadcaster)this.DataContext).DelItem();
        }
    }
}
