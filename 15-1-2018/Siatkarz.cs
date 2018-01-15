using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_1_2018
{
    abstract class Siatkarz
    {
        protected string imie, nazwisko;
        protected int numerNaKoszulce;

        public override string ToString()
        {
            return imie + " " + nazwisko + ", " + numerNaKoszulce;
        }
    }
}
