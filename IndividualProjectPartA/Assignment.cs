using System;

namespace IndividualProjectPartA
{
    public class Assignment
    {
        delegate void GetInput(string title, string stream, DateTime subDate, float oralMark , float totalMark);
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime SubDateTime { get; private set; }
        public float OralMark { get; private set; }
        public float TotalMark { get; private set; }
        public Course assignmentsCourse;
        public Student assignmentsStudent;      
        public Assignment()
        {
            GetInput getAssignment = (title, description, subtDate, oralMark , totalMark) =>
            {
                while (true)
                {
                    Console.WriteLine("All Fields Required to be filled\n");
                    Console.Write("Title :"); Title = Console.ReadLine(); if (!Menu.StringValidation(Title)) continue;
                    Console.Write("Description :"); Description = Console.ReadLine(); if (!Menu.StringValidation(Description)) continue;
                    Console.Write("Submission Date :"); string dateCheck = Console.ReadLine(); if (!Menu.DateTimeValidation(dateCheck)) { Console.WriteLine("Wrong Date e.g of correct date(1/1/2001)"); continue; }
                    Console.Write("Oral Mark :"); string oralMarkCheck = Console.ReadLine(); if (!Menu.StringValidation(oralMarkCheck)) continue;
                    Console.Write("Total Mark :"); string totalMarkCheck = Console.ReadLine(); if (!Menu.StringValidation(totalMarkCheck)) continue;
                    SubDateTime = DateTime.Parse(dateCheck);
                    OralMark = Convert.ToSingle(oralMarkCheck);
                    TotalMark = Convert.ToSingle(totalMarkCheck);
                    break;
                }
            };
            getAssignment(Title, Description, SubDateTime, OralMark, TotalMark);
        }
        public Assignment(string title, string description, DateTime subDateTime, float oralMark , float totalMark)
        {
            Title = title;
            Description = description;
            SubDateTime = subDateTime;
            OralMark = oralMark;
            TotalMark = totalMark;
        }
        public override string ToString()
        {
            return  $"Title : {Title.ToUpper()}\nDescription : {Description.ToUpper()} " +
                    $"Submission Date : {SubDateTime:dd/MM/yyyy} " +
                    $"Oral Mark : {OralMark} Total Mark : {TotalMark}\n";
        }
    }
}
