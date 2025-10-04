using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_012
{
    internal class Exercise7
    {
        public void Run()
        {
            Console.WriteLine("\n --- Exercise 07 ---");

            //Input a number from user
            Console.WriteLine("\nEnter an Integer: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int reversed = 0;

            while(num != 0)
            {
                // Get the last digit
                int temp = num % 10;
                // Append the digit to reversed
                reversed = reversed * 10 + temp;
                //Remove last digit from integer
                num = num / 10;
            }

            Console.WriteLine("\nReversed Integer is: " + reversed);
        }
    }
}
