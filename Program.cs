using System;
using System.Collections.Generic;

namespace BasicPart08_ListCollection
{
    class Program
    {
        static void Main(string[] args)
        {

            /*List<string> str = new List<string>();

            str.Add("A");
            str.Add("B");
            str.Add("D");
            str.Insert(2, "C");
            
            for (int index = 0;index < str.Count; index++)
            {
                Console.WriteLine("{0} ", str[index]);
            }*/

            List<int> number = new List<int>();

            number.Add(1);
            number.Add(3);
            number.Add(5);
            number.Add(7);
            number.Add(9);
            number.Insert(1, 2);

            for (int i = 0; i < number.Count; i++)
            {
                Console.WriteLine("{0}", number[i]);
            }

            Console.ReadKey();
        }
    }
}