using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_012
{
    internal class Exercise4
    {
        public void Run()
        {
            Console.WriteLine("\n --- Exercise 04 ---");

            //Input number from user
            Console.WriteLine("\nEnter a Natural Number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for(int i = 1; i<=n; i++)
            {

                sum += i;
            }

            Console.WriteLine("Sum of Natural Numbers = " + sum);
        }
    }
}
