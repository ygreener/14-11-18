using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {

                
                while (a % m != 0 && m <= a)
                {
                    m++;
                }
                if (a == m || a == 1)
                {
                    Console.WriteLine("prime number");
                }
                else
                {
                    Console.WriteLine("not a prime number");
                }
            }
        }
    }
}
