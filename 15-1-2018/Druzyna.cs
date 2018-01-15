using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_1_2018
{
    class Druzyna : IDruzyna
    {
        private string nazwa;
        private Siatkarz[,] druzyna = new Siatkarz[4,2];

        public void UstawAtak(int a, string imie, string nazwisko, int numer)
        {
            if (numer % 2 == 0) throw new BlednyNumerException("Bledny numer");
            druzyna[a, 1] = new Atak(imie, nazwisko, numer);
        }

        public void UstawObrone(int a, string imie, string nazwisko, int numer)
        {
            if (numer % 2 == 1) throw new BlednyNumerException("Bledny numer");
            druzyna[a, 0] = new Obrona(imie, nazwisko, numer);
        }

        public void UstawNazwe(string nazwa)
        {
            this.nazwa = nazwa;
        }

        public bool CzyOk()
        {
            
            foreach (var element in druzyna)
            {
                if (ReferenceEquals(element, null)) return false;
            }
            return true;
        }

        public override string ToString()
        {
            string temp = "";
            int i, j;

            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    if (!ReferenceEquals(druzyna[i, j], null))
                        temp += "[" + i + "]" + "[" + j + "] " + druzyna[i, j].ToString() + Environment.NewLine;
                }
            }
                return temp;
        }
    }
}
