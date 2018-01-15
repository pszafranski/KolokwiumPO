using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_1_2018
{
    interface IDruzyna
    {
        void UstawAtak(int a, string imie, string nazwisko, int numer);
        void UstawObrone(int a, string imie, string nazwisko, int numer);
        void UstawNazwe(string nazwa);
        bool CzyOk();
    }
}
