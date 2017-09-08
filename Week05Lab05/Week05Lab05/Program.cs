using System;

namespace ConsoleApp2
{
    class Multiply
    {
        static void Main()
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("{0, 2} x 2 = {1, 2}", i, i * 2);
            }
        }
    }
}