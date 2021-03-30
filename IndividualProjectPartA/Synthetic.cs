using System;
using System.Collections.Generic;

namespace IndividualProjectPartA
{
    public static class Synthetic
    {
        public static void CreateSyntheticData()
        {
            //students Creation 
            var studentKostas = new Student("Kostas", "Papaxristou", new DateTime(1991, 5, 5), 1000);
            var studentXristos = new Student("Xristos", "Papakostas", new DateTime(1991, 4, 5), 1000);
            var studentGiorgos = new Student("Giorgos", "Ioanou", new DateTime(1991, 6, 5), 1200);
            var studentGiannis = new Student("Giannis", "Georgiou", new DateTime(1991, 3, 3), 1250);
            var studentXristina = new Student("Xristina", "Papakosta", new DateTime(1991, 2, 3), 1500);
            StudentsLogic.allStudentsList.Add(studentKostas);
            StudentsLogic.allStudentsList.Add(studentXristos);
            StudentsLogic.allStudentsList.Add(studentGiorgos);
            StudentsLogic.allStudentsList.Add(studentGiannis);
            StudentsLogic.allStudentsList.Add(studentXristina);
            // trainer Creation
            var trainerGiorgos = new Trainer("Giorgos", "Evagelou", "Computer Science");
            var trainerVagelis = new Trainer("Vagelis", "Dimitrou", "Computer Science");
            var trainerDimitris = new Trainer("Dimitris", "Kostantinou", "Computer Science");
            var trainerAndreas = new Trainer("Andreas", "Andreou", "Computer Science");
            TrainersLogic.allTrainersList.Add(trainerGiorgos);
            TrainersLogic.allTrainersList.Add(trainerVagelis);
            TrainersLogic.allTrainersList.Add(trainerDimitris);
            TrainersLogic.allTrainersList.Add(trainerAndreas);
            //assignment Creation
            var assignmentPR = new Assignment("Private School", "Individual Project", new DateTime(2021, 3, 31), 20, 100);
            var assignmentDB = new Assignment("Data Bases", "Individual Project", new DateTime(2021, 3, 31), 10, 100);
            var assignmentWS = new Assignment("Web Security", "Group Project", new DateTime(2021, 3, 15), 30, 100);
            var assignmentWA = new Assignment("Web Aplication", "Group Project", new DateTime(2021, 3, 15), 45, 100);
            AssignmentsLogic.allAssignmentsList.Add(assignmentPR);
            AssignmentsLogic.allAssignmentsList.Add(assignmentDB);
            AssignmentsLogic.allAssignmentsList.Add(assignmentWS);
            AssignmentsLogic.allAssignmentsList.Add(assignmentWA);
            //course Creation
            var courseJavaF = new Course("Programing Advanced", "Java", "Full Time", new DateTime(2021, 2, 15), new DateTime(2021, 5, 15));
            var courseJavaP = new Course("Programing Fundamentals", "Java", "Part Time", new DateTime(2021, 2, 15), new DateTime(2021, 9, 15));
            var courseCsharpF = new Course("Programing Advanced", "C#", "Full Time", new DateTime(2021, 2, 15), new DateTime(2021, 5, 15));
            var courseCsharpP = new Course("Programing Fundamentals", "C#", "Part Time", new DateTime(2021, 2, 15), new DateTime(2021, 9, 15));
            CourseLogic.allCoursesList.Add(courseJavaF);
            CourseLogic.allCoursesList.Add(courseJavaP);
            CourseLogic.allCoursesList.Add(courseCsharpF);
            CourseLogic.allCoursesList.Add(courseCsharpP);
        }
        public static void AllListsClear()
        {
            StudentsLogic.allStudentsList.Clear();
            StudentsLogic.studentsWithMoreThanOneCourseList.Clear();
            TrainersLogic.allTrainersList.Clear();
            CourseLogic.allCoursesList.Clear();
            AssignmentsLogic.allAssignmentsList.Clear();
            foreach (var course in CourseLogic.allCoursesList)
            {
                course.studentsPerCourse.Clear();
                course.trainersPerCourse.Clear();
                course.assignmentsPerCourse.Clear();
            }
            foreach (var student in StudentsLogic.allStudentsList)
            {
                student.assignmentsPerStudent.Clear();
            }
        }
   }
}

