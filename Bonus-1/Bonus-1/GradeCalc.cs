using System;
namespace Bonus_1
{
    public class GradeCalc
    {

        public GradeCalc()
        {

        }

        public string LetterGrade(int grades)
        {

            Console.WriteLine("Welcome to Letter Grade Converter");

            string response;
            do
            {
                
                if (grades <= 100 && grades >= 88)
                {
                    return $"Letter grade: A";

                }
                else if (grades <= 87 && grades >= 80)
                {
                    return "Letter grade: B";
                }
                else if (grades <= 79 && grades >= 67)
                {
                    return "Letter grde: C";
                }
                else if (grades <= 60 && grades >= 60)
                {
                    return "Letter grade: D";
                }
                else
                {
                    return "Letter grade: F";

                    
                }

                


            } while (response.Equals("y",StringComparison.OrdinalIgnoreCase));

               
        }

           

        }
    }

