using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SozialesNetzwerk2019
{
    abstract class Nachricht
    {
        protected int _likes;
        protected Person _absender;

        public Nachricht()
        {

        }

        public Nachricht(Person absender)
        {
            _absender = absender;
        }

        public void HinzufügenLike()
        {
            _likes++;
        }

        public abstract string GetNachricht(); 
        //Hat keinen Methodenkörper,
        //also, enthält keine Programmlogik.
        //Diese Klasse "Nachricht" gibt vor, dass die ableitenden Klassen
        //Diese Methode implementieren müssen.
    }
}
