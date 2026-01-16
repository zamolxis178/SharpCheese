using System;


public class Program
{
    static void Main(string[] args)
    {
        //Reverse a string
        Console.WriteLine("Enter a message: ");
        var user_name = Console.ReadLine();

        for (int i = user_name.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(user_name[i]);
        }
    }


}