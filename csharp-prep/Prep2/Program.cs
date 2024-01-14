using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string percentage = Console.ReadLine();
        int grade = int.Parse(percentage);
        string letter = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";

        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        //Tell them if they passed
        if (grade >= 70)
        {
            Console.WriteLine($"You passed the class with a(n): {letter}");
        }
        else if (grade < 70)
        {
            Console.WriteLine($"You failed the class and got a(n) {letter}");
        }        
    }
}