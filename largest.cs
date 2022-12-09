using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class largest
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter the  first number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the  second number:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the  third number:");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("a is greater");
                }
                else
                {
                    Console.WriteLine("c is greater");
                }
            }
                if (b > c)
                {
                    Console.WriteLine("b is greater");

                }
                else
                {
                    Console.WriteLine("c is greater");
                }
            Console.ReadLine();
        }     
        }
    }

