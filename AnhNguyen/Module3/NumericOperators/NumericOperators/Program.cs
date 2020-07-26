using System;

namespace NumericOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20; //declare the variable num1 that has the value of 20
            int num2 = 77; //declare the variable num2 that has the value of 77
            float num3 = 5.2f; //declare the variable float that has the value of 20

            float sum = num1 + num2 + num3; //sum = 20+77+5.2
            int subtract = num2 - num1; //difference = 77-20
            int multiply = num1 * num2; //product = 20*77
            float divide = num1 / num3; //quotient = 20/77
            int modulus = num2 % num1; //remainder of 77%77

            Console.WriteLine("Sum of 3 numbers is: " + sum); //display "Sum of 3 numbers is: 102.2"
            Console.WriteLine("77 - 20 is: " + subtract); //display "77 - 20 is: 57"
            Console.WriteLine("20 * 77 is: " + multiply); //display "20 *77 is: 1540"
            Console.WriteLine("20 / 5.2 is: " + divide); //display "20 / 5.2 is: 3.846154"
            Console.WriteLine("77 % 20 is " + modulus); //display "77 % 20 is: 17"

        }
    }
}
