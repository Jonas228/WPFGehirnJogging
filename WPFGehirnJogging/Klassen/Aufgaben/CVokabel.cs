using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFGehirnJogging.Klassen
{
    internal class CVokabel : CAufgaben
    {
        private string _deutscheWort, _userEingabe;
        private string[] _englischesWort;
        private int _anzahlRichtig, _anzahlFalsch;

        public CVokabel()
        {
            _deutscheWort="";
            _userEingabe = "";
            _anzahlFalsch = 0;
            _anzahlRichtig = 0;
        }

        public string DeutschesWort { get => _deutscheWort; set => _deutscheWort = value; }
        public string UserEingabe { get => _userEingabe; set => _userEingabe = value; }
        public string[] EnglischesWort { get => _englischesWort; set => _englischesWort = value; }
        public int AnzahlFalsch { get => _anzahlFalsch; set => _anzahlFalsch = value; }
        public int AnzahlRichtig { get => _anzahlRichtig; set => _anzahlRichtig = value; }

        public override void DisplayResult()
        {
            
        }

        public override bool CheckResult(string Result)
        {
            return EnglischesWort.Contains(Result);
        }
        
    }
}
