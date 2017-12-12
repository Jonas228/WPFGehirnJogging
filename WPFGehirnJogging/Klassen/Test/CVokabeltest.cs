using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WPFGehirnJogging.Klassen
{
    class CVokabeltest:CTest
    {
        public CVokabeltest()
        {
            
        }

        public Dictionary<string, string[]> CsvEinlesen()
        {
            //Einlesen der CSV Datei und speichern der Vokabeln in ein Dictionary
            string filesource = "C:\\Users\\jonaspenner\\source\\repos\\WPFGehirnJogging\\vl.csv";
            if (File.Exists(filesource))
            {
                Dictionary<string, string[]> dic = new Dictionary<string, string[]>();
                string[] lines = File.ReadAllLines(filesource);
                StreamReader streamReader = new StreamReader(filesource);
                var rowValue = streamReader.ReadLine();
                var values = rowValue.Split(';');
                for (var i = 0; i < lines.Length; i++)
                {
                    values = lines[i].Split(separator: ';');
                    //Deklaration von der Vokabel
                    var vocab = new CVokabel
                    {
                        DeutschesWort = values[0],
                        EnglischesWort = values
                    };
                    dic.Add(vocab.DeutschesWort, vocab.EnglischesWort);
                }
                return dic;
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
    }
}
