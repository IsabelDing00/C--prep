using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign03
{
    static class WorkingWithMethods
    {
        static void Main(string[] args)
        {
            //int[] nums = GenerateNumbers();
            //Reverse(nums);
            //PrintNumbers(nums);

            for(int i = 0; i < 10; i++)
            { Console.WriteLine(Fibonacci(i)); }

        }

        // Create the array and able to put more than 10 numbers 
        private static int[] GenerateNumbers()
        {
            int k =  new Random().Next();
            int[] arr = new int[k];
            for (int i = 0; i < k; i++)
            {
                int num = new Random().Next(k);
                arr[i] = num;
            }
            return arr;
        }

        // Reverse the array
        public static void Reverse(int[] arr)
        {
            int n = arr.Length;
            int l = 0;
            int r = n - 1;

            while (l < r)
            {
                int tmp = arr[l];
                arr[l] = arr[r];
                arr[r] = tmp;

                l += 1;
                r -= 1;
            }
        }
        public static void PrintNumbers(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

        // Fibonacci
        public static int Fibonacci(int num)
        {
            int a = 0;
            int b = 1;
           
            int res = 0;

            if(num < 2)
            {
                return num;
            }
            for (int i = 2; i <= num; i++)
            {
                res = a + b;
                a = b;
                b = res;
            }
            //Console.WriteLine(res);
            return res; 
        }
    }
}
