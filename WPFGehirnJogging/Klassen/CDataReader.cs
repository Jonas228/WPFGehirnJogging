using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;

namespace WPFGehirnJogging.Klassen
{
    internal class CDataReader
    {
        public Dictionary<string,string[]> CsvEinlesen(string filesource)
        {
            //Einlesen der CSV Datei und speichern der Vokabeln in ein Dictionary
            if (File.Exists(filesource))
            {
                Dictionary<string, string[]> dic= new Dictionary<string, string[]>();
                string[] lines = File.ReadAllLines(filesource);
                StreamReader streamReader = new StreamReader(filesource);
                var rowValue = streamReader.ReadLine();
                var values = rowValue.Split(';');
                for (var i = 0; i < lines.Length; i++)
                {
                    values = lines[i].Split(separator: ';');
                    var vocab = new CVokabel();
                    vocab.DeutschesWort = values[0];
                    vocab.EnglischesWort = values;
                    dic.Add(vocab.DeutschesWort,vocab.EnglischesWort);
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
