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
using WPFGehirnJogging.Klassen;

namespace WPFGehirnJogging
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            double Width = SystemParameters.PrimaryScreenWidth;
            double Height = SystemParameters.PrimaryScreenHeight;
            this.Width = Width;
            this.Height = Height;
            this.ResizeMode = ResizeMode.NoResize;
            //Iniatilisierung von NavigationService
            NavigationService navigationService = NavigationService.GetNavigationService(this);
            Loaded += MainWindow_Loaded;

        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //Beim Starten wird das Menü in das MainFrame geladen
            MainFrame.NavigationService.Navigate(new Uri("Menü.xaml", UriKind.Relative));
        }
    }
}
