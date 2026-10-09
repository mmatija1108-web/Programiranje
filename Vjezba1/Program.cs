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
                Console.WriteLine("1. Zadatak");
                Console.WriteLine("2. Zadatak");
                Console.WriteLine("3. Zadatak");
                Console.WriteLine("4. Zadatak");
                Console.WriteLine("5. Kraj");

                Console.WriteLine("Unesite broj zadataka");
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
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Nepoznati izbor");
                        break;
                }
            } while (izbor != "0");
        }
        static double PovrsinaPravokutnika(double a, double b)
        {
            return a * b; 
        }
        static int ZbrojDvajuBrojeva(int a, int b) 
        {
            return a + b;
        }
        static int RazlikaDvajuBrojeva(int a, int b)
        {
            return a - b;
        }
        static double OpsegKruga(double r)
        {
            return 2*Math.PI * r ;
        }
        static void Zad01() 
        {
            Console.WriteLine("Unesi prvi broj: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi drugi broj");
            int b = int.Parse(Console.ReadLine());
            int zbroj = ZbrojDvajuBrojeva(a, b);
            Console.WriteLine($"Zbroj je: {zbroj}");
        }
        static void Zad02()
        {
            Console.WriteLine("Unesi prvi broj: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi drugi broj");
            int b = int.Parse(Console.ReadLine());
            int razlika = RazlikaDvajuBrojeva(a, b);
            Console.WriteLine($"Razlika je: {razlika}");
        }
        static void Zad03()
        {
            Console.WriteLine("---------- Zadatak 3 ----------");
            Console.WriteLine("Unesi Stranicu Pravokutnika A: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesi Stranicu Pravokutnika B: ");
            double b = double.Parse(Console.ReadLine());
            double povrsina = PovrsinaPravokutnika(a, b);
            Console.WriteLine($"Povrsina pravokutnika je: {povrsina} ");
        }
        static void Zad04()
        {
            Console.WriteLine("---------- Zadatak 4 ----------");
            Console.WriteLine("Unesi r: ");
            double r = double.Parse(Console.ReadLine());
            double opseg = OpsegKruga(r);
            Console.WriteLine($"Opseg kruga je: {opseg}");
        }
        static void Zad05()
        {
            Console.WriteLine("---------- Zadatak 4 ----------");
            Console.WriteLine("Unesi broj");
        }

    }    
}
