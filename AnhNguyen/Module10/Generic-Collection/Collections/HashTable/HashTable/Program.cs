using System;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable myHashTable = new Hashtable()
            {
                {"Anh", 27 },
                { "Hoang", 28},
                { "Nguyen", 29},
            };
            int HashTableVal1 = (int)myHashTable["Anh"];
            int HashTableVal2 = (int)myHashTable["Hoang"];
            int HashTableVal3 = (int)myHashTable["Nguyen"];

            Console.WriteLine(HashTableVal1);
            Console.WriteLine(HashTableVal2);
            Console.WriteLine(HashTableVal3);
        }
    }
   
}
