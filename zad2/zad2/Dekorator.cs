using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Dekorator : ITelefon
    {
        protected ITelefon iTelefon;
        protected string typ;

        public Dekorator(ITelefon iTelefon, string typ)
        {
            this.iTelefon = iTelefon;
            this.typ = typ;
        }

        public string WybierzNumer(string nrTelefonu)
        {
            return iTelefon.WybierzNumer(nrTelefonu);
        }
        public string WyslijWiadomosc(string wiadomosc)
        {
            return iTelefon.WyslijWiadomosc(wiadomosc);
        }
        public string PokazTyp()
        {
            return iTelefon.PokazTyp();
        }

    }
}
