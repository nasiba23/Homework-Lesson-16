using System;
using System.Linq;

namespace HomeworkLesson16
{
    class Program
    {
        static void Main(string[] args)
        {
            // FirstAssignment();
            // SecondAssignment();
            ThirdAssignment();
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

        static void ThirdAssignment()
        {
            Console.Write("Enter length of the array: ");
            var length = int.Parse(Console.ReadLine());
            var arr = new string[length];
            Console.WriteLine("Enter words: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }
            arr = arr.OrderBy(p => p.Length).ToArray();
            foreach (var VARIABLE in arr)
            {
                Console.Write($"{VARIABLE}\t");
            }
        }
    }
}