using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                for (int c = i ; c <= i + num - 1; c++)
                {
                       Console.Write("{0} ",c); 
                }
                Console.WriteLine();
            }
        }
    }