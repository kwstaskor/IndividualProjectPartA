using System;
using System.Collections.Generic;

namespace IndividualProjectPartA
{
    public static class CourseLogic
    {
        public static readonly List<Course> allCoursesList = new List<Course>();

        public static void RegisterCourse()
        {
            int counter = 0;
            while (counter != 2)
            {
                Console.Clear();
                var course = new Course();
                allCoursesList.Add(course);
                Console.WriteLine("\n1) Add another course \n2) Return to Register Menu");
                counter = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void PrintAllCourses()
        {
            foreach (var course in allCoursesList)
            {
                Console.WriteLine($"{allCoursesList.IndexOf(course)+1}) {course}");
            }
        }
        public static void PrintAllTrainersPerCourse()
        {
            Console.Clear();
            Console.WriteLine("\t\tType Course Number end PRESS Enter\n");
            PrintAllCourses();                                    
            var choise = Console.ReadLine();
            if (!String.IsNullOrWhiteSpace(choise) && Convert.ToInt32(choise) <= allCoursesList.Count)
            {
              Course course = allCoursesList[Convert.ToInt32(choise) - 1];
                ShowAllTrainersPerCourse(course);
            }
        }
        public static void ShowAllTrainersPerCourse(Course course)
        {
            Console.Clear();
            foreach (var trainer in course.trainersPerCourse)
            {
                Console.WriteLine($"First Name :{trainer.FirstName.ToUpper()} Last Name :{trainer.LastName.ToUpper()}");
            }
            Console.Write("\n\nPress Enter key to return to View Menu.");
            Console.ReadLine();
        }
        public static void PrintAllStudentsPerCourse()
        {
            Console.Clear();
            Console.WriteLine("\t\tType Course Number end PRESS Enter\n");
            PrintAllCourses();
            var choise = Console.ReadLine();
            if (!String.IsNullOrWhiteSpace(choise) && Convert.ToInt32(choise) <= allCoursesList.Count)
            {
                Course course = allCoursesList[Convert.ToInt32(choise) - 1];
                ShowAllStudentsPerCourse(course);
            }
        }
        public static void ShowAllStudentsPerCourse(Course course)
        {
            Console.Clear();
            foreach (var student in course.studentsPerCourse)
            {
                Console.WriteLine($"First Name :{student.FirstName.ToUpper()} Last Name :{student.LastName.ToUpper()}");
            }
            Console.Write("\n\nPress Enter key to return to View Menu.");
            Console.ReadLine();
        }
        public static void PrintAllAssignmentsPerCourse()
        {
            Console.Clear();
            Console.WriteLine("\t\tType Course Number end PRESS Enter\n");
            PrintAllCourses();
            var choise =Console.ReadLine();
            if (!String.IsNullOrWhiteSpace(choise) && Convert.ToInt32(choise) <= allCoursesList.Count)
            {
                Course course = allCoursesList[Convert.ToInt32(choise) - 1];
                ShowAllAssignmentsPerCourse(course);
            }
        }
        public static void ShowAllAssignmentsPerCourse(Course course)
        {
            Console.Clear();
            foreach (var assignmet in course.assignmentsPerCourse)
            {
                Console.WriteLine($"Assignment :{assignmet.Title.ToUpper()} Description :{assignmet.Description.ToUpper()}");
            }
            Console.Write("\n\nPress Enter key to return to View Menu.");
            Console.ReadLine();
        }
    }
}
