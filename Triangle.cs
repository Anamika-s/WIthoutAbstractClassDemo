using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass_InterfaceDemo
{
    class Triangle
    {
         
            int basee;
            int height;
            double area;
            public void GetDimensions()
            {
                Console.WriteLine("Enter Value for Base");
                basee = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Enter Value for Height");
                height = Convert.ToByte(Console.ReadLine());

            }
            public void CaculateArea()
            {
                area = .5 * (double)basee * (double)height;
            }
            public void DisplayArea()
            {
                Console.WriteLine("Area is " + area);
            }
        }
}
