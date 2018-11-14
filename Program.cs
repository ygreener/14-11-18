using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i <= 2000; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 2; i <= 100; i= i+2)
            {
                Console.WriteLine(i);
            }
            for (int i = 10; i <= 100; i= i+10)
            {
                Console.WriteLine(i);
            }
            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
