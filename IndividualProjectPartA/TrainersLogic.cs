using System;
using System.Collections.Generic;

namespace IndividualProjectPartA
{
    public static class TrainersLogic
    {
        public static readonly List<Trainer> allTrainersList = new List<Trainer>();
        public static void RegisterTrainer()
        {
            int counter = 0;
            while (counter != 2)
            {
                Console.Clear();
                var trainer = new Trainer();
                allTrainersList.Add(trainer);
                Console.WriteLine("\n1) Add another trainer \n2) Return to Register Menu");
                counter = Convert.ToInt32(Console.ReadLine());
            }
        }
        private static void CourseSelection(Trainer trainer)
        {
            Console.Clear();
            Console.WriteLine("\n\t\t\t\t----Choose Course/Courses----\n\n\tType Course Number to Assign and PRESS Enter or PRESS Enter without typing a number to exit\n");
            CourseLogic.PrintAllCourses();
            var choise = "k";                                                                           
            while (true)
            {
                choise = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(choise) && Convert.ToInt32(choise) <= CourseLogic.allCoursesList.Count)
                {
                    trainer.trainersCourse = CourseLogic.allCoursesList[Convert.ToInt32(choise) - 1];      
                    if (!trainer.trainersCourse.trainersPerCourse.Contains(trainer))
                        trainer.trainersCourse.trainersPerCourse.Add(trainer);
                    Console.WriteLine($"Trainer : {trainer.FirstName.ToUpper()} added to {trainer.trainersCourse.Title.ToUpper()}\n\nPress Enter to exit or choose another course...");
                }
                else
                break;
            }
        }
        public static void TrainersPerCourseMatch()
        {
            Console.Clear();
            TrainersLogic.PrintAllTrainers();
            Console.WriteLine("\n\t\t\t\t----Choose Trainer----\n\n\t\tType Trainers Number to Assign and PRESS Enter\n");
            var choise = "k";
            choise = Console.ReadLine();
            if (!String.IsNullOrWhiteSpace(choise) && Convert.ToInt32(choise) <= allTrainersList.Count)
            {
                Trainer selectedTrainer = allTrainersList[Convert.ToInt32(choise) - 1];
                CourseSelection(selectedTrainer);
            }
        }
        public static void PrintAllTrainers()
        {
            foreach (var trainer in allTrainersList)
            {
                Console.WriteLine($"{allTrainersList.IndexOf(trainer)+1}) {trainer}");
            }
        }
    }
}
