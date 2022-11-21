using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_3___Password
{
    public class Class2
    {
        public static void Fodbold()
        {
            start:
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Tast 1: Hvis der er blevet scoret et mål");
                Console.WriteLine("Tast 2: For afleveringer");
                Console.WriteLine("Tast 3: For afslut");
                var switchkey = Console.ReadLine();
                switch (switchkey)
                {
                    case "1":
                        Console.WriteLine("Olé Olé Olé");
                        goto start;

                    case "2":
                        Console.WriteLine("Hvor mange afleveringer er blevet spillet?");
                        int afleveringer = Convert.ToInt32(Console.ReadLine());


                        if (afleveringer >= 10)
                        {
                            Console.WriteLine("High Five – Jubel!!!");
                            goto start;
                        }
                        if (afleveringer <= 1)
                        {
                            Console.WriteLine("Shh");
                            goto start;
                        }
                        if (afleveringer > 1 | afleveringer <= 9)
                        {
                            while (afleveringer > 0)
                            {
                                Console.WriteLine("Huh!");
                                afleveringer--;
                            }
                        }
                        Console.ReadKey();
                        goto start;
                case "3":
                    break;
                }

            
        }
        public static void Dans()
        {
            //Spørg og få vores variabler
            string Navn1 = "";
            string Navn2 = "";
            Console.WriteLine("Hvad er danser 1 navn?");
            Navn1 = Console.ReadLine();
            Console.WriteLine("Hvor mange point fik " + Navn1 + " ?");
            int point1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Hvor er danser 2 navn?");
            Navn2 = Console.ReadLine();
            Console.WriteLine("Hvor mange point fik " + Navn2 + " ?");
            int point2 = Convert.ToInt32(Console.ReadLine());

            //Læg variabler sammen og udskriv
            Console.WriteLine(Navn1 + " & " + Navn2 + ": " + Case_2.AddPoints(point1, point2));

            Console.ReadKey();
        }
        public class Case_2
        {
            public int Point = Convert.ToInt32(Console.ReadLine());

            public static int AddPoints(int point1, int point2)
            {

                return point1 + point2;
            }

        }
    }
}
