using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    internal class ReverseString
    {
        internal void ReverseStr()
        {
            Console.Write("Enter your name: ");
            string str = Console.ReadLine();
            for (int i = str.Length-1; i>=0; i--)
            {
                Console.Write(str[i]);
            }
            //Console.WriteLine(str);
            Console.ReadLine();
        }

        internal void StringManupulation() {
            string str = "C# is the codding";
            string result = "$$" + str.Substring(2);
            Console.WriteLine(str.Length);
            Console.WriteLine(result);
            int count = 0;
            char[] charArray = str.ToCharArray();
            for (int i = 0; i<charArray.Length; i++)
            {
                if (count < 2)
                {
                    charArray[i] = '$';
                }
                count++;
            }

            for (int i = 0; i<str.Length; i++)
            {
                Console.Write(str[i]);
                Thread.Sleep(100); // 1000ms = 1 sec
            }

            str = new string(charArray);
            Console.WriteLine(str);
            Console.ReadLine();

        }

        internal void PasswordCheker() 
        {
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter your confirm password: ");
            string passwordc = Console.ReadLine();

            if (!password.Equals(string.Empty)) 
            {
                if (passwordc.Equals(string.Empty))
                {
                    if (password.Equals(passwordc))
                    {
                        Console.WriteLine("Password match");
                    }
                    else
                    {
                        Console.WriteLine("Password don't match!");
                    }
                }
                else
                {
                    Console.WriteLine("Plese enter password confirmation");
                }
                
            }
            else
            {
                Console.WriteLine("Please enter a password!");
            }

        }

        // Array
        internal void ArrayManupulation()
        {
            int[] numbers = new int[3];

            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            int sumNum = 0;

            foreach(var item in numbers)
            {
                sumNum += item;
            }

            Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]}");
            Console.WriteLine(sumNum);
            Console.ReadLine();
        }

        internal void LargestSmallestNum()
        {
            int[] num = { 1, 5, 6, 8, 3, 9 };

           
            int  n = num.Length;
            int maxValue = num[0];
            int minValue = num[0];

            void LargestNumber(int [] arr, int number)
            {
                for (int i= 0; i<number; i++)
                {
                    if (arr[i] > maxValue)
                    {
                        maxValue = arr[i];
                    }
                    else if (arr[i] < minValue)
                    {
                        minValue = arr[i];
                    }
                }
                Console.WriteLine("Largest Value: " + maxValue);
                Console.Write("Smallest Value: "+ minValue);
            }
            LargestNumber(num, n);
            Console.ReadLine();
            
        }

        internal void ShortAnArray()
        {
            int[] arr = {1, 2, 3, 4, 5, 6};

            Array.Reverse(arr);
            Console.WriteLine(string.Join("," , arr));

            for (int i=arr.Length-1; i>=0; i--)
            {
                Console.Write(arr[i]);
            }
            Console.ReadLine();
        }

        internal void DublicateArray()
        {
            int[] arr = { 1, 2, 2, 6, 5};

            int DublicatesNum = 0;

            for (int i=0; i<arr.Length; i++)
            {
                for (int j=i+1; j<arr.Length; j++)
                {
                    if (arr[i].Equals(arr[j]))
                    {
                        DublicatesNum = arr[i];
                        break;
                    }
                }
            }

            Console.WriteLine(DublicatesNum);

            Console.ReadLine();
            
        }

        internal void DublicateArrayHashSet() 
        {
            int[] arr = { 1, 2, 2, 5, 5 };

            HashSet<int> seen = new HashSet<int>();
            HashSet<int> Dublicates = new HashSet<int>();

            foreach (int num in arr)
            {
                if (!seen.Add(num)) // If num is already in seen, it's a duplicate seen.Add(num) return false
                {
                    Dublicates.Add(num);
                }
            }
            Console.WriteLine(string.Join(" ", Dublicates));

            Console.WriteLine(string.Join(" ", seen));


            Console.ReadLine();
        }

        internal void SecondLasgestNum()
        {
            int[] arr = { 1, 2, 2, 5, 8, 9, 0 };

            Array.Sort(arr);    // Sorts in ascending order
           // Array.Reverse(arr); // Reverses to descending order

            Console.WriteLine(string.Join(" ", arr[arr.Length-2]));
            Console.ReadLine();

        }

        internal void SortAnArray()
        {
            int[] arr = { 1, 5, 8, 4, 9, 3, 8 };

            for (int i=0; i<arr.Length; i++)
            {
                for (int j=i+1; j<arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        //arr[i] = arr[i] + arr[j];
                        //arr[j] = arr[i] - arr[j];
                        //arr[i] = arr[i] - arr[j];
                    }
                }
                Console.Write(" " + arr[i]);
            }
            Console.ReadLine();

        }

        //List 
        internal void AddList()
        {
            List<string> list = new List<string>();

            list.Add("Shad");
            list.Add("Arif");

            Console.WriteLine(string.Join(" ",list));  
            Console.ReadLine();
        }
        internal void RemoveList()
        {
            List<int> list = new List<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(5);
            list.Add(6);
            list.Add(7);

            for (int i=0; i<list.Count(); i++)
            {
                if (list[i] % 2 == 0)
                {
                    list.Remove(list[i]);
                }
            }
            Console.WriteLine(string.Join(" ", list));

            Console.ReadLine();
        }

        // String

        internal void Palindrome()
        {
            string str = Console.ReadLine();
            if (str[0] == str[str.Length-1])
            {
                Console.WriteLine("This is Palindrome: " + str);
            }
            else
            {
                Console.WriteLine("This not a palindrome");
            }
            
            Console.ReadLine();
        }

        internal void RemoveDublicateCharac()
        {
            string str = "Tomorrow";

            HashSet<char> set = new HashSet<char>();
            foreach (char c in str) 
            { 
                set.Add(c);
            }

            Console.WriteLine(string.Join(" ", set));
            Console.ReadLine();
        }


    }
}
