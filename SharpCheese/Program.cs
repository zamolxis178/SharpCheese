using System;
using System.Collections.Generic;


public class Program
{
    static void Main(string[] args)
    {
        //Area of a Triangle
        Console.WriteLine("Give the width of triangle: ");
        float width = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Give the height of triangle: ");
        float height = Convert.ToSingle(Console.ReadLine());

        float area = AreaTriangle(width, height);
        System.Console.WriteLine($"The area of triangle is: {area}");

    }

    static float AreaTriangle(float width, float height)
    {
        
        return (width * height) / 2;
    }


}