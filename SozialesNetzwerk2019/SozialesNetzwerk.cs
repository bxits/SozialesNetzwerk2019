using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SozialesNetzwerk2019
{
    class SozialesNetzwerk
    {
        private List<Nachricht> _nachrichtenListe;
        private List<Person> _mitgliederListe;

        public SozialesNetzwerk()
        {
            _nachrichtenListe = new List<Nachricht>();
            _mitgliederListe = new List<Person>();
        }

        public void HinzufuegenMitglied(Person p)
        {
            _mitgliederListe.Add(p);
        }

        //Es können Textnachricht und Bildnachricht übernommen werden.
        public void HinzufuegenNachricht(Nachricht n)
        {
            _nachrichtenListe.Add(n);
        }

        //Hier wird die Polymorphie angewedet...
        public string GetAlleNachrichten()
        {
            string alleNachrichten = string.Empty;

            foreach (Nachricht nachricht in _nachrichtenListe)
            {
                //                                 polymorpher Methodenaufruf
                alleNachrichten = alleNachrichten + nachricht.GetNachricht();
            } 

            return alleNachrichten;
        }
    }
}
