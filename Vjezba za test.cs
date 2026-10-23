using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIU1_20_zadataka_jedan_CSharp_projekt
{
    internal class Program
    {
        static int ukupnoPokretanja = 0;

        static void Main()
        {
            int izbor;

            do
            {
                Console.WriteLine("\n========== ZBIRKA ZADATAKA ==========");
                Console.WriteLine(" 1 - Zbroj i razlika");
                Console.WriteLine(" 2 - Pravokutnik");
                Console.WriteLine(" 3 - Krug");
                Console.WriteLine(" 4 - Pretvorba temperature");
                Console.WriteLine(" 5 - Popust u trgovini");
                Console.WriteLine(" 6 - Najveći i najmanji");
                Console.WriteLine(" 7 - Parnost i djeljivost");
                Console.WriteLine(" 8 - Ocjena iz postotka");
                Console.WriteLine(" 9 - Mini kalkulator");
                Console.WriteLine("10 - Zbroj i prosjek 1...N");
                Console.WriteLine("11 - Tablica množenja");
                Console.WriteLine("12 - Znamenke broja");
                Console.WriteLine("13 - Prost broj");
                Console.WriteLine("14 - Faktorijel petljom");
                Console.WriteLine("15 - Analiza teksta");
                Console.WriteLine("16 - Palindrom");
                Console.WriteLine("17 - Statistika polja");
                Console.WriteLine("18 - Pretraživanje polja");
                Console.WriteLine("19 - Evidencija bodova");
                Console.WriteLine(" 0 - Izlaz");
                Console.Write("Odabir: ");

                if (!int.TryParse(Console.ReadLine(), out izbor))
                {
                    Console.WriteLine("Neispravan unos!");
                    continue;
                }

                switch (izbor)
                {
                    case 0:
                        Console.WriteLine("Ukupno pokretanja zadataka: "
                            + ukupnoPokretanja);
                        Console.WriteLine("Kraj programa.");
                        break;
                    case 1: ukupnoPokretanja++; Zadatak01(); break;
                    case 2: ukupnoPokretanja++; Zadatak02(); break;
                    case 3: ukupnoPokretanja++; Zadatak03(); break;
                    case 4: ukupnoPokretanja++; Zadatak04(); break;
                    case 5: ukupnoPokretanja++; Zadatak05(); break;
                    case 6: ukupnoPokretanja++; Zadatak06(); break;
                    case 7: ukupnoPokretanja++; Zadatak07(); break;
                    case 8: ukupnoPokretanja++; Zadatak08(); break;
                    case 9: ukupnoPokretanja++; Zadatak09(); break;
                    case 10: ukupnoPokretanja++; Zadatak10(); break;
                    case 11: ukupnoPokretanja++; Zadatak11(); break;
                    case 12: ukupnoPokretanja++; Zadatak12(); break;
                    case 13: ukupnoPokretanja++; Zadatak13(); break;
                    case 14: ukupnoPokretanja++; Zadatak14(); break;
                    case 15: ukupnoPokretanja++; Zadatak15(); break;
                    case 16: ukupnoPokretanja++; Zadatak16(); break;
                    case 17: ukupnoPokretanja++; Zadatak17(); break;
                    case 18: ukupnoPokretanja++; Zadatak18(); break;
                    case 19: ukupnoPokretanja++; Zadatak19(); break;
                    default:
                        Console.WriteLine("Nepoznata opcija!");
                        break;
                }

            } while (izbor != 0);
        }

        // 1. Zbroj i razlika
        static int Zbroji(int a, int b)
        {
            return a + b;
        }

        static int Oduzmi(int a, int b)
        {
            return a - b;
        }

        static void Zadatak01()
        {
            Console.Write("Unesi prvi cijeli broj: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Unesi drugi cijeli broj: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Zbroj: " + Zbroji(a, b));
            Console.WriteLine("Razlika: " + Oduzmi(a, b));
        }

        // 2. Pravokutnik
        static double OpsegPravokutnika(double a, double b)
        {
            return 2 * (a + b);
        }

        static double PovrsinaPravokutnika(double a, double b)
        {
            return a * b;
        }

        static void Zadatak02()
        {
            Console.Write("Unesi stranicu a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Unesi stranicu b: ");
            double b = double.Parse(Console.ReadLine());

            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("Stranice moraju biti pozitivne.");
                return;
            }

            Console.WriteLine("Opseg: " + OpsegPravokutnika(a, b));
            Console.WriteLine("Površina: " + PovrsinaPravokutnika(a, b));
        }

        // 3. Krug
        static double OpsegKruga(double r)
        {
            return 2 * Math.PI * r;
        }

        static double PovrsinaKruga(double r)
        {
            return Math.PI * r * r;
        }

        static void Zadatak03()
        {
            Console.Write("Unesi polumjer: ");
            double r = double.Parse(Console.ReadLine());

            if (r <= 0)
            {
                Console.WriteLine("Polumjer mora biti pozitivan.");
                return;
            }

            Console.WriteLine($"Opseg: {OpsegKruga(r):F2}");
            Console.WriteLine($"Površina: {PovrsinaKruga(r):F2}");
        }

        // 4. Pretvorba temperature
        static double CelsiusUFahrenheit(double c)
        {
            return c * 9 / 5 + 32;
        }

        static double FahrenheitUCelsius(double f)
        {
            return (f - 32) * 5 / 9;
        }

        static void Zadatak04()
        {
            Console.WriteLine("1 - Celsius u Fahrenheit");
            Console.WriteLine("2 - Fahrenheit u Celsius");
            Console.Write("Odabir: ");
            int odabir = int.Parse(Console.ReadLine());

            Console.Write("Unesi temperaturu: ");
            double temperatura = double.Parse(Console.ReadLine());

            if (odabir == 1)
                Console.WriteLine("Temperatura: "
                    + CelsiusUFahrenheit(temperatura) + " °F");
            else if (odabir == 2)
                Console.WriteLine("Temperatura: "
                    + FahrenheitUCelsius(temperatura) + " °C");
            else
                Console.WriteLine("Nepoznata pretvorba.");
        }

        // 5. Popust u trgovini
        static double KonacnaCijena(double cijena, double popust)
        {
            return cijena - cijena * popust / 100;
        }

        static void Zadatak05()
        {
            Console.Write("Unesi početnu cijenu: ");
            double cijena = double.Parse(Console.ReadLine());

            Console.Write("Unesi popust u postocima: ");
            double popust = double.Parse(Console.ReadLine());

            if (cijena < 0 || popust < 0 || popust > 100)
            {
                Console.WriteLine("Neispravna cijena ili popust.");
                return;
            }

            double konacna = KonacnaCijena(cijena, popust);

            Console.WriteLine("Iznos popusta: "
                + (cijena - konacna));
            Console.WriteLine("Konačna cijena: " + konacna);
        }

        // 6. Najveći i najmanji broj
        static int Najveci(int a, int b, int c)
        {
            int max = a;

            if (b > max) max = b;
            if (c > max) max = c;

            return max;
        }

        static int Najmanji(int a, int b, int c)
        {
            int min = a;

            if (b < min) min = b;
            if (c < min) min = c;

            return min;
        }

        static void Zadatak06()
        {
            Console.Write("Unesi prvi broj: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Unesi drugi broj: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Unesi treći broj: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Najveći: " + Najveci(a, b, c));
            Console.WriteLine("Najmanji: " + Najmanji(a, b, c));
        }

        // 7. Parnost i djeljivost
        static bool JeParan(int n)
        {
            return n % 2 == 0;
        }

        static bool JeDjeljiv(int n, int djelitelj)
        {
            return n % djelitelj == 0;
        }

        static void Zadatak07()
        {
            Console.Write("Unesi cijeli broj: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(JeParan(n) ? "Broj je paran."
                : "Broj je neparan.");

            Console.WriteLine(JeDjeljiv(n, 3)
                ? "Djeljiv je s 3." : "Nije djeljiv s 3.");

            Console.WriteLine(JeDjeljiv(n, 5)
                ? "Djeljiv je s 5." : "Nije djeljiv s 5.");
        }

        // 8. Ocjena iz postotka
        static int OdrediOcjenu(int postotak)
        {
            if (postotak < 50) return 1;
            if (postotak < 63) return 2;
            if (postotak < 76) return 3;
            if (postotak < 89) return 4;
            return 5;
        }

        static void Zadatak08()
        {
            Console.Write("Unesi postotak (0-100): ");
            int postotak = int.Parse(Console.ReadLine());

            if (postotak < 0 || postotak > 100)
            {
                Console.WriteLine("Postotak mora biti od 0 do 100.");
                return;
            }

            Console.WriteLine("Ocjena: " + OdrediOcjenu(postotak));
        }

        // 9. Mini kalkulator
        static double Izracunaj(double a, double b, char operacija)
        {
            switch (operacija)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/': return a / b;
                default: return 0;
            }
        }

        static void Zadatak09()
        {
            Console.Write("Unesi prvi broj: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Unesi operaciju (+, -, *, /): ");
            string unos = Console.ReadLine();

            if (unos.Length != 1 ||
                "+-*/".IndexOf(unos[0]) == -1)
            {
                Console.WriteLine("Nepoznata operacija.");
                return;
            }

            char operacija = unos[0];

            Console.Write("Unesi drugi broj: ");
            double b = double.Parse(Console.ReadLine());

            if (operacija == '/' && b == 0)
            {
                Console.WriteLine("Dijeljenje nulom nije dopušteno.");
                return;
            }

            Console.WriteLine("Rezultat: "
                + Izracunaj(a, b, operacija));
        }

        // 10. Zbroj i prosjek od 1 do N
        static long ZbrojDoN(int n)
        {
            long zbroj = 0;

            for (int i = 1; i <= n; i++)
                zbroj += i;

            return zbroj;
        }

        static void Zadatak10()
        {
            Console.Write("Unesi N (1-100000): ");
            int n = int.Parse(Console.ReadLine());

            if (n < 1 || n > 100000)
            {
                Console.WriteLine("N mora biti od 1 do 100000.");
                return;
            }

            long zbroj = ZbrojDoN(n);
            double prosjek = (double)zbroj / n;

            Console.WriteLine("Zbroj: " + zbroj);
            Console.WriteLine("Prosjek: " + prosjek);
        }

        // 11. Tablica množenja
        static void IspisiTablicu(int broj)
        {
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{broj} x {i} = {broj * i}");
        }

        static void Zadatak11()
        {
            Console.Write("Unesi broj od 1 do 10: ");
            int broj = int.Parse(Console.ReadLine());

            if (broj < 1 || broj > 10)
            {
                Console.WriteLine("Broj mora biti od 1 do 10.");
                return;
            }

            IspisiTablicu(broj);
        }

        // 12. Znamenke broja
        static int BrojZnamenaka(int n)
        {
            if (n == 0) return 1;

            int broj = 0;

            while (n > 0)
            {
                broj++;
                n /= 10;
            }

            return broj;
        }

        static int ZbrojZnamenaka(int n)
        {
            int zbroj = 0;

            while (n > 0)
            {
                zbroj += n % 10;
                n /= 10;
            }

            return zbroj;
        }

        static void Zadatak12()
        {
            Console.Write("Unesi nenegativan broj: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Broj ne smije biti negativan.");
                return;
            }

            Console.WriteLine("Broj znamenaka: " + BrojZnamenaka(n));
            Console.WriteLine("Zbroj znamenaka: " + ZbrojZnamenaka(n));
        }

        // 13. Prost broj
        static bool JeProst(int n)
        {
            if (n < 2) return false;

            for (int i = 2; i <= n / i; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        static void Zadatak13()
        {
            Console.Write("Unesi broj: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Broj mora biti nenegativan.");
                return;
            }

            Console.WriteLine(JeProst(n)
                ? "Broj je prost." : "Broj nije prost.");
        }

        // 14. Faktorijel petljom
        static long Faktorijel(int n)
        {
            long rezultat = 1;

            for (int i = 1; i <= n; i++)
                rezultat *= i;

            return rezultat;
        }

        static void Zadatak14()
        {
            Console.Write("Unesi N (0-20): ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0 || n > 20)
            {
                Console.WriteLine("N mora biti od 0 do 20.");
                return;
            }

            Console.WriteLine(n + "! = " + Faktorijel(n));
        }

        // 15. Analiza teksta
        static int BrojSamoglasnika(string tekst)
        {
            int broj = 0;

            foreach (char znak in tekst.ToLower())
            {
                if ("aeiou".IndexOf(znak) >= 0)
                    broj++;
            }

            return broj;
        }

        static int BrojRazmaka(string tekst)
        {
            int broj = 0;

            foreach (char znak in tekst)
            {
                if (znak == ' ')
                    broj++;
            }

            return broj;
        }

        static void Zadatak15()
        {
            Console.Write("Unesi rečenicu: ");
            string tekst = Console.ReadLine();

            Console.WriteLine("Broj znakova: " + tekst.Length);
            Console.WriteLine("Broj samoglasnika: "
                + BrojSamoglasnika(tekst));
            Console.WriteLine("Broj razmaka: " + BrojRazmaka(tekst));
        }

        // 16. Palindrom
        static bool JePalindrom(string tekst)
        {
            tekst = tekst.Replace(" ", "").ToLower();

            int lijevo = 0;
            int desno = tekst.Length - 1;

            while (lijevo < desno)
            {
                if (tekst[lijevo] != tekst[desno])
                    return false;

                lijevo++;
                desno--;
            }

            return true;
        }

        static void Zadatak16()
        {
            Console.Write("Unesi tekst: ");
            string tekst = Console.ReadLine();

            Console.WriteLine(JePalindrom(tekst)
                ? "Tekst je palindrom." : "Tekst nije palindrom.");
        }

        // 17. Statistika polja
        static int ZbrojPolja(int[] a)
        {
            int zbroj = 0;

            foreach (int broj in a)
                zbroj += broj;

            return zbroj;
        }

        static int NajmanjiUPolju(int[] a)
        {
            int min = a[0];

            for (int i = 1; i < a.Length; i++)
                if (a[i] < min) min = a[i];

            return min;
        }

        static int NajveciUPolju(int[] a)
        {
            int max = a[0];

            for (int i = 1; i < a.Length; i++)
                if (a[i] > max) max = a[i];

            return max;
        }

        static void Zadatak17()
        {
            Console.Write("Broj elemenata (3-20): ");
            int n = int.Parse(Console.ReadLine());

            if (n < 3 || n > 20)
            {
                Console.WriteLine("N mora biti od 3 do 20.");
                return;
            }

            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i}: ");
                a[i] = int.Parse(Console.ReadLine());
            }

            int zbroj = ZbrojPolja(a);

            Console.WriteLine("Zbroj: " + zbroj);
            Console.WriteLine("Prosjek: " + (double)zbroj / n);
            Console.WriteLine("Najmanji: " + NajmanjiUPolju(a));
            Console.WriteLine("Najveći: " + NajveciUPolju(a));
        }

        // 18. Pretraživanje polja
        static int BrojPojavljivanja(int[] a, int trazeni)
        {
            int broj = 0;

            foreach (int element in a)
                if (element == trazeni)
                    broj++;

            return broj;
        }

        static void Zadatak18()
        {
            int[] a = new int[10];

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Element {i}: ");
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Koji broj tražiš? ");
            int trazeni = int.Parse(Console.ReadLine());

            Console.WriteLine("Broj pojavljivanja: "
                + BrojPojavljivanja(a, trazeni));

            Console.Write("Indeksi: ");
            bool pronaden = false;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == trazeni)
                {
                    Console.Write(i + " ");
                    pronaden = true;
                }
            }

            if (!pronaden)
                Console.Write("Broj nije pronađen.");

            Console.WriteLine();
        }

        // 19. Sortiranje polja vlastitim algoritmom
        static void SortirajUzlazno(int[] brojevi)
        {
            for (int i = 0; i < brojevi.Length - 1; i++)
            {
                for (int j = 0; j < brojevi.Length - 1 - i; j++)
                {
                    if (brojevi[j] > brojevi[j + 1])
                    {
                        int pomocni = brojevi[j];
                        brojevi[j] = brojevi[j + 1];
                        brojevi[j + 1] = pomocni;
                    }
                }
            }
        }


        // 19. Evidencija bodova učenika
        static void IspisiUcenika(string ime, int postotak)
        {
            Console.WriteLine($"{ime} - {postotak}%");
        }

        static void IspisiUcenika(string ime, int postotak, int ocjena)
        {
            Console.WriteLine($"{ime} - {postotak}% - ocjena {ocjena}");
        }

        static void Zadatak19()
        {
            Console.Write("Broj učenika (3-10): ");
            int n = int.Parse(Console.ReadLine());

            if (n < 3 || n > 10)
            {
                Console.WriteLine("Broj učenika mora biti od 3 do 10.");
                return;
            }

            string[] imena = new string[n];
            int[] postotci = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ime učenika {i + 1}: ");
                imena[i] = Console.ReadLine();

                Console.Write("Postotak riješenosti (0-100): ");
                postotci[i] = int.Parse(Console.ReadLine());

                if (postotci[i] < 0 || postotci[i] > 100)
                {
                    Console.WriteLine("Postotak mora biti od 0 do 100.");
                    return;
                }
            }

            int zbroj = 0;
            int najbolji = 0;
            int prolazni = 0;

            Console.WriteLine("\nREZULTATI:");

            for (int i = 0; i < n; i++)
            {
                IspisiUcenika(imena[i], postotci[i]);

                int ocjena = OdrediOcjenu(postotci[i]);
                IspisiUcenika(imena[i], postotci[i], ocjena);

                zbroj += postotci[i];

                if (postotci[i] > postotci[najbolji])
                    najbolji = i;

                if (postotci[i] >= 50)
                    prolazni++;
            }

            Console.WriteLine("\nProsječan postotak: "
                + (double)zbroj / n + "%");
            Console.WriteLine("Najbolji učenik: " + imena[najbolji]);
            Console.WriteLine("Broj prolaznih: " + prolazni);

        }
    }
}
