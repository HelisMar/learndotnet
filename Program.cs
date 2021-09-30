using System;

namespace learndotnet
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Mis on sinu nimi?");
           string name = Console.ReadLine();
           
         if(name == "Alice")
         { Console.WriteLine("Tere " + name + "!");

         } else if (name == "Bob")  {
             Console.WriteLine("Tere " + name + "!");
         }
           else { Console.WriteLine ("Tere!") ;
           
           }
         
            
        }

        }
    }

