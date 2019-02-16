using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{

    class Program
    {
        static int[] MakeDoubleArray(int[] a)//method that duplicate an array and have as an variable an array a[]
        {
            int[] res = new int[a.Length * 2];//to make an array that will have to 2 time bigger size than given array

            for (int i = 0; i < a.Length; ++i)//cicle from zero to an array size
            {
                res[2 * i] = res[2 * i + 1] = a[i];//store duplicated copies to new array from the given array 
            }

            return res;//returns the final duplicated array
        }

        static int[] ReadData()//method that read information
        {
            int x = int.Parse(Console.ReadLine());//read amount of numbers
            string line = Console.ReadLine();//read given numbers
            string[] parts = line.Split();//split the string in the array
            int[] t = new int[x];//indicate that x is the number of members in the array t

            for (int i = 0; i < x; ++i)//cicle from zero to amount of members
            {
                t[i] = int.Parse(parts[i]);//to make an array of numbers insted an array of strings
            }

            return t;//passes an array t
        }

        static void PrintAnswer(int[] ans)//method that will display answer
        {
            foreach (var q in ans)//cicle for each member of array
            {
                Console.Write(q + " ");//writng an answer
            }
        }

        static void Main(string[] args)
        {
            int[] t = ReadData();//array t equal to called method that read informarion
            int[] ans = MakeDoubleArray(t);//array ans equal to called method that make double array
            PrintAnswer(ans);//displays answer


        }
    }
}
