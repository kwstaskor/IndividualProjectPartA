using System;
using System.Collections.Generic;

namespace IndividualProjectPartA
{
    public static class AssignmentsLogic
    {
        public static readonly List<Assignment> allAssignmentsList = new List<Assignment>();
        public static void RegisterAssignment()
        {
            int counter = 0;
            while (counter != 2)
            {
                Console.Clear();
                var assignment = new Assignment();
                allAssignmentsList.Add(assignment);
                Console.WriteLine("\n1) Add another Assignment \n2) Return to Register Menu"); 
                counter = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static void CourseSelection(Assignment assignment)
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
                    assignment.assignmentsCourse = CourseLogic.allCoursesList[Convert.ToInt32(choise) - 1];
                    if (!assignment.assignmentsCourse.assignmentsPerCourse.Contains(assignment))
                    assignment.assignmentsCourse.assignmentsPerCourse.Add(assignment);
                    Console.WriteLine($"{assignment.Title.ToUpper()} added to {assignment.assignmentsCourse.Title.ToUpper()}\nPress Enter to exit or choose another course...");
                }
                else
                break;
            }
        }
        public static void AssignmentsPerCourseMatch()
        {
            Console.Clear();
            PrintAllAssignments();
            Console.WriteLine("\n\t\t\t\t----Choose Assignment----\n\n\t\tType Assignments Number to Assign and PRESS Enter\n");
            var choise = "k";
            choise = Console.ReadLine();
            if (!String.IsNullOrWhiteSpace(choise) && Convert.ToInt32(choise) <= allAssignmentsList.Count)
            {
                Assignment selectedAssignment = allAssignmentsList[Convert.ToInt32(choise) - 1];
                CourseSelection(selectedAssignment);
            }
        }
        public static void StudentSelection(Assignment assignment)
        {
            Console.Clear();
            Console.WriteLine("\n\t\t\tChoose Student/Students\n\n\tType Students Number to Assign and PRESS Enter or PRESS Enter without typing a number to exit\n");
            StudentsLogic.PrintAllStudents();
            var choise = "k";
            while (true)
            {
                choise = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(choise) && Convert.ToInt32(choise) <= StudentsLogic.allStudentsList.Count)
                {
                    assignment.assignmentsStudent = StudentsLogic.allStudentsList[Convert.ToInt32(choise) - 1];
                    if (!assignment.assignmentsStudent.assignmentsPerStudent.Contains(assignment))
                    assignment.assignmentsStudent.assignmentsPerStudent.Add(assignment);

                    Console.WriteLine($"{assignment.Title.ToUpper()} added to {assignment.assignmentsStudent.FirstName.ToUpper()}\nPress Enter to exit or choose another student...");
                }
                else
                    break;
            }
        }
        public static void AssignmentPerStudentMatch()
        {
            Console.Clear();
            PrintAllAssignments();
            Console.WriteLine("\n\t\t\t\t----Choose Assignment----\n\n\t\tType Assignments Number to Assign and PRESS Enter\n");
            var choise = "k";
            choise = Console.ReadLine();
            if (!String.IsNullOrWhiteSpace(choise) && Convert.ToInt32(choise) <= allAssignmentsList.Count)
            {
                Assignment selectedAssignment = allAssignmentsList[Convert.ToInt32(choise) - 1];
                StudentSelection(selectedAssignment);

            }
        }
        public static void PrintAllAssignments()
        {
            foreach (var assignment in allAssignmentsList)
            {
                Console.WriteLine($"{allAssignmentsList.IndexOf(assignment)+1}) {assignment}");
            }
        }
    }
}
