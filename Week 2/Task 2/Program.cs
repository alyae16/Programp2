using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = System.IO.File.ReadAllText(@"C:\Users\user\Documents\task 2\all.txt");
            string[] arr = line.Split();
            string prime = string.Empty;
            

            for (int i = 0; i < arr.Length; i++)
            {
                int div = 0;
                int x = int.Parse(arr[i]);
                for (int j = 2; j <= Math.Sqrt(x); j++)
                {
                    if (x % j == 0) div++;
                }
                if (x != 1 && div == 0)
                   prime = prime + x + " ";
            }
            System.IO.File.WriteAllText(@"C:\Users\user\Documents\task 2\prime.txt", prime) ;

        }
    }
}
