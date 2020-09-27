using System;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Shapes_Library
{
    public class Circle : Shape2D
    {
        public Vector2 CircleCenter;
        public float Radius;

        

        public Circle(Vector2 center, float radius)
        {
            this.CircleCenter = center;
            this.Radius = radius;
        }

        

        public override float Area => 
        public override float Circumference => throw new System.NotImplementedException();
        public override Vector3 Center => throw new System.NotImplementedException();

    }
}
