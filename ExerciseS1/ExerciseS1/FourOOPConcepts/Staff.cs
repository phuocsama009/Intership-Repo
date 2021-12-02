using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseS1.FourOOPConcepts
{
    class Staff : Person
    {
        public string Position { get; set; }
        public int WorkDay { get; set; }

        public Staff(string name, DateTime dateOfBirth, string position, int workDay) : base(name, dateOfBirth)
        {
            this.Position = position;
            this.WorkDay = workDay;
        }

        public override double BonusCalculation()
        {
            if (this.WorkDay == 28)
            {
                return 50000 * 28;
            }
            else if (this.WorkDay < 28)
            {
                return 40000 * this.WorkDay;
            }

            return 0;
        }

        public override void Display()
        {
            Console.WriteLine("Staff: ");
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Date of birth: " + this.DateOfBirth.ToShortDateString());
            Console.WriteLine("Position: " + this.Position);
            Console.WriteLine("Work day: " + this.WorkDay);
            Console.WriteLine("Bonus calculation: " + this.BonusCalculation());
        }
    }
}
