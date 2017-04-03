using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    interface ITelefon
    {
        string WybierzNumer(string nrTelefonu);
        string WyslijWiadomosc(string wiadomosc);
        string PokazTyp();
    }
}
