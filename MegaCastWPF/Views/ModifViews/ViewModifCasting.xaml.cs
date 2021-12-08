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

namespace MegaCastWPF.Views
{
    /// <summary>
    /// Logique d'interaction pour ViewMofifCasting.xaml
    /// </summary>
    public partial class ViewModifCasting : Window
    {
        public ViewModifCasting()
        {
            InitializeComponent();
        }
        private void SaveButtonModifCastingWindow_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }



    }
}
