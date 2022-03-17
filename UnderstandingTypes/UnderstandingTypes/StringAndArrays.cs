using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingTypes
{
    public class StringAndArrays
    {
        public void copyArray()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arr2 = new int[arr.Length];

            foreach (int i in arr)
            {
                arr2.Append(i);
                // Console.WriteLine(i);
            }

        }

        public void display(ArrayList l)
        {
            for (int i = 0; i < l.Count; i++)
            {
                Console.WriteLine(l[i].ToString() + ',');
            }
        }
        public void shopping()
        {

            //string[] list = new string[];   // don't use this one, because to create a list, you must put arr size
            ArrayList list = new ArrayList();

            while (true)
            {
                Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
                string operation = Console.ReadLine();
                if (operation == "--")
                {
                    list.Clear();
                    Console.WriteLine("List is empty");
                    continue;
                }

                if (operation.StartsWith('+'))
                {
                    list.Add(operation.Split(' ')[1]);
                    display(list);
                    continue;
                }
                else if (operation.StartsWith('-'))
                {
                    list.Remove(operation.Split(' ')[1]);
                    display(list);
                    continue;
                }
                else
                {
                    Console.WriteLine("Wrong action, do it again!");
                    continue;
                }
            }
        }

        static bool isPrime(int num)
        {
            int i = 2;
            while (i * i <= num)
            {
                if (num % i == 0)
                {
                    return false;
                } 
                i++;
            }
            return true;
        }

        static int[] findPrimesInRange(int startNum,int endNum)
        {
            ArrayList nums = new ArrayList();
            for (int i = startNum; i <= endNum; i++)
            {
                if (isPrime(i))
                {
                    nums.Add(i);
                    System.Console.WriteLine(i);
                }
            }

            return nums.ToArray(typeof(int)) as int[];
        }

        static int[] rotateArr(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    newArr[0] = arr[arr.Length - 1];
                }
                else
                {
                    newArr[i] = arr[i + 1];
                }
            }
            return newArr;
        }

        static void sumArray(int[] arr, int k)
        {
            int[] sum = new int[arr.Length];
            int[] prev = arr;
            int[] curr;

            for (int i = 0; i < k; i++)
            {
                curr = rotateArr(prev);
                Console.WriteLine(String.Join(" ", curr));

                for (int j = 0; j < arr.Length; j++)
                {
                    sum[j] += curr[j];
                }
                prev = curr;   
            }

            Console.WriteLine(String.Join(" ", sum));
        }

        static void longestSubSeq(int[] arr)
        {
            int count = 1;
            int longestNum = arr[0];
            int longestCount = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != arr[i - 1])
                {
                    count = 0;
                }
                count++;
                
                if (count > longestCount)
                {
                    longestCount = count;
                    longestNum = arr[i];
                }
            }

            Console.WriteLine(string.Join(" ", Enumerable.Repeat(longestNum, longestCount)));

            int[] result = new int[longestCount];
            Array.Fill(result, longestNum);
        }

        static void findMostFreq(int[] arr)
        {
            Array.Sort(arr);

            int max_count = 1;
            int res = arr[0];
            int curr_count = 1;
            ArrayList nums = new ArrayList();

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    curr_count++;
                    nums.Add(res);
                }
                else
                {
                    if (curr_count > max_count)
                    {
                        max_count = curr_count;
                        res = arr[i - 1];
                    }
                    curr_count = 1;
                }
            }

            if (curr_count > max_count)
            {
                max_count = curr_count;
                res = arr[arr.Length - 1]; 
                nums.Add(res);
            }

            Console.WriteLine(string.Join(" ", nums));
        }

        static void reverseString1(string str)
        {
            char[] arr = str.ToCharArray();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                System.Console.WriteLine(arr[i]);
            }

            Array.Reverse(arr);

            Console.WriteLine(String.Join("", arr));
        }

        static void reverseString2(string str)
        {
            string res = "";
            for (int i = str.Length; i >= 0; i--)
            {
                res = res + str[i];
            }
            Console.WriteLine(res);
        }

        static void reverseSen(string str)
        {
            char[] separator = {' ', '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?' };
            String[] splits = str.Split(separator);

        }
        
        static bool isPanlindrome(string str)
        {
            if (str.Length == 0)
            {
                return true;
            }

            int left = 0;
            int right = str.Length - 1;

            while (left <= right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }
                left += 1;
                right -= 1;
            }

            return true;
        }

        static void findPalindromes(String str)
        {
            ArrayList res = new ArrayList();
            char[] separator = { ' ', '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?' };
            String[] words = str.Split(separator);

            foreach (string word in words)
            {
                if (isPanlindrome(word))
                {
                    res.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", res));
        }

        static void parseURL(string url)
        {
            string protocol = "";
            string server = "";
            string resource = "";
            string rest = "";

            if (url.Contains("://"))
            {
                string[] str = url.Split("://");
                protocol = str[0];
                rest = str[1];  
            }
            if (rest.Contains("/"))
            {
                string[] str = rest.Split("/");
                server = str[0];
                resource = str[1];
            }

            Console.WriteLine($"[protocol] = {protocol}");
            Console.WriteLine($"[server] = {server}");
            Console.WriteLine($"[resource] = {resource}");
        }
    }
}
