﻿using System;

namespace Class_Object
{
    class Shapes
    {
        public double length;
        public double width;
        public double radius;

        public double CalArea(double l, double w)
        {
            length = l;
            width = w;
            double Area = w * l;
            return Area;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double RecWidth = 7;
            double RecLength = 8;
            double SqWidth = 2;
            double radius = 3;


            Shapes Rectangle = new Shapes();
            Shapes Square = new Shapes();
            Shapes Circle = new Shapes();

            Console.WriteLine("Area of Rectangle is: " + Rectangle.CalArea(RecLength, RecWidth));

            Console.WriteLine("Area of Square is: " + Square.CalArea(SqWidth, SqWidth));

            Console.WriteLine("Are of Square is: " + Math.PI * radius * radius);
        }


    }
}
