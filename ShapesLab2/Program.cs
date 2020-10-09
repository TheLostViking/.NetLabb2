using Shapes_Library;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;

namespace ShapesLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo punkt = new CultureInfo("us");
            CultureInfo.DefaultThreadCurrentCulture = punkt;

            //Exempel på input till triangel för att skriva ut dess punkter.
            int tripoint = 1;
            Triangle t = new Triangle(Vector2.Zero, Vector2.One, new Vector2(2.0f, .5f));
            Console.WriteLine("The three points for The Triangle: \n");
            foreach (Vector2 v in t)
            {
                Console.WriteLine($" Point {tripoint}: {v}");
                tripoint++;
            }

            Console.WriteLine("\n");
            Console.WriteLine("-------");
            Console.WriteLine("\n");

            //För centerpunkt
            Vector3 center = new Vector3(4.0f, 8.0f, 3.0f);

            int s = 0;
            float triSum = 0;
            float avgAreaOfShape = 0;
            float maxVolume = 0;
            float shape3DIndex = 0;
            List<Shape> shapes = new List<Shape>();
            do
            {
                shapes.Add(Shape.GenerateShape());
                s++;

            } while (s < 20);

            Console.WriteLine("The list contains the following shapes: \n");
            foreach (var shape in shapes)
            {
                Console.WriteLine($"{shape}\n");
                if (shape is Triangle)
                {
                    triSum += (shape as Triangle).Circumference;
                }

                avgAreaOfShape += (shape as Shape).Area / 20;

                if (shape is Shape3D)
                {
                    if (maxVolume <= (shape as Shape3D).Volume)
                    {
                        maxVolume = (shape as Shape3D).Volume;
                    }
                }

                for (int i = 0; i < shapes.Count; i++)
                {
                    if ((shapes[i] as Shape3D)?.Volume == maxVolume)
                    {
                        shape3DIndex = i;
                    }
                }

            }
            Console.WriteLine($"The circumference of all Triangles = {triSum.ToString("F1")}");
            Console.WriteLine($"Average Area of all Shapes = {avgAreaOfShape.ToString("F1")}");
            Console.WriteLine($"The largest volume of all 3Dshapes is at index {shape3DIndex}, at the value of {maxVolume.ToString("F1")}!");

            Console.ReadKey(true);
        }
    }
}
