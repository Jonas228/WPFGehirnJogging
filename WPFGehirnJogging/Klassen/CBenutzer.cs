using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFGehirnJogging.Klassen
{
    class CBenutzer
    {
        private string _vorname, _nachname;
        private int _sucessindicator;

        public CBenutzer(string Vorname, string Nachname)
        {
            _vorname = Vorname;
            _nachname = Nachname;
            _sucessindicator = 0;
        }
    }
}
