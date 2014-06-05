using System;
using System.Collections.Generic;
using System.Linq;

    class CalculateGCD
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            List<int> divisorA = new List<int>();
            List<int> divisorB = new List<int>();
            for (int i = 1; i <= Math.Abs(a); i++)
               {
                   if (Math.Abs(a) % i == 0)
                   {
                      divisorA.Add(i);
                   }
               }
               for (int x = 1; x <= Math.Abs(b); x++)
               {
                   if (Math.Abs(b) % x == 0)
                   {
                       divisorB.Add(x);
                   }
               }
               int Result = 1;
               for (int i = 0; i < divisorA.Count; i++)
               {
                   for (int c = 0; c < divisorB.Count; c++)
                   {
                       if ((divisorA[i] == divisorB[c]) && (Result <= divisorA[i]))
                       {
                           Result = divisorA[i];
                       }
                   }
               }
               Console.WriteLine(Result);
        }
    }
