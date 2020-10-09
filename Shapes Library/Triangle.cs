using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace Shapes_Library
{

    public class Triangle : Shape2D, IEnumerable
    {

        public Vector2 P1, P2, P3;
        public Vector2[] TriCorners = new Vector2[3];



        public override float Circumference
        {
            get
            {
                return (Vector2.Distance(P1, P2) + Vector2.Distance(P2, P3) + Vector2.Distance(P3, P1));
            }

        }

        public override Vector3 Center
        {
            get
            {
                return new Vector3(TriCenterX(), TriCenterY(), 0.0f);
            }
        }

        public override float Area
        {
            get
            {
                return MathF.Round(P1.X * (P2.Y - P3.Y) + P2.X * (P3.Y - P1.Y) + P3.X * (P1.Y - P2.Y), 2) / 2;
            }

        }



        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            TriCorners[0] = p1;
            TriCorners[1] = p2;
            TriCorners[2] = p3;
            P1 = p1;
            P2 = p2;
            P3 = p3;
        }
        private float TriCenterX()
        {
            return (P1.X + P2.X + P3.X) / 3;

        }
        private float TriCenterY()
        {
            return (P1.Y + P2.Y + P3.Y) / 3;
        }
        public override string ToString()
        {
            return $"Triangle @({TriCenterX().ToString("F1")}, {TriCenterY().ToString("F1")}):" +
                   $" P1 = ({P1.X.ToString("F1")}, {P1.Y.ToString("F1")})," +
                   $" P2 = ({P2.X.ToString("F1")}, {P2.Y.ToString("F1")})," +
                   $" P3 = ({P3.X.ToString("F1")}, {P3.Y.ToString("F1")})";
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public TriEnumerator GetEnumerator()
        {
            return new TriEnumerator(TriCorners);
        }

        public class TriEnumerator : IEnumerator
        {
            Vector2[] TriCorner;
            int position = -1;
            public TriEnumerator(Vector2[] tricorner)
            {
                TriCorner = tricorner;
            }
            public bool MoveNext()
            {
                position++;
                return (position < TriCorner.Length);
            }

            public void Reset()
            {
                position = -1;
            }
            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }

            }

            public Vector2 Current
            {
                get
                {
                    try
                    {
                        return TriCorner[position];
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }


            }
        }
    }
}
