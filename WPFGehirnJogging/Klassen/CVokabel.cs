using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFGehirnJogging.Klassen
{
    internal class CVokabel
    {
        private string _deutscheWort;
        private string[] _englischesWort;
        private int _anzahlRichtig, _anzahlFalsch;

        public CVokabel()
        {
            
        }

        public string DeutschesWort { get => _deutscheWort; set => _deutscheWort = value; }
        public string[] EnglischesWort { get => _englischesWort; set => _englischesWort = value; }
        public int AnzahlFalsch { get => _anzahlFalsch; set => _anzahlFalsch = value; }
        public int AnzahlRichtig { get => _anzahlRichtig; set => _anzahlRichtig = value; }
    }
}
