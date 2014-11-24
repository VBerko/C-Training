using System;

namespace HW01_2._1
{
    class Program
    {
        static void Main()
        {
            float operand1 = 123;
            short operand2 = 0;
            string sign;

            Console.WriteLine("\nChoose action / * - + ");
            sign = Console.ReadLine();

            switch (sign)
            {
                case "/":
                    if (operand2 != 0)
                    {
                        Console.WriteLine("{0} {1} {2} = {3}", operand1, sign, operand2, operand1 / operand2);
                    }
                    else
                    {
                        Console.WriteLine("Error: Dividing by zero. Impossible to make action");
                    }
                    break;
                case "*":
                    Console.WriteLine("{0} {1} {2} = {3}", operand1, sign, operand2, operand1 * operand2);
                    break;
                case "-":
                    Console.WriteLine("{0} {1} {2} = {3}", operand1, sign, operand2, operand1 - operand2);
                    break;
                case "+":
                    Console.WriteLine("{0} {1} {2} = {3}", operand1, sign, operand2, operand1 + operand2);
                    break;
                default:
                    Console.WriteLine("Error: Incorrect value");
                    break;
            }

            Console.ReadKey();

        }
    }
}
