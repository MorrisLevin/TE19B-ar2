using System;
using System.IO;


namespace Countries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program för att hitta länder matchande sökterm!");
            Console.WriteLine("Program listar land och landskod");

if (File.Exists("countries.csv")
{
    
string[] rader = File.ReadAllLines("countries.csv");

}else
{
    
    Console.WriteLine("Avbryt! Filen countries.csv finns inte.");
}


        }
    }
}
