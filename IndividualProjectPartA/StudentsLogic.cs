using System;
using System.Collections.Generic;

namespace IndividualProjectPartA
{
   
    public static class StudentsLogic
    {
        public static readonly List<Student> allStudentsList = new List<Student>();
        public static readonly List<Student>  studentsWithMoreThanOneCourseList = new List<Student>();
        public static void RegisterStudent()
        {
            int counter = 0;
            while (counter != 2)
            {
                Console.Clear();
                var student = new Student();
                allStudentsList.Add(student);
                Console.WriteLine("\n1) Add another Student \n2) Return to Register Menu");
                counter = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void PrintAllStudents()
        {
            foreach (var student in allStudentsList)
            {
                Console.WriteLine($"{allStudentsList.IndexOf(student)+1}) {student}");
            }
        }
        private static void CourseSelection(Student student)
        {
            Console.Clear();
            Console.WriteLine("\n\t\t\tChoose Course/Courses\n\n\tType Course Number to Assign and PRESS Enter or PRESS Enter without typing a number to exit\n");
            CourseLogic.PrintAllCourses();
            var choise = "k";                                                           
            while (true)
            {
                choise = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(choise) && Convert.ToInt32(choise) <= CourseLogic.allCoursesList.Count)
                {
                    student.studentsCourse = CourseLogic.allCoursesList[Convert.ToInt32(choise) - 1];
                    student.studentsCourses.Add(student.studentsCourse);
                    if (!student.studentsCourse.studentsPerCourse.Contains(student))
                        student.studentsCourse.studentsPerCourse.Add(student);
                    Console.WriteLine($"Student : {student.FirstName.ToUpper()} added to {student.studentsCourse.Title.ToUpper()}\n\nPress Enter to exit or choose another course...");
                }
                else
                    break;
            }
            if (student.studentsCourses.Count > 1)                                    // Students With More than One Course List
            {
                studentsWithMoreThanOneCourseList.Add(student);
            }
        }
        public static void StudentsPerCourseMatch()
        {
            Console.Clear();
            PrintAllStudents();
            Console.WriteLine("\n\t\t\t\t----Choose Student----\n\n\t\tType Students Number to Assign and PRESS Enter\n");
            var choise = "k";
            choise = Console.ReadLine();
            if (!String.IsNullOrWhiteSpace(choise) && Convert.ToInt32(choise) <= allStudentsList.Count)
            {
                Student selectedStudent = allStudentsList[Convert.ToInt32(choise) - 1];
                CourseSelection(selectedStudent);
            }
        }
        public static void PrintAllStudentsWithMoreThanOneCourses()
        {
            Console.Clear();
            foreach (var student in studentsWithMoreThanOneCourseList)
            {
                Console.WriteLine($"Student Name :{student.FirstName.ToUpper()} {student.LastName.ToUpper()}");
            }
            Console.Write("\n\nPress Enter to return to View Menu.");
            Console.ReadLine();
        }
        public static void PrintAllAssignmentsPerStudent()
        {
            Console.Clear();
            Console.WriteLine("\t\tType Student Number end PRESS Enter\n");
            PrintAllStudents();
            var choise = Console.ReadLine();
            if (!String.IsNullOrWhiteSpace(choise) && Convert.ToInt32(choise)-1 <= allStudentsList.Count)
            {
                Student student = allStudentsList[Convert.ToInt32(choise) - 1];
                ShowAllAssignmentsPerStudent(student);
            }
        }
        private static void ShowAllAssignmentsPerStudent(Student student)
        {
            Console.Clear();
            foreach (var assignment in student.assignmentsPerStudent)
            {
                Console.WriteLine($"Title :{assignment.Title.ToUpper()} Description :{assignment.Description.ToUpper()} Submission date : {assignment.SubDateTime:dd/MM/yyyy}");
            }
            Console.Write("\n\nPress Enter key to return to View Menu.");
            Console.ReadLine();
        }
        private static void AssignmentsSubmissionsCheck(Student student, DateTime date)
        {
            foreach (var assignment in student.assignmentsPerStudent)
            {
                DateTime startTheWeek = new DateTime();
                DateTime endTheWeek = new DateTime();
                if (date.DayOfWeek == DayOfWeek.Monday)
                {
                   startTheWeek = date;
                   endTheWeek = date.AddDays(4);
                }
                else if (date.DayOfWeek == DayOfWeek.Tuesday)
                {
                    startTheWeek = date.AddDays(-1);
                    endTheWeek = date.AddDays(3);
                }
                else if (date.DayOfWeek == DayOfWeek.Wednesday)
                {
                    startTheWeek = date.AddDays(-2);
                    endTheWeek = date.AddDays(2);
                }
                else if (date.DayOfWeek == DayOfWeek.Thursday)
                {
                    startTheWeek = date.AddDays(-3);
                    endTheWeek = date.AddDays(1);
                }
                else if (date.DayOfWeek == DayOfWeek.Friday)
                {
                    startTheWeek = date.AddDays(-4);
                    endTheWeek = date;
                }
                else if (date.DayOfWeek == DayOfWeek.Saturday)
                {
                    startTheWeek = date.AddDays(-5);
                    endTheWeek = date.AddDays(-1);
                }
                else if (date.DayOfWeek == DayOfWeek.Sunday)
                {
                    startTheWeek = date.AddDays(-6);
                    endTheWeek = date.AddDays(-2);
                }

                if (startTheWeek <= assignment.SubDateTime && endTheWeek >= assignment.SubDateTime)
                {
                    Console.WriteLine($"Student : {student.FirstName.ToUpper()} {student.LastName.ToUpper()} Assignment : {assignment.Title.ToUpper()} " +
                    $"{assignment.SubDateTime:dd/MM/yyyy}");
                }
            }
        }
        public static void AssignmentSubmissions()
        {
            Console.Clear();
            Console.WriteLine("Write a date to check witch student need to submit assignments this week(e.g. 01/1/2001).");
            var input = Console.ReadLine();
            if (DateTime.TryParse(input , out DateTime date)) { }
            else
            {
                Console.WriteLine("Not valid date, please try again. Valid date example: 01/1/2001 \n\nPress Enter key to return to View Menu. ");
                Console.ReadLine();
                Menu.PrintMenu();
            }
            foreach (var student in allStudentsList)
            {
                AssignmentsSubmissionsCheck(student, date);
            }
            Console.Write("\n\nPress Enter key to return to View Menu.");
            Console.ReadLine();
        }
    }
}
