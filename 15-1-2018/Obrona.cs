using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_1_2018
{
    class Obrona : Siatkarz
    {
        public Obrona(string imie, string nazwisko, int numerNaKoszulce)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.numerNaKoszulce = numerNaKoszulce;
        }

        public override string ToString()
        {
            return "Obrona: " + base.ToString();
        }
    }
}
