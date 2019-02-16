using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {

                    if (i < j)
                    {
                        Console.Write("   ");

                    }
                    else
                    {
                        Console.Write("[*]");
                    }


                }
                Console.WriteLine();
            }
        }
    }
}
