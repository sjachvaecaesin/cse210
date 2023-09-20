using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> nums = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        string input;
        int x = -1;

        while (x != 0)
        {
            Console.Write("Enter number: ");
            input = Console.ReadLine();
            x = int.Parse(input);
            if (x != 0)
            {
                nums.Add(x);
            }
        }

        int sum = 0;
        float average = 0;
        foreach (int num in nums)
        {
            sum += num;
        }

        average = ((float)sum) / nums.Count();

        int largest = 0;
        foreach (int num in nums)
        {
            if (num > largest)
            {
                largest = num;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}