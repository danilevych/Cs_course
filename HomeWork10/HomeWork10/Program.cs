using System.Security.Cryptography;
using System;
using System.Net.NetworkInformation;

namespace HomeWork10
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1, p2, p3, p4, p0;

            p1 = new Point(1, 8);
            p2 = new Point(2, 6);
            p3 = new Point(3, 7);
            p4 = new Point(4, 7);
            p0 = new Point(0, 0);


            Triangle tr1 = new Triangle(p1, p2, p3);
            Triangle tr2 = new Triangle(p4, p2, p3);
            Triangle tr3 = new Triangle(p1, p2, p4);


            Console.WriteLine(p1.Distance(p2));

            double distance = tr1.Distance(p1, p2);
            Console.WriteLine($"Distance from p1 to p2: {distance}");

            string pointString = p1.ToString();
            Console.WriteLine(pointString);
            tr1.Print(p1, p2, p3);
            tr2.Print(p4, p2, p3);
            tr3.Print(p1, p2, p4);

            Console.WriteLine(tr1.Perimeter());

            //*
            Console.WriteLine(p0.Distance(p1));
            
        }
    }
}