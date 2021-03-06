﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGraphics.Util
{
    public struct Vector2
    {
        public float X;
        public float Y;

        private static Random _rand = new Random();

        public Vector2(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        public Vector2 Normalize()
        {
            float val = 1f / (float)Math.Sqrt((X * X) + (Y * Y));
            return new Vector2(X * val, Y * val);
        }

        public float Distance(Vector2 target)
        {
            return Distance(this, target);
        }

        public static Vector2 Empty
        {
            get { return new Vector2(0, 0); }
        }

        public static Vector2 Random(float minX, float maxX, float minY, float maxY)
        {
            return new Vector2(
                (float)_rand.NextDouble() * (maxX - minX) + minX,
                (float)_rand.NextDouble() * (maxY - minY) + minY);
        }
        
        public static Vector2 From(Point p)
        {
            return new Vector2(p.X, p.Y);
        }

        public static bool operator ==(Vector2 v1, Vector2 v2)
        {
            return v1.X == v2.X && v1.Y == v2.Y;
        }

        public static bool operator !=(Vector2 v1, Vector2 v2)
        {
            return v1.X != v2.X && v1.Y != v2.Y;
        }
        
        public static Vector2 operator +(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X + v2.X, v1.Y + v2.Y);
        }

        public static Vector2 operator -(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X - v2.X, v1.Y - v2.Y);
        }

        public static Vector2 operator *(Vector2 v1, float m)
        {
            return new Vector2(v1.X * m, v1.Y * m);
        }

        public static float operator *(Vector2 v1, Vector2 v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y;
        }

        public static Vector2 operator /(Vector2 v1, float m)
        {
            return new Vector2(v1.X / m, v1.Y / m);
        }

        public static float Distance(Vector2 v1, Vector2 v2)
        {
            return (float)Math.Sqrt(Math.Pow(v1.X - v2.X, 2) + Math.Pow(v1.Y - v2.Y, 2));
        }

        public float Length()
        {
            return (float)Math.Sqrt(X * X + Y * Y);
        }

        public override string ToString()
        {
            return "{ " + X + ", " + Y + " }";
        }
    }
}
