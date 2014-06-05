using System;
    class DecimalBinaryNumber
    {
        static void Main()
        {
        long n = long.Parse(Console.ReadLine());
        int m = 0;
        int x = 0;
        for (int i = 0; Math.Pow(2, i) < n;i++, x++)
		{
		}
        m = (int)(Math.Pow(2, x) - n);
                
            if (m == 0)
            {
                long[] bits = new long[x + 1];
                bits[x] = 1;
                Console.Write(bits[x]);
                for (int c = bits.Length-2; c >= 0 ; c--)
                {
                bits[c] =0;
                Console.Write(bits[c]);
                }
                Console.WriteLine();
            }
            if (m > 0)
            {
                long[] bits = new long[x];
                bits[x - 1] = 1;
                Console.Write(bits[x - 1]);
                long m2 = n - (int)Math.Pow(2, x - 1);
                for (int c = bits.Length - 2; c >= 0; c--)
                {
                    if (Math.Pow(2, c) <= m2)
                    {
                        bits[c] = 1;
                        Console.Write(bits[c]);
                        m2 -= (int)Math.Pow(2, c);

                    }
                    else
                    {
                        bits[c] = 0;
                        Console.Write(bits[c]);
                    }
                       
                }
                Console.WriteLine();
            }
        }
    }