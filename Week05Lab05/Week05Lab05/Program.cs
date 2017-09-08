using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 10;
            try
            {
                b /= a;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine(a);
            }
        }
    }
}
