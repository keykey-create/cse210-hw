using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int usernumber = -1;
        while (usernumber != 0 )
        {
            Console.Write("Enter a list of numbers and type 0 when done: ");
            usernumber = int.Parse(Console.ReadLine());

            if (usernumber != 0)
            {
                numbers.Add(usernumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
         {
            sum = sum + number;
         }
        
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"THe average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The greatest number is {max}");

        int min = 999999999;
        foreach (int number in numbers)
        {
            if (number < min)
            {
                min = number;
            }
        }

        Console.WriteLine($"The smallest number is {min}");
    }
}