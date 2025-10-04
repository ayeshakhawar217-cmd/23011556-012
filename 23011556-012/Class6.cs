using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_012
{
    internal class Exercise6
    {
        public void Run()
        {
            Console.WriteLine("\n --- Exercise06 - Factorial ---");

            //Input a number from user
            Console.WriteLine("\nEnter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int fact = 1;
            int i = 1;

            //Using while loop to calculate factorial
            while(i <= num)
            {
                fact *= i;
                i++;

            }
            Console.WriteLine($"\nFactorial of {num} is: {fact}");

        }
    }
}
