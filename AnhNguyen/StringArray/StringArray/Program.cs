/** Name: Nguyen, Anh
 * Class: CS132
 * Project: StringArray
 * Date: 2020-07-21
 * Description: a C# Console application project called Types.
 ***/
using System;

namespace StringArray
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[] food = new string[4];
            food[0] = "chicken";
            food[1] = "beef";
            food[2] = "shrimp";
            food[3] = "fish";
            Array.Sort(food);
            Console.WriteLine("What to eat");
            Console.WriteLine(food[0] + "," + food[1] + "," + food[2] + "," + food[3]);
            Console.WriteLine(food.Length);

           



        }
    }
}
