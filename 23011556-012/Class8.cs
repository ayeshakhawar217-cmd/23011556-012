using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_012
{
    internal class Exercise8
    {
        public void Run()
        {
            Console.WriteLine("\n --- Exercise08 - Array ---");

            //Create array to store user input in it
            int[] arr = new int[10];

            //Input elements to be stored in array
            Console.WriteLine("Enter elemnts of the array: ");
            for(int i =0; i< arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
              

            }

            Console.WriteLine("\nYour Array: " + string.Join(", ", arr));

            int min = arr[0];
            int max = arr[0];

            for(int i=1; i<arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max){
                    max = arr[i];

                }
            }

            Console.WriteLine("\nMinimun Element of Array: " + min);
            Console.WriteLine("Maximum Element of Array: " + max);
            

            
        }
    }
}
