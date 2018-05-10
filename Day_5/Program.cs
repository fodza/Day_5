using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class Program
    {
        static void Main(string[] args)
        {
            String dati;
            Console.WriteLine("Ludzu ievadiet ka tevi sauc ?");
            dati = Console.ReadLine();
            Console.WriteLine("Tevi sauc " + dati);
            
            int gads1;
            Console.WriteLine("Ludzu ievadiet gadu,kura sobrid dzivojam ");
            string b = Console.ReadLine();
            gads1 = Convert.ToInt16(b);
            
            int gads2;
            Console.WriteLine("Ludzu ievadiet savu dzimsanas gadu");
            string a = Console.ReadLine();
            gads2 = Convert.ToInt16(a);

            int c = gads1 - gads2;

            Console.WriteLine("Jus esat " + c + " gadus vecs");

            Console.ReadLine();


        }
    }
}
