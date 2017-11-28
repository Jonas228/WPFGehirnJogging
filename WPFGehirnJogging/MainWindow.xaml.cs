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
            CDataReader cdr = new CDataReader();

            string filesource = "C:\\Users\\jonaspenner\\source\\repos\\WPFGehirnJogging\\vl.csv";
            Dictionary<string, string[]> dic_Vokabel = new Dictionary<string, string[]>();
            dic_Vokabel = cdr.CsvEinlesen(filesource);


        }

    }
}
