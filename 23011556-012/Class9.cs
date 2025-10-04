using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_012
{
    internal class Exercise9
    {
        public void Run()
        {
            Console.WriteLine("\n --- Exercise 09 - Counting Even/Odd ---");
            //Creating array of 10 elements
            int[] arr = new int[10];

            int evenCount = 0; //Variable to store count of even numbers
            int oddCount = 0;  //Variable to store count of odd numbers

            //Input elements of array from user
            Console.WriteLine("Enter elements of the Array: ");
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            //Conditional statements to cheeck and count even/odd elements
                if (arr[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            Console.WriteLine("Count of Even Elements: " + evenCount);
            Console.WriteLine("Count of Odd Elements: " + oddCount);

        }
    }
}
