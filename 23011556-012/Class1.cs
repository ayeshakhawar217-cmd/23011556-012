using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_012
{
    internal class Exercise1
    {
        public void Run()
        {
            Console.WriteLine("\n --- Exercise 01 - Even/Odd ---");
            // Enter the number to be checked
            Console.WriteLine("\nEnter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // If num is multiple of 2 then display Even
            if(num%2 == 0)
            {
                Console.WriteLine("Number is Even");
            }

            // If not then display Odd
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }
}
