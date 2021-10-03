using System;
using System.Collections.Generic;

namespace learndotnet
{
    class Program
    {
        static void Main(string[] args)
        {
        
         Console.WriteLine("Kirjuta üks number:");
           int n = int.Parse(Console.ReadLine());

           for (int i = 1; i <= n ; i++) 
            if(i%3==0 || i%5==0)
           {
               Console.WriteLine("{0}" , i);
        
           }
        }
    }
}

