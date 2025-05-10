//Area Calculation

//Overload the Area() method for different shapes:

// Rectangle (length, breadth)

// Circle fradius)

// Triangin (base, height)

// Print the calculated areas.

using System;

class AreaCalculator
{
    static double AreaOfRectangle(double length, double breadth)
    {
        return length * breadth;
    }

    static double AreaOfCircle(double radius)
    {
        return Math.PI * radius * radius;
    }

    static double AreaOfTriangle(double baseVal, double height)
    {
        return 0.5 * baseVal * height;
    }

    static void Main()
    {
        double rectangleArea = AreaOfRectangle(5.0, 3.0);
        double circleArea = AreaOfCircle(2.5);
        double triangleArea = AreaOfTriangle(4.0, 6.0);

        Console.WriteLine("Area of Rectangle: " + rectangleArea);
        Console.WriteLine("Area of Circle: " + circleArea);
        Console.WriteLine("Area of Triangle: " + triangleArea);
    }
}
