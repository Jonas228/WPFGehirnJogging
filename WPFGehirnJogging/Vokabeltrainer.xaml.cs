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
            
            //Einlesen der CSV Datei
            //string filesource = "C:\\Users\\jonaspenner\\source\\repos\\WPFGehirnJogging\\vl.csv";
            //Dictionary<string, string[]> dic_Vokabel = new Dictionary<string, string[]>();
            //dic_Vokabel = cdr.CsvEinlesen(filesource);
           
        }

    }
}



