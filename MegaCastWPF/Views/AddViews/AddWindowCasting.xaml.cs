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

namespace MegaCastWPF.Views
{
    /// <summary>
    /// Logique d'interaction pour AddWindowCasting.xaml
    /// </summary>
    public partial class AddWindowCasting : Window
    {
        public AddWindowCasting()
        {
            InitializeComponent();
        }

        private void SaveButtonAddCastingWindow_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }
    }
}
