using System;

namespace FourOOPConceptsLibrary
{
    public abstract class Person
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person(string name, DateTime dateOfBirth)
        {
            this.Name = name;
            this.DateOfBirth = dateOfBirth;
        }

        public abstract double BonusCalculation();

        public virtual void Display()
        {
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Date of birth: " + this.DateOfBirth.ToShortDateString());
            Console.WriteLine("Bonus calculation: " + this.BonusCalculation());
        }
    }
}
