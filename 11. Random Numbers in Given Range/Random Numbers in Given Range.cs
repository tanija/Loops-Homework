using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Random_Numbers_in_Given_Range
{
    class RNumbers
    {
        static void Main(string[] args)
        {    
             int n =  int.Parse(Console.ReadLine());
             int min =int.Parse(Console.ReadLine());
             int max =int.Parse(Console.ReadLine());

             Random rng = new Random();
             for (int i = 0; i < n; i++)
             {
                 Console.Write("{0} ",rng.Next(min, max));
             }
             Console.WriteLine();
        }
    }
}
