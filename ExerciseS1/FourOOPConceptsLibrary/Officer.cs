using System;

namespace FourOOPConceptsLibrary
{
    public class Officer : Person
    {
        const int basicSalary = 1500000;
        public int TimeOnSite { get; set; }

        public Officer(string name, DateTime dateOfBirth, int timeOnSite) : base(name, dateOfBirth)
        {
            this.TimeOnSite = timeOnSite;
        }

        public override double BonusCalculation()
        {
            int yearOfBirth = DateOfBirth.Year;
            int age = DateTime.Now.Year - yearOfBirth;

            if (age >= 22 && age <= 25)
            {
                return basicSalary * this.TimeOnSite * 1.1;
            }
            else if (age >= 26 && age <=30)
            {
                return basicSalary * this.TimeOnSite * 1.2;
            }
            else
            {
                return basicSalary * this.TimeOnSite;
            }
        }

        public override void Display()
        {
            Console.WriteLine("Officer: ");
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Date of birth: " + this.DateOfBirth.ToShortDateString());
            Console.WriteLine("Time of site: " + this.TimeOnSite);
            Console.WriteLine("Bonus calculation: " + this.BonusCalculation());
        }
    }
}
