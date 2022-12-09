using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class multiply
    {
        static void Main(string[] args)
        {
            int num, i;
            Console.WriteLine("Enter the number:");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= 10; i++)
            {
              
                Console.WriteLine("{0}*{1}={2}", i, num,i*num);
            }
            Console.ReadLine();
        }
    }
}
