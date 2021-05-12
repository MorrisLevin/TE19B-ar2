using System;

namespace Uppgift_6._6._1
{
    class Program
    {
        static void Main(string[] args)
        {

            double gångerpå = Multiplicera(10, 5);
            double delatav = Dividera(100, 10);

            Console.WriteLine(gångerpå);
            Console.WriteLine(delatav);
        }

        static double Multiplicera(double tal1, double tal2)
        {
            double tal3 = tal1 * tal2;
            return tal3;
        }
        static double Dividera(double tal1, double tal2)
        {
            double tal3 = tal1 / tal2;
            return tal3;
        }
    }
}

