using System;
using System.Linq;

namespace HomeworkLesson16
{
    class Program
    {
        static void Main(string[] args)
        {
            // FirstAssignment();
            SecondAssignment();
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
            Console.Write("Enter length of the array: ");
            var length = int.Parse(Console.ReadLine());
            var arr = new int[length];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter number: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            var numberOfPositiveNums = arr.Count(p => p > 0);
            var sumOfNegativeNums = arr.Where(n => n < 0).Sum(n => n);
            var newArr = new int[] {numberOfPositiveNums, sumOfNegativeNums};
            foreach (var i in newArr)
            {
                Console.Write($"{i}, ");
            }
        }
    }
}