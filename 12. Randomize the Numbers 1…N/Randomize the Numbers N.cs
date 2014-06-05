using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Randomize_the_Numbers_1_N
{
    class RandomizeNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
           
            Random rng = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", rng.Next(1, n));
            }
            Console.WriteLine();
        }
    }
}
