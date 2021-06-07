﻿using System;
namespace GeometryExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var cylinder = new Cylinder();
            Console.WriteLine(" Nhan Kich Thuoc Cua Hinh Tru");
            while (true)
            {
                try
                {
                    Console.Write("Radius: ");
                    cylinder.Radius = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Height: ");
                    cylinder.Height = Convert.ToDouble(Console.ReadLine());
                    cylinder.Process();
                    Console.WriteLine(cylinder.Result());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}