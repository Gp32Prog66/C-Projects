using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel.Design;

namespace Demos
{
    class Program
    {

        static void typeCastingMeth()
        {

        }

        static void mathRoundingMeth()
        {
            Console.WriteLine(Math.Round(56.7));
        }

        private static void reverseWordMeth(string s)
        {
            char[] reverseArray = s.ToCharArray();
            Array.Reverse(reverseArray);
            Console.WriteLine(new string(reverseArray));
        }

        static void quadraticFormulaMeth()
        {
            Console.WriteLine("Type in a number for A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type in a number for B");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type in a number for C");
            int c = Convert.ToInt32(Console.ReadLine());

            double d;

            double x1, x2;

            d = b * b - 4 * a * c;

            if(d==0)
            {
                Console.WriteLine("Roots are Equal");
            }

            else if(0<d)
            {

            }

            else
            {

                Console.WriteLine("No Solution");
            }
        }

        static void arrayReaderMeth()
        {
            string[] bands = { "Black Flag", "Dead Kennedys", "Melvins", "Pearl Jam", "Static X" };

            foreach (string a in bands)
            {
                Console.WriteLine(a);
            }
        }

        static void Main(string[] args)
        {

            

                Console.WriteLine("Choose what demonstration you would like to see!");

                Console.WriteLine("1. Type Casting\n2. Rounding Numbers\n3. Quadratic Formula\n4. Reverse Word\n5. Display Each Band\n6. Different Genre Types");

                int selection = Convert.ToInt32(Console.ReadLine());

            do
            {

                if (selection == 1)
                {
                    typeCastingMeth();
                    break;
                }
                else if (selection == 2)
                {
                    mathRoundingMeth();
                    break;
                }
                else if (selection == 3)
                {
                    quadraticFormulaMeth();
                    break;
                }
                else if (selection == 4)
                {
                    //reverseWordMeth(s);
                    break;
                }
                else if (selection == 5)
                {
                    arrayReaderMeth();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice. Press 0 to quit");
                    break;
                }

            }
            while (selection == 0);
        }
    }
}
