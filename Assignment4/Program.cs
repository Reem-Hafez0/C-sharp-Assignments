using System;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Question6();
            // Question7();
            // Question8();
            // Question9();
            // Question10();
            // Question11();
            // Question12();
            // Question13();
            // Question14();
            // Question15();
            // Question17();
            // Question18();
        }

        #region Question 6 
        // 6- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
        static void Question6()
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.Write(i+" ");
            }
        }
        #endregion

        #region Question 7
        // 7- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
        static void Question7()
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(i + "x" + num + "=" + i*num);
            }
        }
        #endregion

        #region Question 8
        // 8- Write a program that allows to user to insert number then print all even numbers between 1 to this number
        static void Question8()
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if(i%2==0)
                    Console.Write(i + " ");
            }
        }
        #endregion

        #region Question 9
        // 9- Write a program that takes two integers then prints the power. 
        static void Question9()
        {
            Console.Write("Enter First number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Second number : ");
            int num2 = int.Parse(Console.ReadLine());
            int power = 1;
            for (int i = 1; i <= num2; i++)
            {
                power = power * num1;
            }
            Console.Write(power);
        }
        #endregion

        #region Question 10
        // 10- Write a program to enter marks of five subjects and calculate total, average and percentage.
        static void Question10()
        {
            Console.WriteLine("Enter 5 marks : ");
            int[] arr = new int[5];
            int total = 0;
            for (int i = 0; i < 5; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
                total += arr[i];
            }
            double average = total/5.0;
            double Percentage = (total / 500.0) * 100;
            Console.WriteLine($"Total = {total}");
            Console.WriteLine($"Average = {average}");
            Console.WriteLine($"Percentage = {Percentage}");
        }
        #endregion

        #region Question 11
        // 11- Write a program to input the month number and print the number of days in that month.
        static void Question11()
        {
            Console.Write("Enter a year : ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter a month : ");
            int month = int.Parse(Console.ReadLine());
            int days = DateTime.DaysInMonth(year, month);
            Console.Write($"Number of days = {days}");
        }
        #endregion

        #region Question 12
        // 12- Write a program to create a Simple Calculator. 
        static void Question12()
        {
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("Enter a number : ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose an operation : + - / *");
            string s = Console.ReadLine();
            Console.WriteLine("Enter a number : ");
            double num2 = double.Parse(Console.ReadLine());
            switch(s)
            {
                case "+":
                    Console.WriteLine("Result = " + (num1+num2));
                    break;

                case "-":
                    Console.WriteLine("Result = " + (num1 - num2));
                    break;

                case "*":
                    Console.WriteLine("Result = " + (num1 * num2));
                    break;

                case "/":
                    if (num2 != 0)
                    {
                        Console.WriteLine("Result = " + (num1 / num2));
                    }
                    else
                    {
                        Console.WriteLine("invalid");
                    }
                    break;

                default:
                    Console.WriteLine("invalid operator");
                    break;
            }
        }
        #endregion

        #region Question 13
        // 13- Write a program to allow the user to enter a string and print the REVERSE of it.
        static void Question13()
        {
            string word = Console.ReadLine();
            for(int i = word.Length-1; i >= 0; i--)
            {
                Console.Write(word[i]);
            }
        }
        #endregion

        #region Question 14
        // 14- Write a program to allow the user to enter int and print the REVERSED of it.
        static void Question14()
        {
            Console.WriteLine("Enter an integer : ");
            int num = int.Parse(Console.ReadLine());
            int reversed = 0;
            while (num != 0)
            {
                int digit = num % 10;
                reversed = reversed*10 + digit;
                num = num / 10;
            }
            Console.WriteLine(reversed);
        }
        #endregion

        #region Question 15
        // 15- Write a program in C# Sharp to find prime numbers within a range of numbers.
        static void Question15()
        {
            Console.Write("Enter First number : ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter Second number : ");
            int end = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.Write(i + " ");
                }
            }
           
        }
        #endregion

        #region Question 17
        // 17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and(x3, y3), and determines whether these points lie on single straight line.
        static void Question17()
        {
            Console.WriteLine("Enter point 1 (x1 y1):");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter point 2 (x2 y2):");
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter point 3 (x3 y3):");
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());

            // Check if points are collinear
            if ((y2 - y1) / (x2 - x1) == (y3 - y2) / (x3 - x2))
            {
                Console.WriteLine("The points lie on a straight line.");
            }
            else
            {
                Console.WriteLine("The points do NOT lie on a straight line.");
            }
        }
        #endregion

        #region Question 18
        // 
        static void Question18()
        {
            Console.Write("Enter time taken by worker (in hours): ");
            double time = double.Parse(Console.ReadLine());

            if (time >= 2 && time <= 3)
            {
                Console.WriteLine("Highly efficient.");
            }
            else if (time > 3 && time <= 4)
            {
                Console.WriteLine("Increase speed.");
            }
            else if (time > 4 && time <= 5)
            {
                Console.WriteLine("Training required.");
            }
            else if (time > 5)
            {
                Console.WriteLine("Leave the company.");
            }
            else
            {
                Console.WriteLine("Invalid input. Time must be 2 hours or more.");
            }
        }
        #endregion
    }
}
