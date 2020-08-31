using System;

namespace String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string Welcome = "Welcome to ";
            string CourseName = "CS132";
            string message = Welcome + CourseName;

            for (int i = 0; i < message.Length; i++) 

            {
                if(i%2 == 0)
                {
                    Console.Write(message[i]);
                }

            }
            
               
        }
    }
}
