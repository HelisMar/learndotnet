using System;

namespace learndotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
             Console.WriteLine("Sisesta esimene number:");
             int num1_= int.Parse(Console.ReadLine());
             Console.WriteLine("Sisesta teine number:");
             int num2 = int.Parse(Console.ReadLine());
             Console.WriteLine("Siesta operatsioon (liida/lahuta / korruta / jaga):");
             string operation = Console.ReadLine();
             int anwser;
             switch(operation) 
            {
                case "liida":
                   anwser = num1_ + num2;
                   break;
                case "lahuta":
                   anwser = num1_ - num2;
                 break;
                case "korruta":
                  anwser = num1_ * num2;
                  break;
                case "jaga":
                 anwser = num1_ / num2;
                 break;
                 default:
                        throw(new Exception());

                
                 }

          
                Console.WriteLine("vastus on: " + anwser);
                 
                
            }
           catch {
               Console.WriteLine("vale sisend!!");
           }

        }
    }
}
