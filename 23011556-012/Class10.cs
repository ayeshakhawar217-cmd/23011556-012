using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _23011556_012
{
    internal class Exercise10
    {
        public void Run()
        {
            Console.WriteLine("\n --- Exercise10 - Linear Search ---");


            //Creating an array of 10 elements
            int[] arr = { 10, 23, 45, 2, 87, 14, 55, 71, 36, 19 };

            //Input a number from user
            Console.WriteLine("\nEnter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            bool found = false;

            //Using foreach method for Linear Searching
            foreach(int element in arr)
            {
                if(element == num)
                {
                    found = true;
                    break;
                }
              
            }

            //Displaying result
            if (found)
            {
                Console.WriteLine($"\nThe Number {num} exists in the Array.");
            }
            else
            {
                Console.WriteLine($"\nThe Number {num} does not exist in the Array");
            }

        }
    }
}
