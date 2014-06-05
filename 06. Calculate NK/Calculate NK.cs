using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter nuber n: ");
            ulong n = ulong.Parse(Console.ReadLine());
            Console.Write("Enter nuber k: ");
            ulong k = ulong.Parse(Console.ReadLine());
            ulong result = 1;
            for (ulong i = (k + 1); i <= n; i++)
            {
                result = result * i;
            }
            Console.WriteLine(result);
        }
    }