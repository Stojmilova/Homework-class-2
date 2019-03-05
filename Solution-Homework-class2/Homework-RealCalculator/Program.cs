using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the arithmetic operation:+,-,*,/");
            string operand = Console.ReadLine();

            if (operand != "+" && operand != "-" && operand != "*" && operand != "/")
            {
                Console.WriteLine("Please enter valid operand");
            }
            else
            {
                Console.WriteLine("Please enter the second number: ");
                int firstNumber;
                bool isSuccessFirstNum = int.TryParse(Console.ReadLine(), out firstNumber);

                Console.WriteLine("Please enter the second number: ");
                int secondNumber;
                bool isSuccessSecondNum = int.TryParse(Console.ReadLine(), out secondNumber);

                if (isSuccessFirstNum && isSuccessSecondNum)
                {
                    //int result=0;

                    if (operand == "+")
                    {
                        //result = firstNumber + secondNumber;
                        Console.WriteLine("The result is:" + (firstNumber + secondNumber));
                    }
                    else if (operand == "-" && secondNumber > firstNumber)
                    {
                        //result = secondNumber - firstNumber;
                        Console.WriteLine("The result is:" + (secondNumber - firstNumber));
                    }
                    else if (operand == "-" && firstNumber > secondNumber)
                    {
                        //result = firstNumber - secondNumber;
                        Console.WriteLine("The result is:" + (firstNumber - secondNumber));
                    }
                    else if (operand == "*")
                    {
                        //result = firstNumber * secondNumber;
                        Console.WriteLine("The result is:" + (firstNumber * secondNumber));
                    }
                    else if (operand == "/")
                    {
                        //result = firstNumber / secondNumber;
                        Console.WriteLine("The result is:" + (firstNumber / secondNumber));
                    }
                    //Console.WriteLine("The result is:" + result);
                }
                else if (!isSuccessFirstNum && !isSuccessSecondNum)
                {
                    Console.WriteLine("You enter invalid number, please try again!");
                }
            }
            Console.ReadLine();
        }
    }
}
