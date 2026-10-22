using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba5
{
    internal class Program
    {
        // STATIC VARIJABLE
        static int brojac = 0;
        static double PDV = 0.25;
        static int zbroj = 0;
        static int posjeti = 0;
        static double stanje = 0;
        static int broj = 10;

        static void Main()
        {
            string izbor;

            do
            {
                Console.WriteLine("\n========== IZBORNIK ==========");
                Console.WriteLine("1. Zadatak 1 - 6. sat");
                Console.WriteLine("2. Zadatak 2 - 6. sat");
                Console.WriteLine("3. Zadatak 3 - 6. sat");
                Console.WriteLine("4. Zadatak 4 - 6. sat");
                Console.WriteLine("5. Zadatak 5 - 6. sat");
                Console.WriteLine("6. Zadatak 6 - 6. sat");
                Console.WriteLine("7. Zadatak 7 - 6. sat");
                Console.WriteLine("8. Zadatak 8 - 6. sat");
                Console.WriteLine("9. Zadatak 1 - 7. sat");
                Console.WriteLine("10. Zadatak 2 - 7. sat");
                Console.WriteLine("11. Zadatak 3 - 7. sat");
                Console.WriteLine("12. Zadatak 4 - 7. sat");
                Console.WriteLine("13. Zadatak 5 - 7. sat");
                Console.WriteLine("14. Zadatak 6 - 7. sat");
                Console.WriteLine("15. Zadatak 7 - 7. sat");
                Console.WriteLine("16. Zadatak 8 - 7. sat");
                Console.WriteLine("17. Zadatak 9 - 7. sat");
                Console.WriteLine("0. Kraj");
                Console.WriteLine("==============================");
                Console.Write("Unesite broj zadatka: ");

                izbor = Console.ReadLine();

                switch (izbor)
                {
                    case "1": Zad01(); break;
                    case "2": Zad02(); break;
                    case "3": Zad03(); break;
                    case "4": Zad04(); break;
                    case "5": Zad05(); break;
                    case "6": Zad06(); break;
                    case "7": Zad07(); break;
                    case "8": Zad08(); break;
                    case "9": Zad10(); break;
                    case "10": Zad11(); break;
                    case "11": Zad12(); break;
                    case "12": Zad13(); break;
                    case "13": Zad14(); break;
                    case "14": Zad15(); break;
                    case "15": Zad16(); break;
                    case "16": Zad17(); break;
                    case "17": Zad18(); break;

                    case "0":
                        Console.WriteLine("Kraj programa.");
                        break;

                    default:
                        Console.WriteLine("Neispravan odabir!");
                        break;
                }

            } while (izbor != "0");
        }

        // =========================
        // 6. SAT
        // =========================

        // ZADATAK 1 - Brojac
        static void Zad01()
        {
            string izbor;

            do
            {
                Console.WriteLine("\n--- ZADATAK 1 ---");
                Console.WriteLine("1 - Povecaj brojac pet puta");
                Console.WriteLine("0 - Povratak");
                izbor = Console.ReadLine();

                if (izbor == "1")
                {
                    for (int i = 0; i < 5; i++)
                    {
                        brojac++;
                    }

                    Console.WriteLine("Vrijednost brojaca: " + brojac);
                }

            } while (izbor != "0");
        }

        // ZADATAK 2 - Zbroj dva broja
        static void Zad02()
        {
            string izbor;

            do
            {
                Console.WriteLine("\n--- ZADATAK 2 ---");
                Console.WriteLine("1 - Zbroji dva broja");
                Console.WriteLine("0 - Povratak");
                izbor = Console.ReadLine();

                if (izbor == "1")
                {
                    Console.Write("Unesi prvi broj: ");
                    int a = int.Parse(Console.ReadLine());

                    Console.Write("Unesi drugi broj: ");
                    int b = int.Parse(Console.ReadLine());

                    Console.WriteLine("Zbroj je: " + (a + b));
                }

            } while (izbor != "0");
        }

        // ZADATAK 3 - Cijena s PDV-om
        static void Zad03()
        {
            string izbor;

            do
            {
                Console.WriteLine("\n--- ZADATAK 3 ---");
                Console.WriteLine("1 - Izracunaj cijenu s PDV-om");
                Console.WriteLine("0 - Povratak");
                izbor = Console.ReadLine();

                if (izbor == "1")
                {
                    Console.Write("Unesi cijenu bez PDV-a: ");
                    double cijena = double.Parse(Console.ReadLine());

                    double konacnaCijena = cijena * (1 + PDV);

                    Console.WriteLine("Cijena s PDV-om: " +
                        konacnaCijena.ToString("F2"));
                }

            } while (izbor != "0");
        }

        // ZADATAK 4 - Opseg i povrsina pravokutnika
        static void Zad04()
        {
            string izbor;

            do
            {
                Console.WriteLine("\n--- ZADATAK 4 ---");
                Console.WriteLine("1 - Izracunaj opseg i povrsinu");
                Console.WriteLine("0 - Povratak");
                izbor = Console.ReadLine();

                if (izbor == "1")
                {
                    Console.Write("Unesi sirinu: ");
                    double sirina = double.Parse(Console.ReadLine());

                    Console.Write("Unesi visinu: ");
                    double visina = double.Parse(Console.ReadLine());

                    double opseg = 2 * (sirina + visina);
                    double povrsina = sirina * visina;

                    Console.WriteLine("Opseg: " + opseg);
                    Console.WriteLine("Povrsina: " + povrsina);
                }

            } while (izbor != "0");
        }

        // ZADATAK 5 - Globalni zbroj
        static void Zad05()
        {
            string izbor;

            do
            {
                Console.WriteLine("\n--- ZADATAK 5 ---");
                Console.WriteLine("1 - Dodaj broj u zbroj");
                Console.WriteLine("2 - Ispisi zbroj");
                Console.WriteLine("0 - Povratak");
                izbor = Console.ReadLine();

                if (izbor == "1")
                {
                    Console.Write("Unesi broj: ");
                    int brojZaDodati = int.Parse(Console.ReadLine());

                    zbroj += brojZaDodati;
                    Console.WriteLine("Broj je dodan.");
                }
                else if (izbor == "2")
                {
                    Console.WriteLine("Ukupni zbroj: " + zbroj);
                }

            } while (izbor != "0");
        }

        // ZADATAK 6 - Brojanje posjeta
        static void Zad06()
        {
            string izbor;

            do
            {
                Console.WriteLine("\n--- ZADATAK 6 ---");
                Console.WriteLine("1 - Zabiljezi posjet");
                Console.WriteLine("2 - Prikazi broj posjeta");
                Console.WriteLine("0 - Povratak");
                izbor = Console.ReadLine();

                if (izbor == "1")
                {
                    posjeti++;
                    Console.WriteLine("Posjet je zabiljezen.");
                }
                else if (izbor == "2")
                {
                    Console.WriteLine("Broj posjeta: " + posjeti);
                }

            } while (izbor != "0");
        }

        // ZADATAK 7 - Bankovni racun
        static void Zad07()
        {
            string izbor;

            do
            {
                Console.WriteLine("\n--- ZADATAK 7 ---");
                Console.WriteLine("1 - Uplati novac");
                Console.WriteLine("2 - Podigni novac");
                Console.WriteLine("3 - Prikazi stanje");
                Console.WriteLine("0 - Povratak");
                izbor = Console.ReadLine();

                if (izbor == "1")
                {
                    Console.Write("Iznos uplate: ");
                    double iznos = double.Parse(Console.ReadLine());

                    if (iznos > 0)
                    {
                        stanje += iznos;
                        Console.WriteLine("Uplata je uspjesna.");
                    }
                    else
                    {
                        Console.WriteLine("Iznos mora biti veci od nule.");
                    }
                }
                else if (izbor == "2")
                {
                    Console.Write("Iznos za podizanje: ");
                    double iznos = double.Parse(Console.ReadLine());

                    if (iznos > 0 && iznos <= stanje)
                    {
                        stanje -= iznos;
                        Console.WriteLine("Isplata je uspjesna.");
                    }
                    else
                    {
                        Console.WriteLine("Nedovoljan iznos ili neispravan unos.");
                    }
                }
                else if (izbor == "3")
                {
                    Console.WriteLine("Stanje racuna: " +
                        stanje.ToString("F2"));
                }

            } while (izbor != "0");
        }

        // ZADATAK 8 - Lokalna i static varijabla
        static void Zad08()
        {
            string izbor;

            do
            {
                Console.WriteLine("\n--- ZADATAK 8 ---");
                Console.WriteLine("1 - Ispisi varijable");
                Console.WriteLine("0 - Povratak");
                izbor = Console.ReadLine();

                if (izbor == "1")
                {
                    int broj = 5;

                    Console.WriteLine("Lokalni broj: " + broj);
                    Console.WriteLine("Static broj: " + Program.broj);
                }

            } while (izbor != "0");
        }

        // =========================
        // 7. SAT
        // =========================

        // ZADATAK 1 - Overloading zbrajanja
        static void Zad10()
        {
            string izbor;

            do
            {
                Console.WriteLine("\n--- ZADATAK 1 - 7. SAT ---");
                Console.WriteLine("1 - Zbroji dva broja");
                Console.WriteLine("2 - Zbroji tri broja");
                Console.WriteLine("0 - Povratak");
                izbor = Console.ReadLine();

                if (izbor == "1")
                {
                    Console.Write("Prvi broj: ");
                    int a = int.Parse(Console.ReadLine());

                    Console.Write("Drugi broj: ");
                    int b = int.Parse(Console.ReadLine());

                    Console.WriteLine("Zbroj: " + Zbroji(a, b));
                }
                else if (izbor == "2")
                {
                    Console.Write("Prvi broj: ");
                    int a = int.Parse(Console.ReadLine());

                    Console.Write("Drugi broj: ");
                    int b = int.Parse(Console.ReadLine());

                    Console.Write("Treci broj: ");
                    int c = int.Parse(Console.ReadLine());

                    Console.WriteLine("Zbroj: " + Zbroji(a, b, c));
                }

            } while (izbor != "0");
        }

        static int Zbroji(int a, int b)
        {
            return a + b;
        }

        static int Zbroji(int a, int b, int c)
        {
            return a + b + c;
        }

        // ZADATAK 2 - Overloading ispisa
        static void Zad11()
        {
            string izbor;

            do
            {
                Console.WriteLine("\n--- ZADATAK 2 - 7. SAT ---");
                Console.WriteLine("1 - Ispisi cijeli broj");
                Console.WriteLine("2 - Ispisi tekst");
                Console.WriteLine("0 - Povratak");
                izbor = Console.ReadLine();

                if (izbor == "1")
                {
                    Console.Write("Unesi cijeli broj: ");
                    int brojZaIspis = int.Parse(Console.ReadLine());

                    Ispisi(brojZaIspis);
                }
                else if (izbor == "2")
                {
                    Console.Write("Unesi tekst: ");
                    string tekst = Console.ReadLine();

                    Ispisi(tekst);
                }

            } while (izbor != "0");
        }

        static void Ispisi(int broj)
        {
            Console.WriteLine("Broj: " + broj);
        }

        static void Ispisi(string tekst)
        {
            Console.WriteLine("Tekst: " + tekst);
        }

        // ZADATAK 3 - Povrsina kvadrata ili pravokutnika
        static void Zad12()
        {
            string izbor;

            do
            {
                Console.WriteLine("\n--- ZADATAK 3 - 7. SAT ---");
                Console.WriteLine("1 - Povrsina kvadrata");
                Console.WriteLine("2 - Povrsina pravokutnika");
                Console.WriteLine("0 - Povratak");
                izbor = Console.ReadLine();

                if (izbor == "1")
                {
                    Console.Write("Unesi duljinu stranice: ");
                    double a = double.Parse(Console.ReadLine());

                    Console.WriteLine("Povrsina kvadrata: " + Povrsina(a));
                }
                else if (izbor == "2")
                {
                    Console.Write("Unesi sirinu: ");
                    double a = double.Parse(Console.ReadLine());

                    Console.Write("Unesi visinu: ");
                    double b = double.Parse(Console.ReadLine());

                    Console.WriteLine("Povrsina pravokutnika: " +
                        Povrsina(a, b));
                }

            } while (izbor != "0");
        }

        static double Povrsina(double a)
        {
            return a * a;
        }

        static double Povrsina(double a, double b)
        {
            return a * b;
        }

        // ZADATAK 4 - Zbroj elemenata polja
        static void Zad13()
        {
            string izbor;

            do
            {
                Console.WriteLine("\n--- ZADATAK 4 - 7. SAT ---");
                Console.WriteLine("1 - Izracunaj zbroj polja");
                Console.WriteLine("0 - Povratak");
                izbor = Console.ReadLine();

                if (izbor == "1")
                {
                    Console.Write("Koliko brojeva zelis unijeti? ");
                    int n = int.Parse(Console.ReadLine());

                    if (n <= 0)
                    {
                        Console.WriteLine("Broj elemenata mora biti veci od nule.");
                        continue;
                    }

                    int[] polje = new int[n];

                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Unesi broj: ");
                        polje[i] = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Zbroj elemenata: " + Zbroj(polje));
                }

            } while (izbor != "0");
        }

        static int Zbroj(int[] polje)
        {
            int suma = 0;

            foreach (int broj in polje)
            {
                suma += broj;
            }

            return suma;
        }

        // ZADATAK 5 - Najveci element polja
        static void Zad14()
        {
            string izbor;

            do
            {
                Console.WriteLine("\n--- ZADATAK 5 - 7. SAT ---");
                Console.WriteLine("1 - Pronadi najveci broj");
                Console.WriteLine("0 - Povratak");
                izbor = Console.ReadLine();

                if (izbor == "1")
                {
                    Console.Write("Koliko brojeva zelis unijeti? ");
                    int n = int.Parse(Console.ReadLine());

                    if (n <= 0)
                    {
                        Console.WriteLine("Broj elemenata mora biti veci od nule.");
                        continue;
                    }

                    int[] polje = new int[n];

                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Unesi broj: ");
                        polje[i] = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Najveci broj: " + Najveci(polje));
                }

            } while (izbor != "0");
        }

        static int Najveci(int[] polje)
        {
            int najveci = polje[0];

            foreach (int broj in polje)
            {
                if (broj > najveci)
                {
                    najveci = broj;
                }
            }

            return najveci;
        }

        // ZADATAK 6 - Prosjek elemenata polja
        static void Zad15()
        {
            string izbor;

            do
            {
                Console.WriteLine("\n--- ZADATAK 6 - 7. SAT ---");
                Console.WriteLine("1 - Izracunaj prosjek");
                Console.WriteLine("0 - Povratak");
                izbor = Console.ReadLine();

                if (izbor == "1")
                {
                    Console.Write("Koliko brojeva zelis unijeti? ");
                    int n = int.Parse(Console.ReadLine());

                    if (n <= 0)
                    {
                        Console.WriteLine("Broj elemenata mora biti veci od nule.");
                        continue;
                    }

                    int[] polje = new int[n];

                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Unesi broj: ");
                        polje[i] = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Prosjek: " +
                        Prosjek(polje).ToString("F2"));
                }

            } while (izbor != "0");
        }

        static double Prosjek(int[] polje)
        {
            int suma = Zbroj(polje);
            return (double)suma / polje.Length;
        }

        // ZADATAK 7 - Brojanje pojavljivanja broja
        static void Zad16()
        {
            string izbor;

            do
            {
                Console.WriteLine("\n--- ZADATAK 7 - 7. SAT ---");
                Console.WriteLine("1 - Prebroji pojavljivanja broja");
                Console.WriteLine("0 - Povratak");
                izbor = Console.ReadLine();

                if (izbor == "1")
                {
                    Console.Write("Koliko brojeva zelis unijeti? ");
                    int n = int.Parse(Console.ReadLine());

                    if (n <= 0)
                    {
                        Console.WriteLine("Broj elemenata mora biti veci od nule.");
                        continue;
                    }

                    int[] polje = new int[n];

                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Unesi broj: ");
                        polje[i] = int.Parse(Console.ReadLine());
                    }

                    Console.Write("Koji broj zelis prebrojati? ");
                    int trazeni = int.Parse(Console.ReadLine());

                    Console.WriteLine("Broj pojavljivanja: " +
                        Prebroji(polje, trazeni));
                }

            } while (izbor != "0");
        }

        static int Prebroji(int[] polje, int trazeni)
        {
            int brojPojavljivanja = 0;

            foreach (int broj in polje)
            {
                if (broj == trazeni)
                {
                    brojPojavljivanja++;
                }
            }

            return brojPojavljivanja;
        }

        // ZADATAK 8 - Obrtanje redoslijeda polja
        static void Zad17()
        {
            string izbor;

            do
            {
                Console.WriteLine("\n--- ZADATAK 8 - 7. SAT ---");
                Console.WriteLine("1 - Obrni redoslijed polja");
                Console.WriteLine("0 - Povratak");
                izbor = Console.ReadLine();

                if (izbor == "1")
                {
                    Console.Write("Koliko brojeva zelis unijeti? ");
                    int n = int.Parse(Console.ReadLine());

                    if (n <= 0)
                    {
                        Console.WriteLine("Broj elemenata mora biti veci od nule.");
                        continue;
                    }

                    int[] polje = new int[n];

                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Unesi broj: ");
                        polje[i] = int.Parse(Console.ReadLine());
                    }

                    Obrni(polje);

                    Console.WriteLine("Obrnuto polje:");

                    foreach (int broj in polje)
                    {
                        Console.Write(broj + " ");
                    }

                    Console.WriteLine();
                }

            } while (izbor != "0");
        }

        static void Obrni(int[] polje)
        {
            Array.Reverse(polje);
        }

        // ZADATAK 9 - Overloading metode Max
        static void Zad18()
        {
            string izbor;

            do
            {
                Console.WriteLine("\n--- ZADATAK 9 - 7. SAT ---");
                Console.WriteLine("1 - Najveci cijeli broj");
                Console.WriteLine("2 - Najveci decimalni broj");
                Console.WriteLine("0 - Povratak");
                izbor = Console.ReadLine();

                if (izbor == "1")
                {
                    int[] polje = { 5, 12, 3, 27, 9 };

                    Console.WriteLine("Polje cijelih brojeva: 5, 12, 3, 27, 9");
                    Console.WriteLine("Najveci broj: " + Max(polje));
                }
                else if (izbor == "2")
                {
                    double[] polje = { 2.5, 8.7, 4.2, 1.9 };

                    Console.WriteLine("Polje decimalnih brojeva: 2.5, 8.7, 4.2, 1.9");
                    Console.WriteLine("Najveci broj: " + Max(polje));
                }

            } while (izbor != "0");
        }

        static int Max(int[] polje)
        {
            int najveci = polje[0];

            foreach (int broj in polje)
            {
                if (broj > najveci)
                {
                    najveci = broj;
                }
            }

            return najveci;
        }

        static double Max(double[] polje)
        {
            double najveci = polje[0];

            foreach (double broj in polje)
            {
                if (broj > najveci)
                {
                    najveci = broj;
                }
            }

            return najveci;
        }
    }
}
