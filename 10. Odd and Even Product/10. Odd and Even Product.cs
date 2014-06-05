using System;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Numbers: ");
            string[] numbers = Console.ReadLine().Split(' ');
            //int[] intNumb = Array.ConvertAll(numbers, s => int.Parse(s));
            //int[] intNumb = numbers.Select(int.Parse).ToArray();
            int product1 = 1;
            int product2 = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    product1 *= int.Parse(numbers[i]);
                }
                else
                {
                    product2 *= int.Parse(numbers[i]);
                }  
            }
            if (product1 == product2)
            {
                Console.WriteLine("Yes product =  {0}", product1);
            }
            else
            {
                Console.WriteLine(
                @"No, odd_product = {0} 
                     even_product = {1}", product2, product1);     
            }
        }
    }