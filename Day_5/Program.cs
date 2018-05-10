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
            Console.WriteLine("Ludzu ievadiet gadu,kura gada sobrid dzivojam ");
            string b = Console.ReadLine();
            gads1 = Convert.ToInt16(b);
            
            int gads2;
            Console.WriteLine("Ludzu ievadiet savu dzimsanas gadu");
            string a = Console.ReadLine();
            gads2 = Convert.ToInt16(a);

            int c = gads1 - gads2;

            Console.WriteLine("Jus esat " + c + " gadus vecs");

            int radius;
            Console.WriteLine("Ludzu ievadiet rinka linijas radiusu ");
            string r = Console.ReadLine();
            radius = Convert.ToInt16(r);
            
            

            double di = 2 * radius;
            double dl = 2 * 3.14 * radius;

            Console.WriteLine("Diametrs ir " + di + " garss " + " un laukums ir " + dl + " liels" );


            Console.ReadLine();


        }
    }
}
