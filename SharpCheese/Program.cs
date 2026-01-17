using System;
using System.Collections.Generic;


public class Program
{
    static void Main(string[] args)
    {
        //Array of multiples
        Console.WriteLine("Give a number to start with: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Give a number for the length");
        int length = Convert.ToInt32(Console.ReadLine());
        int[] result = new int[length];

        for (int i = 1; i <= result.Length; i++)
        {
            result[i - 1] = number * i;
        }

        foreach (var item in result)
        {
            System.Console.WriteLine($"{item}");
        }

    }


}