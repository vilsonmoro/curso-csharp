using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                // Create a NumberFormatInfo object  
                // and set some of its properties. 
                System.Globalization.NumberFormatInfo provider = new NumberFormatInfo();
                provider.NumberDecimalSeparator = ", ";
                provider.NumberGroupSeparator = ".";
                provider.NumberGroupSizes = new int[] { 3 };

                // declaring and intializing String array 
                string[] values = {"123456789", "123.456.789",
                                      "12345, 6789"};

                // calling get() Method 
                Console.Write("Converted decimal value "
                                 + "of specified strings: ");

                for (int j = 0; j < values.Length; j++)
                {
                    get(values[j], provider);
                }
            }

            catch (FormatException e)
            {

                Console.WriteLine("\n");
                Console.Write("Exception Thrown: ");
                Console.Write("{0}", e.GetType(), e.Message);
            }

            catch (OverflowException e)
            {

                Console.WriteLine("\n");
                Console.Write("Exception Thrown: ");
                Console.Write("{0}", e.GetType(), e.Message);
            }
            Console.ReadKey();
        }

        // Defining get() method 
        public static void get(string s,
              System.Globalization.NumberFormatInfo provider)
        {

            // converting string to specified char 
            double val = Convert.ToDouble(s, provider);

            // display the converted char value 
            Console.Write(" {0}, ", val);
        }
    }

}
