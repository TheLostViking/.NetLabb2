using System;
using System.Numerics;

namespace Shapes_Library
{
    public class Rectangle : Shape2D
    {
        public override Vector3 Center { get; }

        public Vector2 Size;
        
        public override float Circumference
        {
            get
            {
                return (Size.X) * 2 +  (Size.Y) * 2;
            }
        }
        public override float Area
        {
            get
            {
                return (Size.X) * (Size.Y);
            }
        }

        public bool IsSquare
        {
            get
            {
                if (Size.X != Size.Y)
                
                return false;
                else return true;
            }
        }

        public Rectangle(Vector2 center, Vector2 size)
        {
            Center = new Vector3(center, 0.0f);
            Size = size;
        }
        public Rectangle(Vector2 center, float width)
        {
            Center = new Vector3(center, 0.0f);
            Size.X = width;
            Size.Y = width;
        }
        public override string ToString()
        {
            if (IsSquare == false)
            
                return $"Rectangle @({Center.X.ToString("F1")}, {Center.Y.ToString("F1")}): W:{Size.X.ToString("F1")}, H:{Size.Y.ToString("F1")}";
                else return $"Square @({Center.X.ToString("F1")}, {Center.Y.ToString("F1")}): W:{Size.X.ToString("F1")}, {Size.Y.ToString("F1")}";
        }
    }
}
