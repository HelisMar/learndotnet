using System;

namespace learndotnet
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Kirjuta üks number:");
           int n = int.Parse(Console.ReadLine());

           for (int i = 1; i <= n; i++) {
               Console.WriteLine("{0}" , i);

           }
           Console.WriteLine();
         
         
            
        }

        }
    }

