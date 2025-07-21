using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Security.Claims;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP_Assignment_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// part 1 ////
            // Question1();
            // Question2();
            // Question3();
            // Question4();
            // Question5();
            // Question6();
            // Question7();
            //// part 2 ////
            // Question01();
            // Question02();
            // Question06();
        }
        
        // part 1 //
        #region Question1
        //1- Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.Then, write a C# program that prints out all the days of the week using this enum.
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Question1()
        {
            for(int i = 0; i <= (int)WeekDays.Sunday; i++)
            {
                Console.WriteLine((WeekDays)i);
            }
        }
        #endregion

        #region Question2
        // 2. Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data.Then, write a C# program to display the details of all the persons in the array. 
        struct Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        static void Question2()
        {
            Person[] people = new Person[3];

            people[0] = new Person { Name = "Reem", Age = 20 };
            people[1] = new Person { Name = "Nada", Age = 25 };
            people[2] = new Person { Name = "Ahmed", Age = 30 };

            foreach(var p in people)
            {
                Console.WriteLine($"Name: {p.Name}, Age: {p.Age}");
            }
        }
        #endregion

        #region Question3
        // 3. Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members.Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons (spring march to may , summer june toaugust, autumn September to November, winter December to February)
        enum Seasons
        {
            Spring, 
            Summer, 
            Autumn,
            Winter
        }
        static void Question3()
        {
            Console.WriteLine("Enter a Season : ");
            string name = Console.ReadLine();
            if (Enum.TryParse(name, true, out Seasons season)) 
            {
                switch (season)
                {
                    case Seasons.Spring:
                        Console.WriteLine("march to may");
                        break;
                    case Seasons.Summer:
                        Console.WriteLine("june to august ");
                        break;
                    case Seasons.Autumn:
                        Console.WriteLine(" September to November");
                        break;
                    case Seasons.Winter:
                        Console.WriteLine("December to February");
                        break;
                }
            }
            else Console.WriteLine("Invalid input");
        }
        #endregion

        #region Question4
        // 4. Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum. Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable.
        enum Permissions
        {
            None=0,
            Read=1,
            Write=2,
            Delete=4,
            Execute=8
        }
        static void Question4()
        {
            Permissions user1 = Permissions.None;
            // Add 
            user1 |= Permissions.Read;
            user1 |= Permissions.Write; 
            user1 |= Permissions.Delete;
            user1 |= Permissions.Execute;
            Console.WriteLine($"Current Permissions: {user1}"); // 1111 15
            // delete
            user1 &= ~Permissions.Execute;
            Console.WriteLine($"Current Permissions: {user1}"); // 0111 7
            // check
            if ((user1 & Permissions.Read)==Permissions.Read)
            {
                Console.WriteLine("Read exists");
            }
            else Console.WriteLine("Not exists");
        }
        #endregion

        #region Question5
        // 5. Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members.Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
        enum Colors
        {
            Red,
            Green,
            Blue
        }
        static void Question5()
        {
            Console.Write("Enter a color : ");
            string color = Console.ReadLine();
            if (Enum.TryParse(color, true, out Colors col))
            {
                if (col == Colors.Red || col == Colors.Green || col == Colors.Blue)
                {
                    Console.WriteLine("primary color");
                }
                else Console.WriteLine("Not a primary color");
            }
        }
        #endregion

        #region Question6
        // Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
        struct Point
        {
            public double x { get; set; }
            public double y { get; set; }

        }
        static void Question6()
        {
            Point p1 = new Point();
            Point p2 = new Point();

            Console.WriteLine("Enter X1 : ");
            p1.x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y1 : ");
            p1.y = double.Parse(Console.ReadLine());
            Console.WriteLine("----------------");
            Console.WriteLine("Enter X2 : ");
            p2.x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y2 : ");
            p2.y = double.Parse(Console.ReadLine());

            double Distance = Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
            Console.WriteLine(Distance);
        }
        #endregion

        #region Question7
        // 7. Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
        struct person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        static void Question7()
        {
            person[] people = new person[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter Name for Person {i + 1}: ");
                people[i].Name = Console.ReadLine();
                Console.Write($"Enter Age for Person {i + 1}: ");
                people[i].Age = int.Parse(Console.ReadLine());
            }
            person oldest = people[0];
            foreach (var p  in people)
            {
                if (p.Age > oldest.Age)
                    oldest = p;
            }
            Console.WriteLine($"Oldest Person: {oldest.Name}, Age: {oldest.Age}");
        }
        #endregion

        // part 2 //
        #region Question01
        // 1. Design and implement a Class for the employees in a company: Employee is identified by an ID, Name, security level, salary, hire date and Gender.
        [Flags]
        public enum Securitylevels
        {
            None=0,
            guest=1,
            Developer=2,
            secretary=4,
            DBA=8,
            Full= guest | Developer | secretary | DBA  
            //Authorized,
            //Not
        }
        public class Employee
        {
            // fields and properties //
            private int id;
            private string name;
            private decimal salary;
            private char gender;
            public Securitylevels Security { get; set; }
            public DateTime Hiring_date { get; set; }

            public int Id
            {
                get { return id; } 
                set { id = value <0 ? 0 : value; }
            }
            public string Name
            {
                get { return name; }
                set {  name = string.IsNullOrWhiteSpace(value)? "unknown" : value; }
            }
            public decimal Salary
            {
                get { return salary; }
                set { salary = value <0 ? 0 : value; }
            }
            public char Gender
            {
                get { return gender; }
                set
                {
                    char g = char.ToLower(value);
                    gender = (g != 'f' || g != 'm') ? 'm':g;
                }
            }

            // constructors //
            public Employee() { }
            public Employee(int _id, string _name, decimal _salary, char _gender, Securitylevels _security_level, DateTime _Hiring_date)
            {
                id= _id;
                name= _name;
                salary= _salary;
                gender= _gender;
                Security= _security_level;
                Hiring_date = _Hiring_date;
            }

            // override tostring method //
            public override string ToString()
            {
                return string.Format("Id : {0} , Name : {1} , Salary : {2:c} , Gender : {3} , Security Level : {4} , Hiring Date : {5}",
                    id, name, salary, gender, Security,Hiring_date
                    );
            }
        }
        static void Question01()
        {
            Employee emp = new Employee(1, "Reem", 9000m, 'f', Securitylevels.DBA, new DateTime(2025, 5, 25));
            Console.WriteLine(emp);
        }
        #endregion

        #region Question02
        // 2. Develop a Class to represent the Hiring Date Data: consisting of fields to hold the day, month and Years.
        class HiringDateDATA
        {
            // fields //
            private int day;
            private int month;
            private int year;
            // properties //
            public int Day
            {
                get { return Day; }
                set
                {
                    int d = value;
                    Day = (d<1 || d>31)? 1: d ;
                }
            }
            public int Month
            {
                get { return Month; }
                set
                {
                    int m = value;
                    month = (m<1 || m>12)? 1: m ;
                }
            }
            public int Year
            {
                get{ return Year; }
                set
                {
                    int y = value;
                    year = (y < 1900 || y > 2100) ? 2000 : y;
                }
            }
            // constructors // 
            public HiringDateDATA() { }
            public HiringDateDATA(int _day,int _month,int _year)
            {
                day= _day;
                month= _month;
                year= _year;
            }
            // override tostring method //
            public override string ToString()
            {
                return $"Day: {day}, Month: {month}, Year: {year}";
            }
        }
        static void Question02()
        {
            HiringDateDATA date = new HiringDateDATA(25,5,2025);
            Console.WriteLine(date);
        }
        #endregion

        #region Question03
        // 3. We need to restrict the Gender field to be only M or F [Male or Female]  
        // See Q01
        #endregion

        #region Question04
        // 4. Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum
        // See Q01
        #endregion

        #region Question05
        // 5. We want to provide the Employee Class to represent Employee data in a string Form(override ToString()), display employee salary in a currency format. [use String.Format Function]
        // See Q01
        #endregion

        #region Question06

        static void Question06()
        {
            Employee[] EmpArr = new Employee[3];
            EmpArr[0] = new Employee(0, "Nada", 9000m, 'f', Securitylevels.DBA, new DateTime(2025, 5, 25));
            EmpArr[1] = new Employee(1, "Sara", 10000m, 'f', Securitylevels.guest, new DateTime(2025, 5, 25));
            EmpArr[2] = new Employee(2, "Ahmed", 11000m, 'm', Securitylevels.Full, new DateTime(2025, 5, 25));

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(EmpArr[i]);
            }
        }
        #endregion

    }
}
