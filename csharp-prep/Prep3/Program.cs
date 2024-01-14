using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        
        
        //find a random number
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        //display the "pre" guess
        int Myguess = -100;

        

        //use if statements to find out if the guess is correct

        while (Myguess != number)
        {   Console.WriteLine("Pick a number between 1 and 100");
            Myguess = int.Parse(Console.ReadLine());
            if (Myguess > number)
            {
                Console.WriteLine("Lower");

            }
            else if (Myguess < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine($"You got it! the number was {number}");   
            }
        }
    }
}