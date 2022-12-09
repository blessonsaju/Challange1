using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class sumo10
    {
        static void Main(string[] args)
        {
             int sum = 0;
            for ( int i = 1; i <= 10; i++)
            {
                sum += i;
                
            }
            Console.WriteLine("sum=" +sum);
            Console.ReadKey();
        }
    }
}
