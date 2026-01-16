using System;


public class Program
{
    static void Main(string[] args)
    {
                //FizzBuzz Game
        Console.WriteLine("Enter a number: ");
        int user_input = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= user_input; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }


}