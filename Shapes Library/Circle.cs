using System;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Shapes_Library
{
    public class Circle : Shape2D
    {
        public override Vector3 Center { get; } 

        public float Radius;
        public override float Area 
        { 
            get
            {
                return (MathF.PI * MathF.Pow(Radius, 2));
            }
        }
        public override float Circumference
        {
            get
            {
                return (MathF.PI * (Radius * 2));
            }
        }

        public Circle(Vector2 center, float radius)
        {
            Center = new Vector3(center, 0.0f);
            Radius = radius;
        }

        public override string ToString()
        {
            return $"Circle @({Center.X.ToString("F1")}, {Center.Y.ToString("F1")}): R:{Radius.ToString("F1")}";
        }

    }
}
