using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SozialesNetzwerk2019
{
    class Textnachricht : Nachricht
    {
        private string _nachrichtenText;

        public Textnachricht()
        {
            _nachrichtenText = string.Empty;
        }

        public Textnachricht(string nachricht, Person absender)
        {
            _absender = absender;
            _nachrichtenText = nachricht;
        }


        //Die Basisklasse zwingt die ableitende Klasse, die Methode
        //GetNachricht() zu überschreiben.
        //Diese Methode hier macht die spezifischen Aufgaben für 
        //eine TEXTnachricht.
        public override string GetNachricht()
        {
            return _absender.getVorname() + " " +
                _absender.getNachname() + ": " +
                _nachrichtenText;
        }
    }
}
