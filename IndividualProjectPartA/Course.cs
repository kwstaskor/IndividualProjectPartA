using System;
using System.Collections.Generic;

namespace IndividualProjectPartA
{
    public class Course
    {
        delegate void GetInput(string title, string stream, string type, DateTime startDate, DateTime endDate);
        public string Title { get; private set; }
        public string Stream { get; private set; }
        public string Type { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public readonly List<Assignment> assignmentsPerCourse = new List<Assignment>();
        public readonly List<Trainer> trainersPerCourse = new List<Trainer>();
        public readonly List<Student> studentsPerCourse = new List<Student>();
        public Course()
        {
            GetInput getCourse = (title, description, type, startDate, endDate) =>
            {
                while (true)
                {
                    Console.WriteLine("All Fields Required to be filled\n");
                    Console.Write("Title :"); Title = Console.ReadLine(); if (!Menu.StringValidation(Title)) continue;
                    Console.Write("Stream :"); Stream = Console.ReadLine(); if (!Menu.StringValidation(Stream)) continue;
                    Console.Write("Type :"); Type = Console.ReadLine(); if (!Menu.StringValidation(Type)) continue;
                    Console.Write("Start Date :"); string startCheck = Console.ReadLine(); if (!Menu.DateTimeValidation(startCheck)) { Console.WriteLine("Wrong Date e.g of correct date(1/1/2001)"); continue; }
                    Console.Write("End Date :"); string endCheck = Console.ReadLine(); if (!Menu.DateTimeValidation(endCheck)) { Console.WriteLine("Wrong Date e.g of correct date(1/1/2001)"); continue; }
                    StartDate = DateTime.Parse(startCheck);
                    EndDate = DateTime.Parse(endCheck);
                    break;
                }
            };
            getCourse(Title, Stream, Type, StartDate, EndDate);
        }
        public Course(string title, string stream, string type, DateTime startDate, DateTime endDate)
        {
            Title = title;
            Stream = stream;
            Type = type;
            StartDate = startDate;
            EndDate = endDate;
        }
        public override string ToString()
        {
            return   $"Title : {Title.ToUpper()}\nStream : {Stream.ToUpper()} " +
                     $"Type : {Type.ToUpper()} Start Date : {StartDate:dd/MM/yyyy} " +
                     $"End Date : {EndDate:dd/MM/yyyy}\n";
        }
    }
}
