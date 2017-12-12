using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFGehirnJogging.Klassen;
using MessageBox = System.Windows.MessageBox;

namespace WPFGehirnJogging
{
    /// <summary>
    /// Interaktionslogik für Vokabeltrainer.xaml
    /// </summary>
    public partial class Vokabeltrainer : Page
    {
        public Vokabeltrainer()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Uri("Vokabeltrainer2.xaml", UriKind.Relative));
        }
    }
}



