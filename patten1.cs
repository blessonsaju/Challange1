using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    class patten1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++) //num of row
            {
                for(int j=1;j<=(5-i);j++)   //num of space -decrement     
                {
                    Console.Write(" ");

                }
                for(int k =1;k<=i;k++)  // LEFT *printing
                {
                    Console.Write("*");
                }
                for(int l=(i-1);l>0;l--)    //PRINTING RIGHT SIDE
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
           
          
            Console.ReadKey();
        }
    }
}
