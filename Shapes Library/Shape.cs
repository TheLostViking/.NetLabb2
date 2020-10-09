using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Shapes_Library
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

        public static Shape GenerateShape()
        {
            Random RShape = new Random();
            int shape = RShape.Next(0, 7);
            Random posX = new Random();
            Random posY = new Random();
            Random posZ = new Random();
            Random rnd = new Random();

            switch (shape)
            {
                case 0:
                    return new Circle(
                           new Vector2((float)posX.NextDouble() * 10, (float)posY.NextDouble() * 10), (float)rnd.NextDouble() * 10);

                case 1:
                    return new Rectangle(
                           new Vector2((float)posX.NextDouble() * 10, (float)posY.NextDouble() * 10),
                           new Vector2((float)posX.NextDouble() * 10, (float)posY.NextDouble() * 10));

                case 2:
                    return new Rectangle(
                           new Vector2((float)posX.NextDouble() * 10, (float)posY.NextDouble() * 10), new Vector2(6.0f, 6.0f));

                case 3:
                    return new Triangle(
                           new Vector2((float)posX.NextDouble() * 10, (float)posY.NextDouble() * 10),
                           new Vector2((float)posX.NextDouble() * 10, (float)posY.NextDouble() * 10),
                           new Vector2((float)posX.NextDouble() * 10, (float)posY.NextDouble() * 10));

                case 4:
                    return new Cuboid(
                           new Vector3((float)posX.NextDouble() * 10, (float)posY.NextDouble() * 10, (float)posZ.NextDouble() * 10), 
                           new Vector3((float)posX.NextDouble() * 10, (float)posY.NextDouble() * 10, (float)posZ.NextDouble() * 10));

                case 5:
                    return new Cuboid(
                           new Vector3((float)posX.NextDouble() * 10, (float)posY.NextDouble() * 10, (float)posZ.NextDouble() * 10), 6.0f);

                case 6:
                    return new Sphere(
                           new Vector3((float)posX.NextDouble() * 10, (float)posY.NextDouble() * 10, (float)posZ.NextDouble() * 10), (float)rnd.NextDouble() * 10);

                default: return null;
            }

        }

        public static Shape GenerateShape(Vector3 center3D)
        {
            Random Rshape = new Random();
            int shape = Rshape.Next(0, 7); ;
            Random posX = new Random();
            Random posY = new Random();
            Random rndF = new Random();
            Vector2 center2D = new Vector2(center3D.X, center3D.Y);
            Vector2 P1 = new Vector2((float)posX.NextDouble() * 10, (float)posY.NextDouble() * 10);
            Vector2 P2 = new Vector2((float)posX.NextDouble() * 10, (float)posY.NextDouble() * 10);
            

            switch (shape)
            {
                case 0:
                    return new Circle(center2D, (float)rndF.NextDouble() * 10);
                case 1:
                    return new Rectangle(center2D, (float)rndF.NextDouble() * 10);

                case 2:
                    return new Rectangle(center2D, new Vector2(6.0f, 6.0f));

                case 3:
                    return new Triangle(P1, P2, new Vector2(TriX(center2D, P1, P2), TriY(center2D, P1, P2)));

                case 4:
                    return new Cuboid(center3D, (float)rndF.NextDouble() * 10);

                case 5:
                    return new Cuboid(center3D, new Vector3(new Vector2(6.0f, 6.0f), 6.0f));

                case 6:
                    return new Sphere(center3D, (float)rndF.NextDouble() * 10);

                default: return null;
            }

            static float TriX(Vector2 center2D, Vector2 P1, Vector2 P2)
            {
                return (3 * center2D.X) - P1.X - P2.X;
            }
            static float TriY(Vector2 center2D, Vector2 P1, Vector2 P2)
            {
                return (3 * center2D.Y) - P1.Y - P2.Y;
            }
        }

       

    }
}




