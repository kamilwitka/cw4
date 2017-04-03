using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Uczelnia UWM = new Uczelnia(new DateTime(2017, 8, 10));
    //        Uczelnia Stanford = new Uczelnia(new DateTime(2017, 7, 22));

    //        UWM.RekrutujStudentow();
    //        Stanford.RekrutujStudentow();
    //    }

    //}


    public class Program
    {
        static void Main(string[] args)
        {
            Uczelnia UWM = Uczelnia.Instance;
            Uczelnia Stanford = Uczelnia.Instance;

            UWM.RekrutujStudentow();
            Stanford.RekrutujStudentow();
            
        }
    }

}
