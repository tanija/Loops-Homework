using System;
using System.Numerics;


class CalculateNCatalanNumber
    {
        static void Main(string[] args)
        {
            for (int m = 0; m < 6; m++)
            {
                 Console.Write("Enter nuber n: ");
            int n = int.Parse(Console.ReadLine());
            BigInteger result1= 1;
            BigInteger result2 = 1;
            BigInteger result3 = 1;
            for (int i = 2; i <= 2 * n; i++)
            {
                result1 = result1 *i;
            }
            for (int c = 2; c <= (n +1); c++)
            {
                result2 = result2 * c ;
            }
            for (int x = 1; x <= n; x++)
            {
                result3 = result3 * x;
            }
            Console.WriteLine(result1 / (result2 * result3));
            }
        }
    }