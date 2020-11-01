using System;
using System.Runtime.InteropServices;

namespace peanut
{

    class Program
    {
        static void  Main(String [] args)
        {
            String input = Console.ReadLine();
             float km =  float.Parse(input);
             Console.WriteLine("{0} km = {1} miles", km, km/1.6);

        }
    }
}
