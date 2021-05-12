using System;

namespace Uppgift_6._6
{
    class Program
    {
        static void Main(string[] args)
        {

            int summa = Multiplicera(10, 5);

            int summa2 = Dividera(100, 10);
        }
        
        static int Multiplicera(int tal1, int tal2)
        {
            return tal1 * tal2;
        }
        static int Dividera(int tal1, int tal2)
        {
            return tal1 / tal2;
        }
    }
}
