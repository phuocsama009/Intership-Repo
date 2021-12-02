using ExerciseS1.FourOOPConcepts;
using System;

namespace ExerciseS1
{
    class Program
    {
        static void Main(string[] args)
        {
            Officer officer = new Officer("Nguyen Van Teo", new DateTime(2000, 07, 07), 6);
            Staff staff = new Staff("Nguyen Thanh Truc", new DateTime(2001, 09, 09), "Part time", 28);

            officer.Display();
            Console.WriteLine();
            staff.Display();
        }
    }
}
