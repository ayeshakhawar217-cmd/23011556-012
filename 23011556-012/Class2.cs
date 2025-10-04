using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_012
{
    internal class Exercise2
    {
        public void Run()
        {
            //Input two numbers from the user
            Console.WriteLine("\n --- Exercise02 - Calculator ---");
            Console.WriteLine("\nEnter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //Input Operator from the user
            Console.WriteLine("Enter the operator(+,-,*,/): ");
            char op = Console.ReadLine()[0];

           
            switch (op)
            {
                case '+':
                    Console.WriteLine("\n Addition of Two Numbers = " + num1 + num2);
                    break;

                case '-':
                    Console.WriteLine("\n Subtraction of Two Numbers = " + (num1 - num2));
                    break;

                case '*':
                    Console.WriteLine("\n Multiplication of Two Numbers = " + num1 * num2);
                    break;

                case '/':
                    Console.WriteLine("\n Division of Two Numbers = " + num1 / num2);
                    break;

            }



        }
    }
}
