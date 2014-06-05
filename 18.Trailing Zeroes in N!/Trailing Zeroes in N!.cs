using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
    class TrailingZeroesN
    {
        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine()) ;
            BigInteger result = 1;
            BigInteger count = 0;
            for (BigInteger i = 1; i <= n; i++)
            {
                result *= i;
            }
            while (result % 10 == 0)
	            {
	                  count ++;
                      result = result / 10;
	            }
            Console.WriteLine(count);
        }
    }