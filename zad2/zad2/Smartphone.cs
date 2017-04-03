using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Smartphone : Dekorator
    {
        public Smartphone(ZwyklyTelefon iTelefon, string typ)
            : base(iTelefon, typ)
        {

        }
        public void PrzegladajInternet()
        {
            Console.WriteLine("Włączanie przeglądarki...");
        }
        public void GrajWGre()
        {
            Console.WriteLine("Gra została uruchomiona...");
        }

    }
}
