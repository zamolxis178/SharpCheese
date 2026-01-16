using System;


public class Program
{
    static void Main(string[] args)
    {
        //Times Table
        // Ask the user for a number
        // Make a multiplication table for that number
        Console.WriteLine("Enter a number: ");
        int user_input = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(user_input + " x " + i + " = " + (i * user_input));
        }
    }


}