using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SozialesNetzwerk2019
{
    class Person
    {
        private string _nachname;   //= ""; ODER = string.Empty;
        private string _vorname;    //= ""; ODER = string.Empty;

        public Person()
        {
            _nachname = "";
            _vorname = "";
        }

        public Person (string nn, string vn)
        {
            _nachname = nn;
            _vorname = vn;
        }

        public string getNachname()
        {
            return _nachname;
        }

        public string getVorname()
        {
            return _vorname;
        }

        //Alternativ mit C#-Properties
        //Wichtig, um konform mit dem UML-Diagramm zu sein:
        //"private set;" blendet den set-ZugriffsMod. nach außen aus.
        //Auf Felder kann in diesem Fall auch verzichtet werden.
        public string Nachname { get; private set; }
        public string Vorname { get; private set; }
    }
}
