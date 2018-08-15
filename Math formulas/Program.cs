using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_formulas
{
    class Program
    {
        static void Main(string[] args)

            //Code for circumference, area of a circle, and colume of a hemisphere (Line 15 - 29)
        {
            Console.WriteLine("What is your Radius?");            

            Double radius = Double.Parse(Console.ReadLine());  

            Console.WriteLine("The circumference of the circle is "+(2 * Math.PI) * radius);

            Console.WriteLine();

            Console.WriteLine("The Area of the circle is " + Math.PI * (radius* radius));

            Console.WriteLine();

            Console.WriteLine("The Volume of the hemisphere is " + (1.33333 * Math.PI* (radius * radius * radius)/2));

            Console.WriteLine();


            //Code for Area of a Triangle (Line 35 - 51)


            Console.WriteLine("What is the first side of your triangle?");

                Double side1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("What is the second side of your triangle?");

                Double side2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("What is the third side of your triangle?");

                Double side3 = Double.Parse(Console.ReadLine());

                Double perimeter = ((side1 + side2 + side3) / 2);

            Console.WriteLine("The area of the triangle is " + (Math.Sqrt(perimeter * (perimeter - side1) * (perimeter - side2) * (perimeter - side3))));

            Console.WriteLine();


            //Code for Quadratic Equation (Line 56 - 80) cannot calculate coefficients that result in a negative

            Console.WriteLine("What is the quadratic value of A ?");

                Double aValue = Double.Parse(Console.ReadLine());

            Console.WriteLine("What is the quadratic value of B ?");

                Double bValue = Double.Parse(Console.ReadLine());

            Console.WriteLine("What is the quadratic value of C ?");

                Double cValue = Double.Parse(Console.ReadLine());

            Double xValue = Math.Sqrt((bValue * bValue) - (4 * aValue * cValue));

            Double yValue = (-1 * bValue + xValue) / (2 * aValue);

            Double zValue = (-1 * bValue - xValue) / (2 * aValue);

            Console.WriteLine("The first value of X is "+ yValue);

            Console.ReadLine();

            Console.WriteLine("The second value of X is " +zValue);

            Console.ReadLine();
        }
        }
        }        
