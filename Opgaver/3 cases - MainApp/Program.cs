using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Case_3___Password;

namespace Case_3
{
    internal class Password
    {
        static void Main(string[] args)
        {
        home:;
            Console.WriteLine("Password is required for access");
            string login = @"C:\Users\Tobcas\Desktop\Opgaver\3 cases - MainApp\Password.txt";
            string passfile = @"C:\Users\Tobcas\Desktop\Opgaver\3 Cases\Case 3 - Password\Passwords og login\Password.txt";
            string userpw = Console.ReadLine();
        
            //Check hvis passwords stemmer overens
            if (File.ReadAllText(login).Contains(userpw))
            {
                Console.WriteLine("Correct password");
                Console.ReadKey();
         
                Console.Clear();
                Console.WriteLine("choose next option");
                Console.WriteLine("N: Next \t C: Change password");
                ConsoleKeyInfo input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.N:
                        Console.Clear();
                    start:
                        Console.WriteLine("Hvilket program vil du bruge?");
                        Console.WriteLine("F: Fodbold \t D: Dans");
                        ConsoleKeyInfo input1 = Console.ReadKey();
                        switch (input1.Key)
                        {
                            case ConsoleKey.F:
                                Class2.Fodbold();
                                goto start;
                                break;

                            case ConsoleKey.D:
                                Console.Clear();
                                Class2.Dans();
                                goto start;
                                break;
                        }
                     
                        break;

                        case ConsoleKey.C:
                        Console.WriteLine("Type new password.");
                        string newpass = Console.ReadLine();

                        break;
                }
            }
            else
            {
                Console.WriteLine("Incorrect password try again");
                goto home;
            }

   


            Console.ReadKey();
        }
    }
}