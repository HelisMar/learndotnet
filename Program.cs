using System;

namespace learndotnet
{
    class Program
    {
        static void Main(string[] args)
        {
           Random random = new Random (); //teise randomi asemel võib ükskõik mis nime panna
           int num = random.Next(50);
           Console.WriteLine(num);

           
            
           }
            

        }
    }

