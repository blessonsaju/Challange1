using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class equalornot
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("enter the first number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number:");
            b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("a and b are equal");
            }
            else
            {
                Console.WriteLine("a and b are not equal");
            }
            Console.ReadLine();
        }
    }
}
