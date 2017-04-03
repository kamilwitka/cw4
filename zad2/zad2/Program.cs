using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            ZwyklyTelefon zwyklyTelefon = new ZwyklyTelefon("Samsung");
            Smartphone smartphone = new Smartphone(zwyklyTelefon, "IPhone");
            Console.WriteLine(zwyklyTelefon.WybierzNumer("500123123"));
            Console.WriteLine(zwyklyTelefon.WyslijWiadomosc("Treść wiadomości..."));
            zwyklyTelefon.PokazTyp();


            Console.WriteLine(smartphone.WybierzNumer("500123123"));
            Console.WriteLine(smartphone.WyslijWiadomosc("Treść wiadomości..."));
            smartphone.PokazTyp();
            smartphone.PrzegladajInternet();
            smartphone.GrajWGre();

            Console.ReadLine();
        }
    }
}
