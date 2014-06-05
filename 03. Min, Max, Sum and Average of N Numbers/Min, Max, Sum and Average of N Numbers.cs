using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter number of count:  ");
            int count = int.Parse(Console.ReadLine());
            int [] n =new int [count];
            Console.WriteLine("Enter numbers:  ");
            int min = 0; 
            int max = 0;
            int sum = 0;
            for (int i = 0; i <= count-1; i++)
            {
                n [i] = int.Parse(Console.ReadLine());
                if (i == 0) 
                { min = n[0];
                  max = n[0]; }
                if (n[i] > max)
                {
                    max = n[i];
                }
                if (n[i] < min)
                {
                    min = n[i];
                }
                sum += n[i];
            }
            int avg = sum / count;
            Console.WriteLine(@" :
                min = {0}
                max = {1}
                sum = {2}
                avg = {3}", min, max, sum, (avg));
        }
    }