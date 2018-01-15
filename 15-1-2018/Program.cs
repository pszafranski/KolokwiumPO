using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_1_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            char choice;
            string imie, nazwisko, nazwa;
            int numer, at = 0, def = 0;

            Druzyna team = new Druzyna();

            Menu();

            choice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            while ((choice != 'X') && (choice != 'x'))
            {
                switch (choice)
                {
                    case 'A':
                    case 'a':
                        try
                        {
                            if (at >= 4) throw new BlednyNumerException("Druzyna pelna");
                        }
                        catch (BlednyNumerException e)
                        {
                            Console.WriteLine(e.Message);
                            break;
                        }
                        Console.WriteLine("Podaj imie i nazwisko");
                        imie = Console.ReadLine();
                        nazwisko = Console.ReadLine();
                        Console.WriteLine("Podaj numer na koszulce");
                        numer = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            team.UstawAtak(at++, imie, nazwisko, numer);
                        }
                        catch (BlednyNumerException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    case 'B':
                    case 'b':
                        try
                        {
                            if (def >= 4) throw new BlednyNumerException("Druzyna pelna");
                        }
                        catch (BlednyNumerException e)
                        {
                            Console.WriteLine(e.Message);
                            break;
                        }
                        Console.WriteLine("Podaj imie i nazwisko");
                        imie = Console.ReadLine();
                        nazwisko = Console.ReadLine();
                        Console.WriteLine("Podaj numer na koszulce");
                        numer = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            team.UstawObrone(def++, imie, nazwisko, numer);
                        }
                        catch (BlednyNumerException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    case 'C':
                    case 'c':
                        if (team.CzyOk() == true)
                        {
                            Console.WriteLine("Podaj nazwe");
                            nazwa = Console.ReadLine();

                            Console.WriteLine("Pomyslnie ustawiono nazwe druzyny");
                        }
                        else Console.WriteLine("Nie mozesz ustawic nazwy niepelnej druzyny");
                        break;

                    //case 'D':
                    //case 'd':
                    //    Console.WriteLine(team.ToString());
                    //    break;

                    case 'X':
                    case 'x':
                        Console.WriteLine("Exit");
                        break;

                    default:
                        Console.WriteLine("Zly wybor");
                        break;
                }

                Menu();
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static void Menu()
        {
            Console.WriteLine("Co chcesz zrobic?");
            Console.WriteLine("A - ustaw atak");
            Console.WriteLine("B - ustaw obrone");
            Console.WriteLine("C - ustaw nazwe");
            Console.WriteLine("D - wypisz druzyne");
            Console.WriteLine("X - wyjscie");
        }
    }
}
