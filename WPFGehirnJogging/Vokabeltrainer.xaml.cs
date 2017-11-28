using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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


namespace WPFGehirnJogging
{
    /// <summary>
    /// Interaktionslogik für Vokabeltrainer.xaml
    /// </summary>
    public partial class Vokabeltrainer : Page
    {
        private string _pfadCsvDatei;
        OpenFileDialog ofd = new OpenFileDialog();
        public Vokabeltrainer()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Filter für alle CSV Dateien
            ofd.Filter = "CSV files (*.csv)|*.csv|XML files (*.xml)|*.xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TxtPfadCsv.Text = ofd.FileName;
                _pfadCsvDatei = ofd.FileName;
            }

        }
    }
}
