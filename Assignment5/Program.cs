using System.Collections.Generic;
using System.Security.Principal;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Question19();
            // Question20();
            // Question21();
            // Question22();
            // Question23();
            // Question24();
            // Question25();
            // Question26();
            // Question27();
            // Question28();
        }

        #region Question 19
        // 19- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n* n.
        static void Question19()
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (i == j)
                    {
                        Console.Write(1 + " ");
                    }
                    else
                    {
                        Console.Write(0 + " ");
                    }
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region Question 20
        // 20- Write a program in C# Sharp to find the sum of all elements of the array.
        static void Question20()
        {
            int[] arr = {10,20,30,40,50};
            int s = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                s += arr[i];
            }
            Console.WriteLine(s);
        }
        #endregion

        #region Question 21
        // 21- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
        static void Question21()
        {
            Console.WriteLine("Enter Size Of Arrays : ");
            int size = int.Parse(Console.ReadLine());
            int[] arr1 = new int[size];
            int[] arr2 = new int[size];
            int[] merged = new int[size*2];
            Console.WriteLine("Enter elements Of first Array : ");
            for (int i=0; i<size; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter elements Of second Array : ");
            for (int i = 0; i < size; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < size; i++)
            {
                merged[i] = arr1[i];
                merged[i+size] = arr2[i];
            }
            Array.Sort(merged);
            foreach (int num in merged)
            {
                Console.Write(num + " ");
            }
        }
        #endregion

        #region Question 22
        // 22- Write a program in C# Sharp to count the frequency of each element of an array.
        static void Question22()
        {
            int[] arr = {1,2,3,1,5,1,1,5,4,9,10};
            Dictionary<int, int> values = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if(values.ContainsKey(arr[i]))
                    values[arr[i]]++;
                else
                    values[arr[i]] = 1;
            }
            foreach (var kv in values)
            {
                Console.WriteLine($"Element: {kv.Key}, Freq: {kv.Value}");
            }
        }
        #endregion

        #region Question 23
        // 23- Write a program in C# Sharp to find maximum and minimum element in an array
        static void Question23()
        {
            int[] arr = { 1, 2, 3, 1, 5, 1, 1, 5, 4, 9, 10 };
            int max = arr[0];
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
                if (arr[i] < min)
                    min = arr[i];
            }
            Console.WriteLine($"Max={max} ,Min={min}");
        }
        #endregion

        #region Question 24
        //  24- Write a program in C# Sharp to find the second largest element in an array.
        static void Question24()
        {
            int[] arr = { 1, 2, 3, 1, 5, 1, 1, 5, 4, 9, 10 };
            Array.Sort(arr);
            Array.Reverse(arr);
            Console.WriteLine($"Second Max={arr[1]}");
        }
        #endregion

        #region Question 25
        // 25-. Consider an Array of Integer values with size N, having values as in this Example
        static void Question25()
        {
            Console.WriteLine("Enter Size Of Arrays : ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int maxDistance = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = size-1; j > i; j--)
                {
                    if (arr[i] == arr[j])
                    {
                        int distance = j - i - 1;
                        if (distance > maxDistance)
                            maxDistance = distance;
                        break;
                    }
                }
            }
            if (maxDistance < 0)
                Console.WriteLine("No repeated values found.");
            else
                Console.WriteLine($"Longest distance = {maxDistance}");
        }
        #endregion

        #region Question 26
        // 26- Given a list of space separated words, reverse the order of the words. 
        static void Question26()
        {
            Console.WriteLine("Enter a string :");
            string sentence = Console.ReadLine();
            string[] word = sentence.Split(' ');
            for (int i=word.Length-1; i>=0; i--)
            {
                Console.Write($"{word[i]} ");
            }
        }
        #endregion

        #region Question 27
        // 27- Write a program to create two multidimensional arrays of same size.Accept value from user and store them in first array.Now copy all the elements of first array on second array and print second array. 
        static void Question27()
        {
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] firstArray = new int[rows, cols];
            int[,] secondArray = new int[rows, cols];

            Console.WriteLine("Enter values for the first array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    firstArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    secondArray[i, j] = firstArray[i, j];
                }
            }

            Console.WriteLine("\nSecond Array (Copied from First Array):");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(secondArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region Question 28
        // 28- Write a Program to Print One Dimensional Array in Reverse Order 
        static void Question28()
        {
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nArray in Reverse Order:");
            for (int i = size - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        #endregion
    }
}
