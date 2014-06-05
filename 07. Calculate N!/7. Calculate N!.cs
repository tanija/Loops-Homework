using System;
using System.Numerics;


    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter nuber n: ");
            ulong n = ulong.Parse(Console.ReadLine());
            Console.Write("Enter nuber k: ");
            ulong k = ulong.Parse(Console.ReadLine());
            BigInteger result = 1;
            BigInteger resultBufer = 1;
            ulong bufer = n - k;
            for (ulong i = (k + 1); i <= n; i++)
            {
                result = result * i;
            }
            for (ulong c = 1; c <= bufer; c++)
            {
                resultBufer = resultBufer * c;
            }
            Console.WriteLine(result/resultBufer);
        }
    }