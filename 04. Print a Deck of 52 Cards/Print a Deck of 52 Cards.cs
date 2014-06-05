using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

    class Program
    {
        static void Main()
        {
            char myChar; 
            for (int i = 2; i <= 13; i++)
            {
                if (i <= 10)
                {

                    for (int c = 3; c <= 6; c++)
                    {
                        string hexValue = c.ToString("X");
                        myChar = (char)Int16.Parse(hexValue, NumberStyles.AllowHexSpecifier);
                            Console.Write("{0}{1} ", i, myChar);
                    }
                    Console.WriteLine();
                }
                else
                {
                    string f = Convert.ToString(i);
                    switch (i)
                    {
                        case 11: f = "J"; 
                            break;
                        case 12: f = "Q";
                            break;
                        case 13: f = "K";
                            break;
                        case 14: f = "A";
                            break;
                    }
                    for (int c = 3; c <= 6; c++)
                    {
                        string hexValue = c.ToString("X");
                        myChar = (char)Int16.Parse(hexValue, NumberStyles.AllowHexSpecifier);
                            
                            Console.Write("{0}{1} ", f, myChar);
                    }
                    Console.WriteLine();
                }
                    
                }       
        }
    }