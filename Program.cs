using System;
using System.Collections.Generic;

namespace learndotnet
{
    class Program
    {
        static void Main(string[] args)
        {
         
         List<int> numbers = new List<int>();
         numbers.Add(10);
         Console.WriteLine(numbers[0]);
         bool contains = numbers.Contains(2);
         Console.WriteLine(contains);
            
        }

        }
    }

