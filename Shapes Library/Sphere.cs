using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Shapes_Library
{
    public class Sphere : Shape3D
    {
        public override Vector3 Center { get; }
        public override float Area
        {
            get
            {
                return 4 * MathF.PI * MathF.Pow(Radius, 2);
            }
        }
        public override float Volume
        {
            get
            {
                return (4 * MathF.PI * MathF.Pow(Radius, 3)) / 3;
            }
        }
        public float Radius;
        
        public Sphere (Vector3 center, float radius) 
        {
            Center = new Vector3(center.X, center.Y, center.Z);
            Radius = radius;
        }
        public override string ToString()
        {
            return $"Sphere @({Center.X.ToString("F1")}, {Center.Y.ToString("F1")}, {Center.Z.ToString("F1")}):" +
                   $" R = {Radius.ToString("F1")}";
        }
    }
}
