using System;

namespace Uppgift_5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] talLista = { 4, 5, 45, 81, 9 };

            int summa = 0;

            foreach (var tal in talLista)
            {
                summa += tal;
            }

            Console.WriteLine($"Summan är {summa}");
        }
    }
}
