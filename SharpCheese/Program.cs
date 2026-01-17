using System;
using System.Collections.Generic;


public class Program
{
    static void Main(string[] args)
    {
        //Odd/Even number list
        List<int> odd = new List<int>();
        List<int> even = new List<int>();

        Console.WriteLine("Give a number from 0-20");
        int user_input = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i <= user_input; i++)
        {
            if (i % 2 == 0)
            {
                even.Add(i);
            }
            else
            {
                odd.Add(i);
            }
        }

        Console.WriteLine("Even num list");
        foreach (var item in even)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();


        Console.WriteLine("Odd num list");
        foreach (var item in odd)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }


}