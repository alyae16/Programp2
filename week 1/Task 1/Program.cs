using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//converting  amount of given number from string to digit
            string[] arr = Console.ReadLine().Split();//reading given number and spliting it to an array of string

            int cnt = 0;//amount of prime numbers(that equal to 0 at the beginning)
            for(int i = 0; i < n; i++)//cicle  from 0 to amount of numbers
            {
                int div = 0;//amount of divisor that have each given number
                int x = int.Parse(arr[i]);//converting  given numbers  from string to digit
                for (int j = 2; j <= Math.Sqrt(x); j++)//cicle from 2 to square root of given number and taking square root of this number using Math 
                {
                    if (x % j == 0) div++;//condition when we have to increase divisors number 
                }
                if (x != 1 && div == 0) cnt++;//condition when we have to increase prime numbers amount 
            }
            Console.WriteLine(cnt);//write an amount of prime numbers

            for (int i = 0; i < n; i++)// cicle from 0 to amount of numbers
            {
                int div = 0;
                int x = int.Parse(arr[i]);
                for (int j = 2; j <= Math.Sqrt(x); j++)//cicle from 2 to square root of given number and taking square root of this number using Math 
                {
                    if (x % j == 0)//condition when we have to increase divisors number 
                    div++;// divisors amount plus 1
                }
                if (x != 1 && div == 0) //condition when number is prime number
                Console.Write(x + " ");// if condition above true it write this number
            }
        }
    }
}
