using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string izbor = "";

            do
            {
                Console.WriteLine("========== IZBORNIK ==========");
                for (int i = 1; i <= 24; i++)
                {
                    Console.WriteLine($"{i}. Zadatak {i}");
                }
                Console.WriteLine("0. Kraj");
                Console.WriteLine("==============================");
                Console.Write("Unesite broj zadatka: ");

                izbor = Console.ReadLine();

                switch (izbor)
                {
                    case "1": 
                        Zad01(); 
                        break;
                    case "2": 
                        Zad02(); 
                        break;
                    case "3": 
                        Zad03(); 
                        break;
                    case "4": 
                        Zad04();
                        break;
                    case "5": 
                        Zad05();
                        break;
                    case "6": 
                        Zad06(); 
                        break;
                    case "7": 
                        Zad07();
                        break;
                    case "8": 
                        Zad08();
                        break;
                    case "9": 
                        Zad09();
                        break;
                    case "10": 
                        Zad10();
                        break;
                    case "11": 
                        Zad11();
                        break;
                    case "12": 
                        Zad12();
                        break;
                    case "13": 
                        Zad13();
                        break;
                    case "14": 
                        Zad14();
                        break;
                    case "15": 
                        Zad15();
                        break;
                    case "16":
                        Zad16();
                        break;
                    case "17":
                        Zad17();
                        break;
                    case "18": 
                        Zad18();
                        break;
                    case "19": 
                        Zad19();
                        break;
                    case "20": 
                        Zad20();
                        break;
                    case "21": 
                        Zad21();
                        break;
                    case "22": 
                        Zad22();
                        break;
                    case "23": 
                        Zad23();
                        break;
                    case "24": 
                        Zad24();
                        break;
                    case "0": Console.WriteLine("Kraj programa."); break;
                    default: Console.WriteLine("Nepoznati izbor."); break;
                }

            } while (izbor != "0");
        }

        // METODE ZA RACUNANJE

        static int Zbroji(int a, int b)
        {
            return a + b;
        }

        static int Razlika(int a, int b)
        {
            return a - b;
        }

        static double PovrsinaPravokutnika(double a, double b)
        {
            return a * b;
        }

        static double OpsegKruga(double r)
        {
            return 2 * Math.PI * r;
        }

        static int Kvadrat(int x)
        {
            return x * x;
        }

        static bool JeParan(int n)
        {
            return n % 2 == 0;
        }

        static int Najveci(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }

        static double Prosjek(double a, double b, double c)
        {
            return (a + b + c) / 3;
        }

        static double CijenaSPdvom(double cijena)
        {
            return cijena * 1.25;
        }

        static int Udaljenost(int a, int b)
        {
            return Math.Abs(a - b);
        }

        static bool JePozitivan(int n)
        {
            return n > 0;
        }

        static int Minimum(int a, int b)
        {
            return Math.Min(a, b);
        }

        static int BrojZnamenki(int n)
        {
            return n.ToString().TrimStart('-').Length;
        }

        static bool JeProst(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i <= n / i; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        static int ZbrojZnamenki(int n)
        {
            n = Math.Abs(n);
            int zbroj = 0;

            while (n > 0)
            {
                zbroj += n % 10;
                n /= 10;
            }

            return zbroj;
        }

        static int Faktorijel(int n)
        {
            int rezultat = 1;

            for (int i = 1; i <= n; i++)
            {
                rezultat *= i;
            }

            return rezultat;
        }

        static bool JePalindrom(int n)
        {
            if (n < 0)
                return false;

            int original = n;
            int obrnuti = 0;

            while (n > 0)
            {
                obrnuti = obrnuti * 10 + n % 10;
                n /= 10;
            }

            return original == obrnuti;
        }

        static int Potencija(int a, int n)
        {
            int rezultat = 1;

            for (int i = 0; i < n; i++)
            {
                rezultat *= a;
            }

            return rezultat;
        }

        static string Ponovi(string tekst, int n)
        {
            string rezultat = "";

            for (int i = 0; i < n; i++)
            {
                rezultat += tekst;
            }

            return rezultat;
        }

        static int NajveciZajednickiDjelitelj(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int ostatak = a % b;
                a = b;
                b = ostatak;
            }

            return a;
        }

        static bool JeDjeljiv(int a, int b)
        {
            if (b == 0)
                return false;

            return a % b == 0;
        }

        static int ZbrojOdDo(int a, int b)
        {
            int zbroj = 0;

            if (a > b)
            {
                int pomocni = a;
                a = b;
                b = pomocni;
            }

            for (int i = a; i <= b; i++)
            {
                zbroj += i;
            }

            return zbroj;
        }

        static int Fibonacci(int n)
        {
            if (n == 0)
                return 0;

            if (n == 1)
                return 1;

            int prethodni = 0;
            int trenutni = 1;

            for (int i = 2; i <= n; i++)
            {
                int sljedeci = prethodni + trenutni;
                prethodni = trenutni;
                trenutni = sljedeci;
            }

            return trenutni;
        }

        // ZADATAK 1
        static void Zad01()
        {
            Console.WriteLine("---------- Zadatak 1 ----------");
            Console.Write("Unesi prvi broj: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Unesi drugi broj: ");
            int b = int.Parse(Console.ReadLine());

            int zbroj = Zbroji(a, b);
            Console.WriteLine($"Zbroj je: {zbroj}");
        }

        // ZADATAK 2
        static void Zad02()
        {
            Console.WriteLine("---------- Zadatak 2 ----------");
            Console.Write("Unesi prvi broj: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Unesi drugi broj: ");
            int b = int.Parse(Console.ReadLine());

            int razlika = Razlika(a, b);
            Console.WriteLine($"Razlika je: {razlika}");
        }

        // ZADATAK 3
        static void Zad03()
        {
            Console.WriteLine("---------- Zadatak 3 ----------");
            Console.Write("Unesi stranicu A: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Unesi stranicu B: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine($"Povrsina pravokutnika je: {PovrsinaPravokutnika(a, b)}");
        }

        // ZADATAK 4
        static void Zad04()
        {
            Console.WriteLine("---------- Zadatak 4 ----------");
            Console.Write("Unesi polumjer kruga: ");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine($"Opseg kruga je: {OpsegKruga(r):F2}");
        }

        // ZADATAK 5
        static void Zad05()
        {
            Console.WriteLine("---------- Zadatak 5 ----------");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Kvadrat broja {i} je {Kvadrat(i)}");
            }
        }

        // ZADATAK 6
        static void Zad06()
        {
            Console.WriteLine("---------- Zadatak 6 ----------");
            Console.Write("Unesi broj: ");
            int n = int.Parse(Console.ReadLine());

            if (JeParan(n))
                Console.WriteLine("Broj je paran.");
            else
                Console.WriteLine("Broj nije paran.");
        }

        // ZADATAK 7
        static void Zad07()
        {
            Console.WriteLine("---------- Zadatak 7 ----------");
            Console.Write("Unesi prvi broj: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Unesi drugi broj: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Unesi treci broj: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine($"Najveci broj je: {Najveci(a, b, c)}");
        }

        // ZADATAK 8
        static void Zad08()
        {
            Console.WriteLine("---------- Zadatak 8 ----------");
            Console.Write("Unesi prvi broj: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Unesi drugi broj: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Unesi treci broj: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine($"Prosjek je: {Prosjek(a, b, c):F2}");
        }

        // ZADATAK 9
        static void Zad09()
        {
            Console.WriteLine("---------- Zadatak 9 ----------");
            Console.Write("Unesi cijenu proizvoda: ");
            double cijena = double.Parse(Console.ReadLine());

            Console.WriteLine($"Cijena s PDV-om je: {CijenaSPdvom(cijena):F2}");
        }

        // ZADATAK 10
        static void Zad10()
        {
            Console.WriteLine("---------- Zadatak 10 ----------");
            Console.Write("Unesi prvi broj: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Unesi drugi broj: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Udaljenost je: {Udaljenost(a, b)}");
        }

        // ZADATAK 11
        static void Zad11()
        {
            Console.WriteLine("---------- Zadatak 11 ----------");

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Unesi {i}. broj: ");
                int n = int.Parse(Console.ReadLine());

                if (JePozitivan(n))
                    Console.WriteLine("Broj je pozitivan.");
                else
                    Console.WriteLine("Broj nije pozitivan.");
            }
        }

        // ZADATAK 12
        static void Zad12()
        {
            Console.WriteLine("---------- Zadatak 12 ----------");
            Console.Write("Unesi prvi broj: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Unesi drugi broj: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Manji broj je: {Minimum(a, b)}");
        }

        // ZADATAK 13
        static void Zad13()
        {
            Console.WriteLine("---------- Zadatak 13 ----------");
            Console.Write("Unesi cijeli broj: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Broj znamenki je: {BrojZnamenki(n)}");
        }

        // ZADATAK 14
        static void Zad14()
        {
            Console.WriteLine("---------- Zadatak 14 ----------");
            Console.WriteLine("Prosti brojevi od 1 do 100:");

            for (int i = 1; i <= 100; i++)
            {
                if (JeProst(i))
                    Console.Write(i + " ");
            }

            Console.WriteLine();
        }

        // ZADATAK 15
        static void Zad15()
        {
            Console.WriteLine("---------- Zadatak 15 ----------");
            Console.Write("Unesi prirodni broj: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Zbroj znamenki je: {ZbrojZnamenki(n)}");
        }

        // ZADATAK 16
        static void Zad16()
        {
            Console.WriteLine("---------- Zadatak 16 ----------");
            Console.Write("Unesi prirodni broj od 0 do 12: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0 || n > 12)
            {
                Console.WriteLine("Broj mora biti od 0 do 12.");
                return;
            }

            Console.WriteLine($"Faktorijel broja {n} je: {Faktorijel(n)}");
        }

        // ZADATAK 17
        static void Zad17()
        {
            Console.WriteLine("---------- Zadatak 17 ----------");
            Console.Write("Unesi broj: ");
            int n = int.Parse(Console.ReadLine());

            if (JePalindrom(n))
                Console.WriteLine("Broj je palindrom.");
            else
                Console.WriteLine("Broj nije palindrom.");
        }

        // ZADATAK 18
        static void Zad18()
        {
            Console.WriteLine("---------- Zadatak 18 ----------");
            Console.Write("Unesi bazu a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Unesi nenegativni eksponent n (0-31): ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0 || n > 31)
            {
                Console.WriteLine("Eksponent mora biti od 0 do 31.");
                return;
            }

            Console.WriteLine($"Rezultat je: {Potencija(a, n)}");
        }

        // ZADATAK 19
        static void Zad19()
        {
            Console.WriteLine("---------- Zadatak 19 ----------");
            Console.Write("Unesi tekst: ");
            string tekst = Console.ReadLine();

            Console.Write("Koliko puta ponoviti tekst: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Broj ponavljanja ne moze biti negativan.");
                return;
            }

            Console.WriteLine($"Rezultat: {Ponovi(tekst, n)}");
        }

        // ZADATAK 20
        static void Zad20()
        {
            Console.WriteLine("---------- Zadatak 20 ----------");
            Console.Write("Unesi prvi prirodni broj: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Unesi drugi prirodni broj: ");
            int b = int.Parse(Console.ReadLine());

            if (a < 0 || b < 0 || (a == 0 && b == 0))
            {
                Console.WriteLine("Unesi nenegativne brojeve, ali ne obje nule.");
                return;
            }

            Console.WriteLine($"Najveci zajednicki djelitelj je: {NajveciZajednickiDjelitelj(a, b)}");
        }

        // ZADATAK 21
        static void BezParametaraBezPovratneVrijednosti()
        {
            Console.WriteLine("Pozvana je metoda bez parametara i bez povratne vrijednosti.");
        }

        static void SParametrimaBezPovratneVrijednosti(int broj)
        {
            Console.WriteLine($"Primljeni broj je: {broj}");
        }

        static int BezParametaraSPovratnomVrijednosti()
        {
            return 100;
        }

        static int SParametrimaSPovratnomVrijednosti(int a, int b)
        {
            return a + b;
        }

        static void Zad21()
        {
            Console.WriteLine("---------- Zadatak 21 ----------");

            BezParametaraBezPovratneVrijednosti();

            SParametrimaBezPovratneVrijednosti(5);

            int broj = BezParametaraSPovratnomVrijednosti();
            Console.WriteLine($"Vraca vrijednost: {broj}");

            int zbroj = SParametrimaSPovratnomVrijednosti(3, 7);
            Console.WriteLine($"Zbroj je: {zbroj}");
        }

        // ZADATAK 22
        static void Zad22()
        {
            Console.WriteLine("---------- Zadatak 22 ----------");
            Console.Write("Unesi broj a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Unesi broj b: ");
            int b = int.Parse(Console.ReadLine());

            if (b == 0)
            {
                Console.WriteLine("Dijeljenje nulom nije dozvoljeno.");
            }
            else if (JeDjeljiv(a, b))
            {
                Console.WriteLine("Broj a je djeljiv brojem b.");
            }
            else
            {
                Console.WriteLine("Broj a nije djeljiv brojem b.");
            }
        }

        // ZADATAK 23
        static void Zad23()
        {
            Console.WriteLine("---------- Zadatak 23 ----------");
            Console.Write("Unesi pocetni broj a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Unesi zavrsni broj b: ");
            int b = int.Parse(Console.ReadLine());

            if (a < 0 || b < 0)
            {
                Console.WriteLine("Unesi prirodne brojeve.");
                return;
            }

            Console.WriteLine($"Zbroj brojeva je: {ZbrojOdDo(a, b)}");
        }

        // ZADATAK 24
        static void Zad24()
        {
            Console.WriteLine("---------- Zadatak 24 ----------");
            Console.Write("Unesi n (od 0 do 46): ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0 || n > 46)
            {
                Console.WriteLine("n mora biti od 0 do 46.");
                return;
            }

            Console.WriteLine($"{n}. clan Fibonaccijeva niza je: {Fibonacci(n)}");
        }
    }
}