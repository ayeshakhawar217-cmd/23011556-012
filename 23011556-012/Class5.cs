using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_012
{
    internal class Exercise5
    {
        public void Run()
        {
            Console.WriteLine("\n --- Exercise05 - Multiplication Table ---");

            //Input a number from user
            Console.WriteLine("\nEnter a number upto 10: ");
            int num = Convert.ToInt32(Console.ReadLine());

            //Using if-else to satisfy codition i.e num should'nt be greater than 10
            if(num>=1 && num <= 10)
            {
                Console.WriteLine("\nMultiplication Table of " + num);

               //loop to process multiplication table
                for(int i = 1; i<=10; i++)
                {
                    Console.WriteLine($"{num} x {i} = {num*i}");
                }

            }
            else
            {
                    Console.WriteLine("Invalid Input!");
            }

        }

    }
}
