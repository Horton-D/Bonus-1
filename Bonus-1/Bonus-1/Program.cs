using System;

namespace Bonus_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var grader = new GradeCalc();
            Console.WriteLine("Welcome to Letter Grade Converter");
            string response;
            do
            {
                Console.WriteLine("Enter score!");
                var num = int.Parse(Console.ReadLine());
                Console.WriteLine(grader.LetterGrade(num));
                Console.WriteLine("Continue Y/N?");
                response = Console.ReadLine();

            } while (response.Equals("y",StringComparison.OrdinalIgnoreCase));

        }
    }

}
    

