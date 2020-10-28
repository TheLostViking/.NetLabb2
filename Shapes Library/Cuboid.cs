using System;
using System.Numerics;

namespace Shapes_Library
{
    public class Cuboid : Shape3D
    {
        public override Vector3 Center { get; }
        public Vector3 Size { get; }

        public override float Area
        {
            get
            {
                return (Size.X * Size.Y) * 2 + (Size.Y * Size.Z) * 2 + (Size.X * Size.Z) * 2;
            }
        }
        public override float Volume
        {
            get
            {
                return (Size.X * Size.Y) * Size.Z;
            }


        }
        public bool IsCube
        {
            get
            {
                if (Size.X == Size.Y && Size.Y == Size.Z)
                
                    return true;
                
                else return false;
            }
        }


        public Cuboid(Vector3 center, Vector3 size)
        {
            Center = center;
            Size = size;
        }

        public Cuboid(Vector3 center, float width)
        {
            Center = center;
            Size = new Vector3(width, width, width);
        }

        public override string ToString()
        {
            if (IsCube == false)

                return $"Cuboid @({Center.X.ToString("F1")}, {Center.Y.ToString("F1")}, {Center.Z.ToString("F1")}):" +
                       $" W = {Size.X.ToString("F1")}, H = {Size.Y.ToString("F1")}, L = {Size.Z.ToString("F1")}";

            else return $"Cube @({Center.X.ToString("F1")}, {Center.Y.ToString("F1")}, {Center.Z.ToString("F1")}):" +
                        $" W = {Size.X.ToString("F1")}, H = {Size.Y.ToString("F1")}, L = {Size.Z.ToString("F1")}";
        }
    }
}
