using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class positive
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("enter the number");
            a=Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("a is negative");
            }
            else if (a > 0)
            {
                Console.WriteLine("a is positive");

            }
            else
            {
                Console.WriteLine("default");
             }
                Console.ReadKey();
            }

        }
}
