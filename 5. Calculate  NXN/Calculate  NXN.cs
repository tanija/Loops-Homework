using System;
    class Program
    {
        static void Main(string[] args)
        {
            //S = 1 + 1!/x + 2!/x2 + … + n!/xn. 
            Console.Write("Enter nuber n: ");
            double n = double.Parse(Console.ReadLine());
            Console.Write("Enter nuber x: ");
            double x = double.Parse(Console.ReadLine());
            double sum = 1;
            double f = 1;
            for (double i = 1; i <= n; i++)
            {
                f = f * i;
                sum = sum + f / Math.Pow(x, i);
            }
            
            string final = String.Format("{0:0.00000}", sum);
            Console.WriteLine(final);
        }
            
}