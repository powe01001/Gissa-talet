using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gissa_Talet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Gissa Talet");
            Random slump = new Random();
            slump.Next(101);
            int tal = slump.Next(101);

            int försök = 0;
            int tal1 = -1;

            while (tal1 != tal)
            {
                Console.WriteLine("Skriv ett tal mellan 1 och 100: ");
                String Str1 = Console.ReadLine();
                tal1 = int.Parse(Str1);

                if (tal1 < tal)
                {
                    Console.WriteLine("Fel talet är för lågt");
                    försök++;
                    Console.WriteLine("Försök igen");
                }

                if (tal1 > tal)
                {
                    Console.WriteLine("Fel talet är för högt");
                    försök++;
                    Console.WriteLine("Försök igen");
                }

                if (tal1 == tal)
                {
                    Console.WriteLine("Det är rätt!");
                    försök++;
                    Console.WriteLine("Antal försök: " + försök);
                }
            }
        }
    }
}