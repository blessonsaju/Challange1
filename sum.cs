using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class sum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;

            while (n > 0)
            {
                int a = n % 10;
                s = s + a;
                n = n / 10;
            }
            Console.WriteLine("sum is" +s);

        }
    }
}
