using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Binary_to_Decimal_Number
{
    class BinaryDecimalNumber
    {
        static void Main(string[] args)
        {
            char[] numbers = Console.ReadLine().ToCharArray();
            Array.Reverse(numbers);
            long result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == '1')
                {
                    result += (long)Math.Pow(2, i);
                }  
            }
            Console.Write(result);
            Console.WriteLine();
        }
    }
}
