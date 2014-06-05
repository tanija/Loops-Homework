using System;
    class HexadecimalDecimalNumber
    {
        static void Main()
        {
            string numHex = Console.ReadLine();
            long[] numb = new long[numHex.Length];
            for (int i = 0; i < numHex.Length; i++)
            {
                if (numHex[i] < 58)
                {
                    numb[i] = (long)numHex[i]- 48;	 
                }
                else
	            {
                    numb[i] = (long)numHex[i] - 55;
	            } 
            }
            long result = 0;
            Array.Reverse(numb);
            for (int c = numb.Length -1; c >=0 ; c--)
            {
                result += (long)Math.Pow(16,c) * numb[c];
             }
            Console.WriteLine(result);
        }
    }
