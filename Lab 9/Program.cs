using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {

            //Student s1 = new Student("Tommy", "Ohio", "Chicken Curry", "Green");
            //Student s2 = new Student("Dekoda", "Kent", "Pho", "Blue");
            //Student s3 = new Student("Cody", "Lawton", "Potato Soup", "Yelloe");
            //Student s4 = new Student("Joshua", "Grand Rapids", "Potato Soup", "Red");
            //Student s5 = new Student("Kim", "Grand Rapids", "Sushi", "Pink");
            //Student s6 = new Student("James", "Grand Rapids", "Cheeseburger", "Red");

            //Student.Add(s1);
            //Student.Add(s2);
            //Student.Add(s3);
            //Student.Add(s4);
            //Student.Add(s5);
            //Student.Add(new Student("James", "Grand Rapids", "Cheeseburger", "Red");
            //students = students.OrderBy(x => x.Name).ToList();

            Console.WriteLine("Welcome to C# class");


            AddStudent("Tommy", "Ohio", "Chicken Curry", "Green");
            AddStudent("Dekoda", "Kent", "Pho", "Blue");
            AddStudent("Cody", "Lawton", "Potato Soup", "Yelloe");
            AddStudent("Joshua", "Grand Rapids", "Potato Soup", "Red");
            AddStudent("Kim", "Grand Rapids", "Sushi", "Pink");
            AddStudent("James", "Grand Rapids", "Cheeseburger", "Red");

            AddStudentAlphabetically();

            string studentInfo = GetInput();
            Console.WriteLine(studentInfo);



            Console.ReadKey();

        }
        public static List<Student> students = new List<Student>();

        //sorting list alphabetically
        //public static List<string> SortStringLIst(List<string> unsortedList)
        //{
        //    Student s1 = unsortedList[0];
        //    Student s1 = unsortedList[0];
        //    string name1 = s1.Name.ToLower();
        //    string name2 = s2.Name.ToLower();

        //    char c1 = name1[0];
        //    char c2 = name2[0];

        //    if (c1 > c2)
        //    {
        //        // name2 needs to be earlier in the list
        //    }
        //    else if (c1 < c2)
        //    {
        //        //they are in order so we can move on
        //    }
        //    else
        //    {
        //        //they're equal we need to check the next letter
        //    }


        //}

        public static void AddStudent(string name, string hometown, string favfood, string favcolor)
        {
            students.Add(new Student(name, hometown, favfood, favcolor));
        }

        public static void AddStudentAlphabetically()
        {
            students = students.OrderBy(x => x.Name).ToList();
        }

        public static string GetStudent(int index)
        {
            try
            {
                return ($"Student Name: {students[index].Name}, Favorite Food: {students[index].FavoriteFood}, Hometown: {students[index].HomeTown}, " +
                    $"Favorite Color: {students[index].FavoriteColor}");

            }
            catch (IndexOutOfRangeException)
            {
                return ("Student not found, try another index");
            }

        }

        public static void StudentList()
        {
            for (int i = 0; i < students.Count; i++)
            {
                string name = students[i].Name;
                if (name != "")
                {
                    Console.WriteLine(i + 1 + ") " + students[i].Name);
                }
            }


        }

        public static string GetInput()
        {
            StudentList();
            Console.WriteLine("Please select index of the student you want to learn about.");
            string input = Console.ReadLine();

            try
            {
                int index = int.Parse(input);

                if (students[index - 1].Name == "")
                {
                    Console.WriteLine("Student not found, try another index.");
                    return GetInput();
                }
                else
                {
                    return GetStudent(index - 1);
                }

            }
            catch (FormatException)
            {
                return GetInput();
            }

        }

        //public static void LearnMore(int index)
        //{




        //}
    }
}
