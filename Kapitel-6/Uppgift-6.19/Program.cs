using System;

namespace Uppgift_6._19
{
    class Program
    {
        static void Main(string[] args)
        {
            int störretal = Störst(19, 6);
        }

        static int Störst(int tal1, int tal2)
        {
            if (tal1 > tal2)
            {
                return tal1;
            }
            else
            {
                return tal2;
            }


        }
    }
}
