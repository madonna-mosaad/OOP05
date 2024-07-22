using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.First
{
    internal class Point3D : IComparable, ICloneable
    {
        public double X{get;set;}
        public double Y{get;set;}
        public double Z{get;set;}
        public Point3D() { }
        public Point3D(double x ,double y)
        {
            X = x; Y = y;
        }
        public Point3D(double x, double y, double z):this(x,y)
        {
            Z = z;
        }
        public override string ToString()
        {
            return $"Point Coordinates : ({X},{Y},{Z})";
        }

        public int CompareTo(object? obj)
        {
            Point3D point3D =(Point3D) obj;
            if (this.X == point3D.X)
            {
                return this.Y.CompareTo(point3D.Y);
            }
            return this.X.CompareTo(point3D.X);



        }

        public object Clone()
        {
            return new Point3D(X,Y,Z);
        }
    }
}
