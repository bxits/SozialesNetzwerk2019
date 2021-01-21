using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SozialesNetzwerk2019
{
    class Program
    {
        //Hauptprogramm
        static void Main(string[] args)
        {
            SozialesNetzwerk sn = new SozialesNetzwerk();

            Person p1 = new Person("Müller", "Max");
            Person p2 = new Person("Tester", "Tina");

            Textnachricht tn1 = new Textnachricht("Das ist eine Nachricht", p1);
            Textnachricht tn2 = new Textnachricht("Auch das hier ist eine Nachricht.", p2);
            Bildnachricht bn1 = new Bildnachricht("bild1.png", p2);

            sn.HinzufuegenMitglied(p1);
            sn.HinzufuegenMitglied(p2);

            sn.HinzufuegenNachricht(tn1);
            sn.HinzufuegenNachricht(tn2);
            sn.HinzufuegenNachricht(bn1);

            //Hier wird die Polymorphie angewendet...
            string alleNachrichten = sn.GetAlleNachrichten();

        }
    }
}
