using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                

                Console.WriteLine("please enter anumber");
                double a = Convert.ToDouble(Console.ReadLine());
                if (a < 10) ;
                else if (a > 100) ;
                else
                {
                    double ahadot = a % 10;
                    double asarot = a / 10;
                    int asarot1 =(int) asarot;
                    Console.WriteLine("ahadot = {0} ", ahadot);
                    Console.WriteLine("asarot = {0}", asarot1);
                    if(ahadot > asarot)
                    {
                        Console.WriteLine("ahadot");
                    }
                    else
                    {
                        Console.WriteLine("äsarot");
                    }
                }

            
            }
        }
    }
}
