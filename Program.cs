using System;
using System.Linq;

namespace HomeworkLesson16
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstAssignment();
        }

        static void FirstAssignment()
        {
            Console.Write("Enter number for the 1st assignment: ");
            var s = Console.ReadLine();
            var result = s.ToCharArray().Reverse().ToArray();
            Console.WriteLine("Reversed number: ");
            foreach (var VARIABLE in result)
            {
                Console.Write(VARIABLE);
            }
        }

        static void SecondAssignment()
        {
            
        }
    }
}