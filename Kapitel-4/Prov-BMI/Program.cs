using System;

namespace Prov_BMI
{
    class Program
    {
        static void Main(string[] args)
        {

string svar = "";

while (svar != "j")
{
                Console.WriteLine("Hej, detta är ett program som ska kunna räkna ut din BMI. För att göra detta behöver vi din vikt och din längd.");

            Console.WriteLine("Ange din längd: (i meter) ");
            float längd = float.Parse(Console.ReadLine());

            Console.WriteLine("Ange din vikt: (i kg) ");
            int vikt = int.Parse(Console.ReadLine());

            double längdikvadrat = (längd * längd);

            double BMI = (vikt / längdikvadrat);

            Console.WriteLine("Din BMI är:" + BMI);

if (BMI < 16.00)
{
    Console.WriteLine("Du är kraftigt underviktig");
}
else if (BMI <= 16.99)
{
    Console.WriteLine("Du är underviktig");
}
else if (BMI <= 18.49)
{
    Console.WriteLine("Du kan vara lite underviktig");
}
else if (BMI <= 24.99)
{
    Console.WriteLine("Du har en normal BMI");
}
else if (BMI <= 27.49)
{
    Console.WriteLine("Du kan vara lite överviktig");
}
else if (BMI <= 29.99)
{
    Console.WriteLine("Du är överviktig");
}
else if (BMI <= 34.99)
{
    Console.WriteLine("Du är överviktig, fetma klass 1");
}
else if (BMI <= 39.99)
{
    Console.WriteLine("Du är överviktig, fetma klass 2");
}
else if (BMI > 40.00)
{
    Console.WriteLine("Du har sjuklig fetma");
}

Console.WriteLine("Vill du sluta använda programmet? (j)");
svar = Console.ReadLine();


if (svar == "j")
{
  break;
}
else
{
    Console.WriteLine("Ok, skriv in en ny text");
}
}

        }
    }
}
