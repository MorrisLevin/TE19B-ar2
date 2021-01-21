using System;

namespace Array.basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alt 1 av array
            string[] städer = { "Stockholm", "Paris", "London" }; //Låst till 3

            //Städer[0] = Stockholm
            //Städer[1] = Paris
            //Städer[2] = London


//Alt 2 av array
string[] länder = new string[2];

//Skapa en annan array av 3 tal

int[] årtal = new int[3];

//Fylla en array
länder[0] = "Frankrike";
länder[1] = "Polen";
årtal[0] = "1945";
årtal[1] = "1975";

        }
    }
}
