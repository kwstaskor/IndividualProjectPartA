using System;
using System.Collections.Generic;

namespace IndividualProjectPartA
{
    public class Student
    {
        delegate void GetInput(string firstName, string lastName, DateTime date, float TuitionFee);
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public float TuitionFee { get; private set; }
        public Course studentsCourse;
        public Assignment studentsAssignment;
        public List<Course> studentsCourses = new List<Course>();
        public List<Assignment> assignmentsPerStudent = new List<Assignment>();
        public Student() 
        {
            GetInput getStudent = (firstName, lastName, date , tuitionFee) =>
            {
                while (true)
                {
                    Console.WriteLine("All Fields Required to be filled\n");
                    Console.Write("First Name :"); FirstName = Console.ReadLine(); if (!Menu.StringValidation(FirstName)) continue;
                    Console.Write("Last Name :"); LastName = Console.ReadLine(); if (!Menu.StringValidation(LastName)) continue;
                    Console.Write("Tuition Fee :"); string feeCheck = Console.ReadLine(); if (!Menu.StringValidation(feeCheck)) continue;
                    Console.Write("Date of birth :"); string dateCheck = Console.ReadLine(); if (!Menu.DateTimeValidation(dateCheck)) { Console.WriteLine("Wrong Date e.g of correct date(1/1/2001)"); continue; }
                    DateOfBirth = DateTime.Parse(dateCheck);
                    TuitionFee = Convert.ToSingle(feeCheck);
                    break;
                }
            };
            getStudent(FirstName, LastName, DateOfBirth , TuitionFee);
        }
        public Student(string firstName, string lastName, DateTime dateOfBirth , float tuitionFee)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            TuitionFee = tuitionFee;
        }
        public override string ToString()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            return ($"{FirstName.ToUpper()} {LastName.ToUpper()}  " +
                $"Date of birth : {DateOfBirth:dd/MM/yyyy} Tuition fee : {TuitionFee}€\n");
        }
    }
}

