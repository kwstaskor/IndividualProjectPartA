using System;

namespace IndividualProjectPartA
{
    public static class Menu
    {
        static void Main(string[] args)
        {
            Synthetic.CreateSyntheticData();
            MainMenu();
        }
        public static void MainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t\t\t---------------Private School---------------\n\nHello Welcome to Private school");
                Console.WriteLine("Synthetic Data have been added press 3 to delete them....");
                Console.WriteLine("\n\tMain Menu \n1) Register \n2) View all \n3) Delete All Data \n4) Exit \n\n");
                Console.Write("Select an option. : ");

                switch (Console.ReadLine())
                {
                    case "1":
                        RegisterMenu();
                        continue;
                    case "2":
                        PrintMenu();
                        continue;
                    case "3":
                        Synthetic.AllListsClear();
                        continue;
                    case "4":
                        break;
                    default:
                        continue;
                }
                break;
            }
        }
        public static void RegisterMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\tRegister Menu \n1) Add Courses \n2) Add Assignments \n3) Add Trainers \n4) Add Students \n5) Assign Trainers to Courses \n6) Assign Students to Courses \n7) Assign Assignments to Courses"+
                    "\n8) Assign Assignments to Students \n\n");
                Console.Write("Select an option , or press Enter to return to Main Menu  : ");

                switch (Console.ReadLine())
                {
                    case "1":
                        CourseLogic.RegisterCourse();
                        continue;
                    case "2":
                        AssignmentsLogic.RegisterAssignment();
                        continue;
                    case "3":
                        TrainersLogic.RegisterTrainer();
                        continue;
                    case "4":
                        StudentsLogic.RegisterStudent();
                        continue;
                    case "5":
                        if (TrainersLogic.allTrainersList.Count == 0 || CourseLogic.allCoursesList.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("You need to add trainers and courses first....\nPress Enter to return to Register Menu");
                            Console.ReadLine();
                            continue;
                        }
                        TrainersLogic.TrainersPerCourseMatch();
                        continue;
                    case "6":
                        if (StudentsLogic.allStudentsList.Count == 0 || CourseLogic.allCoursesList.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("You need to add students and courses first....\nPress Enter to return to Register Menu");
                            Console.ReadLine();
                            continue;
                        }
                        StudentsLogic.StudentsPerCourseMatch();
                        continue;
                    case "7":
                        if (AssignmentsLogic.allAssignmentsList.Count == 0 || CourseLogic.allCoursesList.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("You need to add assignments and courses first....\nPress Enter to return to Register Menu");
                            Console.ReadLine();
                            continue;
                        }
                        AssignmentsLogic.AssignmentsPerCourseMatch();
                        continue;
                    case "8":
                        if (AssignmentsLogic.allAssignmentsList.Count == 0 || StudentsLogic.allStudentsList.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("You need to add students and assignments first....\nPress Enter to return to Register Menu");
                            Console.ReadLine();
                            continue;
                        }
                        AssignmentsLogic.AssignmentPerStudentMatch();
                        continue;
                    default:
                        break;
                }
                break;
            }
        }
        public static void PrintMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\tLists Menu \n1) All Courses \n2) All Assignments \n3) All Trainers \n4) All Students \n5) Trainers Per Course \n6) Assignments Per Course \n7) Students per Course" +
                    "\n8) Assignments per Student \n9) Students with two courses or more \n10) Assignment Submissions \n\n");
                Console.Write("Select an option , or press Enter to return to Main Menu : ");
                switch (Console.ReadLine())
                {
                    case "1":
                        if (CourseLogic.allCoursesList.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("No courses have been registered yet.\n\nPress Enter to return to View Menu");
                            Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            Console.Clear();
                            CourseLogic.PrintAllCourses();
                            Console.Write("\n\nPress Enter to return to View menu.");
                            Console.ReadLine();
                            continue;
                        }
                    case "2":
                        if (AssignmentsLogic.allAssignmentsList.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("No assignments have been registered yet.\n\nPress Enter to return to View Menu");
                            Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            Console.Clear();
                            AssignmentsLogic.PrintAllAssignments();
                            Console.Write("\n\nPress Enter to return to View menu.");
                            Console.ReadLine();
                            continue;
                        }
                    case "3":
                        if (TrainersLogic.allTrainersList.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("No trainers have been registered yet.\n\nPress Enter to return to View Menu");
                            Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            Console.Clear();
                            TrainersLogic.PrintAllTrainers();
                            Console.Write("\n\nPress Enter to return to View menu.");
                            Console.ReadLine();
                            continue;
                        }
                       
                    case "4":
                        if (StudentsLogic.allStudentsList.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("No students have been registered yet.\n\nPress Enter to return to View Menu");
                            Console.ReadLine();
                            continue;
                        }
                        else
                        {
                           Console.Clear();
                           StudentsLogic.PrintAllStudents();
                           Console.Write("\n\nPress Enter to return to View menu.");
                           Console.ReadLine();
                           continue;
                        }
                    case "5":
                        if (CourseLogic.allCoursesList.Count == 0 || TrainersLogic.allTrainersList.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("No trainers or courses have been registered yet.\n\nPress Enter to return to View Menu");
                            Console.ReadLine();
                            continue;
                        }
                        CourseLogic.PrintAllTrainersPerCourse();
                        continue;
                    case "6":
                        if (AssignmentsLogic.allAssignmentsList.Count == 0 || CourseLogic.allCoursesList.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("No assignments or courses have been registered yet.\n\nPress Enter to return to View Menu");
                            Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            CourseLogic.PrintAllAssignmentsPerCourse();
                            continue;
                        }
                    case "7":
                        if (StudentsLogic.allStudentsList.Count == 0 || CourseLogic.allCoursesList.Count == 0 )
                        {
                            Console.Clear();
                            Console.WriteLine("No students or courses have been registered yet.\n\nPress Enter to return to View Menu");
                            Console.ReadLine();
                            continue;
                        }
                        CourseLogic.PrintAllStudentsPerCourse();
                        continue;
                    case "8":
                        if (StudentsLogic.allStudentsList.Count == 0 || AssignmentsLogic.allAssignmentsList.Count == 0 )
                        {
                            Console.Clear();
                            Console.WriteLine("No students or assignments have been registered yet.\n\nPress Enter to return to View Menu");
                            Console.ReadLine();
                            continue;
                        }
                        StudentsLogic.PrintAllAssignmentsPerStudent();
                        continue;
                    case "9":
                        if (StudentsLogic.studentsWithMoreThanOneCourseList.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("No student has more than one course.\n\nPress Enter to return to View Menu");
                            Console.ReadLine();
                            continue;
                        }
                        StudentsLogic.PrintAllStudentsWithMoreThanOneCourses();
                        continue;
                    case "10":
                        if (StudentsLogic.allStudentsList.Count == 0 || AssignmentsLogic.allAssignmentsList.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("No students or assignments have been registered yet.\n\nPress Enter to return to View Menu");
                            Console.ReadLine();
                            continue;
                        }
                        StudentsLogic.AssignmentSubmissions();
                        continue;
                    default:
                        break;
                }
                break;
            }
        }
        public static bool StringValidation(string input)
        {
            if (String.IsNullOrEmpty(input))
                return false;
            else
                return true;
        }
        public static bool DateTimeValidation(string input)
        {
            try
            {
                Convert.ToDateTime(input);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

