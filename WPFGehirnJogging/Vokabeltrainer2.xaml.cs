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
using MessageBox = System.Windows.MessageBox;

namespace WPFGehirnJogging
{
    /// <summary>
    /// Interaktionslogik für Vokabeltrainer2.xaml
    /// </summary>
    public partial class Vokabeltrainer2 : Page
    {
        private Dictionary<string, string[]> _dicVokabel;
        private int pZuffi;

        public Vokabeltrainer2()
        {
            InitializeComponent();
            //Eventhandler der das Event von dem Button abfängt

            CVokabeltest test = new CVokabeltest();
            //Einlesen des Vokabulars
            _dicVokabel = new Dictionary<string, string[]>();
            _dicVokabel = test.CsvEinlesen();
            CVokabel first = new CVokabel();
            first.DeutschesWort = "auto";
            first.UserEingabe = "car";
            string[] foo = new string[3];
            //sucht alle Lösungen aus dem Dictionary für die Vokabel und speichert es in die Vokabel
            _dicVokabel.TryGetValue(first.DeutschesWort, out foo);
            //speichert alle Englischen Wörter in das EnglischeWort Array
            first.EnglischesWort = foo;
            for (int i = 1; i < foo.Length - 1; i++)
            {
                first.EnglischesWort[i - 1] = foo[i];
            }
            ZufäligVokabelnAusgeben();
            //Return ob richtig oder falsch
            if (first.CheckResult(first.UserEingabe))
            {
                MessageBox.Show("Richtig");
                first.AnzahlRichtig++;
            }
            else
            {
                MessageBox.Show("Falsch");
                first.AnzahlFalsch++;
            }
        }

        void ZufäligVokabelnAusgeben()
        {
            Random rnd = new Random();
            pZuffi = rnd.Next(_dicVokabel.Count);
            //return _dicVokabel.ElementAt(rnd.Next(0, _dicVokabel.Count)).Value;
            string xs = _dicVokabel.ElementAt(pZuffi).Key;
            //schreibe string in das Label


        }
    }
}
