using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class oddsum
    {
        static void Main(string[] args)
        {
            int n;
            int sum = 0;
            Console.WriteLine("enter the limit");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                sum += i;
            }
        }
            Console.WriteLine("sum is" +sum);
            Console.ReadLine(); 
        
            
        }
    }
}
