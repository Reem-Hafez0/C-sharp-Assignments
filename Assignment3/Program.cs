namespace Assignment3
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
        }

        #region Question 1
        // 1- Write a program that takes a number from the user then print yes 
        //    if that number can be divided by 3 and 4 otherwise print no.

        static void Question1()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 3 == 0 && num % 4 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        #endregion

        #region Question 2
        // 2- Write a program that allows the user to insert an integer then 
        //    print negative if it is negative number otherwise print positive.

        static void Question2()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
        }
        #endregion

        #region Question 3 
        // 3- Write a program that takes 3 integers from the user then prints 
        //    the max element and the min element.

        static void Question3()
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int num3 = int.Parse(Console.ReadLine());

            int max = Math.Max(num1, Math.Max(num2, num3));
            int min = Math.Min(num1, Math.Min(num2, num3));

            Console.WriteLine("Maximum number is: " + max);
            Console.WriteLine("Minimum number is: " + min);
        }
        #endregion

        #region Question 4 
        // 4- Write a program that allows the user to insert an integer number 
        //    then check if a number is even or odd.

        static void Question4()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
        #endregion

        #region Question 5 
        // 5- Write a program that takes character from the user then if it is a 
        //    vowel char (a, e, i, o, u) then print (vowel) otherwise print (consonant).

        static void Question5()
        {
            Console.Write("Enter a char: ");
            char ch = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("consonant");
            }
        }
        #endregion
    }
}
