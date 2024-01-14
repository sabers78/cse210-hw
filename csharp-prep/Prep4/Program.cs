using System;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        

        int listNumber = -100;
        while (listNumber != 0 )
        {   
            Console.WriteLine("Please add a number");
            
            string input = Console.ReadLine();
            listNumber = int.Parse(input);

            if (listNumber != 0)
            {
                numbers.Add(listNumber);
            }
            


        }

        int sum = 0;
        foreach (int total in numbers)
        {
            sum += total;
        }

        Console.WriteLine($"The sum is {sum}");

        int average = sum / numbers.Count;

        Console.WriteLine($"The average is {average}");

        int max = numbers[0];

        foreach (int maximum in numbers)
        {
            if (maximum > max)
            {
                max = maximum;
            }
        }
        Console.WriteLine($"The largest number is {max}");
    }   
}