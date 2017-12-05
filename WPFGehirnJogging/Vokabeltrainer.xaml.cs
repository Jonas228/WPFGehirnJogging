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
        private string _pfadCsvDatei;
        readonly OpenFileDialog _ofd = new OpenFileDialog();
        public Vokabeltrainer()
        {
            InitializeComponent();
            CDataReader cdr = new CDataReader();
            //Einlesen der CSV Datei
            string filesource = "C:\\Users\\jonaspenner\\source\\repos\\WPFGehirnJogging\\vl.csv";
            Dictionary<string, string[]> dic_Vokabel = new Dictionary<string, string[]>();
            dic_Vokabel = cdr.CsvEinlesen(filesource);
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Filter für alle CSV Dateien
            _ofd.Filter = "CSV files (*.csv)|*.csv|XML files (*.xml)|*.xml";
            if (_ofd.ShowDialog() == DialogResult.OK)
            {
                //TxtPfadCsv.Text = ofd.FileName;
                //_pfadCsvDatei = ofd.FileName;
            }

        }

        //private void Page_Loaded(object sender, RoutedEventArgs e)
        //{
        //    System.Windows.Forms.Integration.WindowsFormsHost host = new System.Windows.Forms.Integration.WindowsFormsHost();
        //    NumericUpDown numUpDown = new NumericUpDown();
        //    // Assign the NumericUpDown control as the host control's child.
        //    host.Child = numUpDown;
        //    host.TabIndex = 0;
        //    host.FontSize = 24;
            
        //    SettingVokabeltrainer.Children.Add(host);
            
        //}

        ////http://www.c-sharpcorner.com/uploadfile/mahesh/numericupdown-in-C-Sharp/
    }
}



