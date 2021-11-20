using MegaCastWPF.ViewModel;
using MegaCastWPF.Views;
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

namespace MegaCastWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        
        }
        private void MenuItem_Exit_Click(object sender, RoutedEventArgs e)
        {
            ((Window)this.Parent).Close();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ButtonBroadcasteur_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanel.Children.Clear();
            ViewModelBroadcaster vm = new ViewModelBroadcaster();
            ViewBroadcaster view = new ViewBroadcaster();
            view.DataContext = vm;
                
            this.DockPanel.Children.Add(view);
        }

        private void ButtonArtist_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanel.Children.Clear();
            ViewModelArtist vm = new ViewModelArtist();
            ViewArtist view = new ViewArtist();
            view.DataContext = vm;

            this.DockPanel.Children.Add(view);

        }
        private void ButtonCasting_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanel.Children.Clear();
            ViewModelCasting vm = new ViewModelCasting();
            ViewCasting view = new ViewCasting();
            view.DataContext = vm;

            this.DockPanel.Children.Add(view);
        }

    }
}
