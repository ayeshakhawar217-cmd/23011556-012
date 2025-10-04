using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_012
{
    internal class Exercise3
    {
        public void Run()
        {
            Console.WriteLine("\n --- Exercise03 - Grade Evaluator ---");

            //Input marks from user
            Console.WriteLine("\nEnter your marks: ");
            int num = Convert.ToInt32(Console.ReadLine());

            //Using else-if ladder for evaluationg grades
            if(num >= 85)
            {
                Console.WriteLine("\nGrade = A");
            }else if(num >= 70 && num <= 84)
            {
                Console.WriteLine("\nGrade = B");
            }
            else if(num >= 55 && num <= 69)
            {
                Console.WriteLine("\nGrade = C");
            }
            else if(num >= 40 && num <= 54)
            {
                Console.WriteLine("\nGrade = D");
            }
            else if(num < 40)
            {
                Console.WriteLine("\nGrade = F");
            }
            else
            {
                Console.WriteLine("Invalid!");
            }
        }
    }
}
