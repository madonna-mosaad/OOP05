﻿using OOP05.First;
using OOP05.second;
using OOP05.Third;

namespace OOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First
            #region 2
            //Point3D P = new Point3D(10, 10, 10);
            //Console.WriteLine(P?.ToString()?? string.Empty);
            #endregion
            //#region 3
            //Point3D P1 = new Point3D();
            //Point3D P2 = new Point3D();
            //double x1, y1, z1, x2, y2, z2;

            //do
            //{
            //    Console.Write("Enter x of the first point :");
            //} while (!double.TryParse(Console.ReadLine(), out x1));

            //do
            //{
            //    Console.Write("Enter y of the first point :");
            //} while (!double.TryParse(Console.ReadLine(), out y1));

            //do
            //{
            //    Console.Write("Enter z of the first point :");
            //} while (!double.TryParse(Console.ReadLine(), out z1));

            //do
            //{
            //    Console.Write("Enter x of the second point :");
            //} while (!double.TryParse(Console.ReadLine(), out x2));

            //do
            //{
            //    Console.Write("Enter y of the second point :");
            //} while (!double.TryParse(Console.ReadLine(), out y2));

            //do
            //{
            //    Console.Write("Enter z of the second point :");
            //} while (!double.TryParse(Console.ReadLine(), out z2));

            //P1.X = x1;
            //P1.Y = y1;
            //P1.Z = z1;
            //P2.X = x2;
            //P2.Y = y2;
            //P2.Z = z2;
            //Console.WriteLine(P1);
            //Console.WriteLine(P2);
            //#endregion
            //#region 4
            //if (P1 == P2)//it doesn't work properly
            //{
            //    Console.WriteLine(true);
            //}
            //else 
            //{ 
            //    Console.WriteLine(false); 
            //}
            //#endregion
            //#region 5
            //Point3D[] Arr = { P1 , P2 };
            //Array.Sort(Arr);
            //foreach (var point in Arr)
            //{
            //    Console.WriteLine($"X: {point.X}, Y: {point.Y}");
            //}
            //#endregion
            //#region 6
            //P2 = (Point3D)P1.Clone();
            //P1.X = 0;
            //Console.WriteLine(P2.X);
            //#endregion
            #endregion
            #region second
            //Console.WriteLine( Maths.Add(1, 1));
            //Console.WriteLine(Maths.Subtract(6,3));
            //Console.WriteLine(Maths.Multiply(7,8));
            //Console.WriteLine(Maths.Divide(7,2));
            #endregion
            #region Third
            #region 3
            //Duration D = new Duration(1, 10, 15);
            //Console.WriteLine(D.ToString());

            //Duration D1 = new Duration(3600);
            //Console.WriteLine(D1.ToString());

            //Duration D2 = new Duration(7800);
            //Console.WriteLine(D2.ToString());

            //Duration D3 = new Duration(666);
            //Console.WriteLine(D3.ToString());

            #endregion
            #region 4
            //Duration D3;
            //Duration D1 = new Duration(3600);
            //Duration D2 = new Duration(7800);

            //D3 = D1 + D2;
            //D3 = D1 + 7800;
            //D3 = 666 + D3;
            //D3 = ++D1;
            //D3 = --D2;
            //D1 = D1 - D2;
            //if (D1 > D2) { Console.WriteLine(">"); }
            //if (D1 <= D2) { Console.WriteLine("<="); }
            //if (D1) { Console.WriteLine("D1"); }
            //DateTime Obj = (DateTime)D1;
            //Console.WriteLine(Obj.ToString()); 
            #endregion


            #endregion
            
        }
    }
}
