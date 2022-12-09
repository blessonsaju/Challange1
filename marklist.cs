using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class marklist
    {
        static void Main(string[] args)
        {
            int roll,m1,m2,m3,total;
            string name;
            float percentage;
            Console.WriteLine("enter the rollnumber");
            roll = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the name");
            name = Console.ReadLine();
            Console.WriteLine("enter the mark1");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the mark2");
            m2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the mark3");
            m3 = Convert.ToInt32(Console.ReadLine());
            total = m1 + m2 + m3;
            Console.WriteLine("total=" + total);
            percentage = (total * 100) / 300;
            Console.WriteLine("percentage="+percentage);
            Console.Read();
        }
       

    }
}
