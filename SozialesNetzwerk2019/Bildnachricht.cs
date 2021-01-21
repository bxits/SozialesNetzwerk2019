using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SozialesNetzwerk2019
{
    class Bildnachricht : Nachricht
    {
        private string _dateiname;

        public Bildnachricht()
        {
            _dateiname = string.Empty;
        }

        public Bildnachricht(string dateiname, Person absender)
        {
            _dateiname = dateiname;
            _absender = absender;
        }

        //Die Basisklasse zwingt die ableitende Klasse, die Methode
        //GetNachricht() zu überschreiben.
        //Diese Methode hier macht die spezifischen Aufgaben für 
        //eine BILDnachricht.
        public override string GetNachricht()
        {
            //throw new NotImplementedException();
            return _absender.getVorname() + " " +
                _absender.getNachname() + ": " +
                _dateiname;
        }
    }
}
