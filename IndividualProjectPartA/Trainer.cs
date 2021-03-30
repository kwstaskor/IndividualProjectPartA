using System;

namespace IndividualProjectPartA
{
    public class Trainer 
    {
        delegate void GetInput(string firstName,string lastName,string subject);
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Subject { get; private set; }
        public Course trainersCourse;
        public Trainer() 
        {
            GetInput getTrainer = (firstName, lastName, subject) =>
            {
                while (true)
                {
                    Console.WriteLine("All Fields Required to be filled\n");
                    Console.Write("First Name :"); FirstName = Console.ReadLine(); if (!Menu.StringValidation(FirstName)) continue;
                    Console.Write("Last Name :"); LastName = Console.ReadLine(); if (!Menu.StringValidation(LastName)) continue;
                    Console.Write("Subject :"); Subject = Console.ReadLine(); if (!Menu.StringValidation(Subject)) continue;
                    break;
                }
            };
            getTrainer(FirstName, LastName, Subject);
        }
        public Trainer(string firstname, string lastname, string subject)
        {
            FirstName = firstname;
            LastName = lastname;
            Subject = subject;
        }
        public override string ToString()
        {
             return $"{FirstName.ToUpper()} {LastName.ToUpper()} Subject : {Subject.ToUpper()}";
        }
    }
}
