using System.Drawing;
using System.Net.NetworkInformation;
using static System.Collections.Specialized.BitVector32;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Question1();
            // Question2();
            // Question3();
            // Question4();
            // Question5();
            // Question6();
            // Question7();
            // Question8();
            // Question9();
            // Question10();
        }

        #region Question 1
        // 1- Write a program that allows the user to enter a number then print it.
        static void Question1()
        {
            Console.Write("Enter a Number : ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num);
        }
        #endregion

        #region Question 2
        // 2- Write C# program that converts a string to an integer, but the string contains non-numeric
        //    characters.And mention what will happen
        static void Question2()
        {
            string str = "123one";
            int num = Convert.ToInt32(str); // an error as str contain non numeric char
        }
        #endregion

        #region Question 3
        // 3- Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention
        //    what will happen
        static void Question3()
        {
            float x = 2.5f , y = 1.5f;
            float result = x + y;
            Console.WriteLine(result);
        }
        #endregion

        #region Question 4
        // 4- Write C# program that Extract a substring from a given string. 
        static void Question4()
        {
            string str = "onetwothree";
            string substr = str.Substring(3, 3);
            Console.WriteLine(substr);
        }
        #endregion

        #region Question 5
        // 5- Write C# program that Assigning one value type variable to another and modifying the value of one
        //    variable and mention what will happen
        static void Question5()
        {
            int a = 10;
            int b = a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            //a = 20;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            b = 20;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        #endregion

        #region Question 6
        // 6- Write C# program that Assigning one reference type variable to another and modifying the object through
        //    one variable and mention what will happen
        static void Question6()
        {
            int[] a = { 1, 2, 3 };
            int[] b = a;
            b[0] = 99;
            Console.WriteLine(a[0]);
        }
        #endregion

        #region Question 7
        // 7- Write C# program that take two string variables and print them as one variable
        static void Question7()
        {
            string str1 = "Reem";
            string str2 = "Hafez";
            string both = str1 +" "+ str2;
            Console.WriteLine(both);
        }
        #endregion

        #region Question 8
        //  8- Which of the following statements is correct about the C#.NET code snippet given below? 
        static void Question8()
        {
            int d;
            d = Convert.ToInt32(!(30 < 20)); // !(False) = True => 1
            Console.WriteLine(d);
        }
        #endregion

        #region Question 9
        // 9- Which of the following is the correct output for the C# code given below?
        static void Question9()
        {
            Console.WriteLine(13 / 2 + " " + 13 % 2); // 6.5 1  no it will be 6 1 as it is integer division 
        }
        #endregion

        #region Question 10
        // 10-What will be the output of the C# code given below? 
        static void Question10()
        {
            int num = 1, z = 5;
            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z); //7 7
            else
                Console.WriteLine(--num + z-- + " " + --z);
        }
        #endregion
    }
}
