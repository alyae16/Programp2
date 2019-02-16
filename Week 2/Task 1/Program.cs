using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week_2
{
    class Program
    { 

        static void Main(string[] args)
        {
            string line = System.IO.File.ReadAllText(@"C:\Users\user\Documents\aba.txt");
            string reverseline = string.Empty;

           if(line != null)
            {
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    reverseline += line[i].ToString();
                }

                if(line == reverseline)
            {
                Console.WriteLine("Yes");
            }
                
            else
            {
                Console.WriteLine("No");
            }

                
            
           }

            
        }

        }
    }
