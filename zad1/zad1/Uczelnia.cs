using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{

    public sealed class Uczelnia
    {
        private static Uczelnia m_oInstance = null;
        public DateTime dataRekrutacji;

        private Uczelnia(DateTime dataRekrutacji)
        {
            this.dataRekrutacji = dataRekrutacji;
        }

        public static Uczelnia Instance
        {
            get
                {

                if (m_oInstance == null)
                {
                    m_oInstance = new Uczelnia(new DateTime(2017, 8, 10));
                }
            return m_oInstance;
            }
        }
        public void RekrutujStudentow()
        {
            Console.WriteLine("Następna rekrutacja odbędzie się {0}.\n", dataRekrutacji.ToShortDateString());
            Console.ReadLine();
        }
    }


}