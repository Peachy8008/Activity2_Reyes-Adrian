using System;

namespace February_14__2022
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade = 0; 
            int average;
            Console.WriteLine("Please Enter Student Grades");
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Enter score " + i);
                grade += Convert.ToInt32(Console.ReadLine());
            }

            average = grade / 5;

            Console.WriteLine("Average grade is " + average);
            if (average >= 75)
            {
                Console.WriteLine("Passed");
            }

            else
            {
                Console.WriteLine("Failed");
            }
        }
    }
}

