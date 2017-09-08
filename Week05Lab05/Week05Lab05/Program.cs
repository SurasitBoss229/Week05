using System;

namespace ConsoleApp2
{
    class Multiply
    {
        static void Main()
        {
            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    Console.Write("{0, 4}", i * j);
                }
                Console.WriteLine();
            }
        }
    }
}
