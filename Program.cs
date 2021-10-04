using System;
using System.IO; //Failide kirjutamiseks

namespace learndotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello Files!";  // teksti faili ehk string
            File.WriteAllText("File.txt", text); // Loob faili File.txt ja kirjutab sisse text. Kui fail eksisteerib siis kirjutab sisu üle
             //Kui jooksutan dotnet run, siis tekib fail.txt üles vasakusse tulpa .gitignore alla ja sinna on kirjutatud "Hello Files!"

             //Lugeda failist sisu võimalik lugeda tee järgmine rida. Loon kõigepealt uue failimida lugeda üles tulpa "ugemiseks.txt"

             text = File.ReadAllText("lugemiseks.txt");
             Console.Write(text);

            //FileStream file = File.OpenWrite("file.txt"); //Avab faili kirjutamiseks
              //  file.Write(Mida); //Saab byte faili kirjutada 


        
        }
    }
}

