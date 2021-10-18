using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass_InterfaceDemo
{
    class Rectangle
    {
        int length;
        int width;
        float area;
        public void GetDimensions()
        {
            Console.WriteLine("Enter Value for Length");
            length = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Value for Width");
            width = Convert.ToByte(Console.ReadLine());

        }
        public void CaculateArea()
        {
            area = length * width;
        }
        public void DisplayArea()
        {
            Console.WriteLine("Area is " + area);
        }
    }
}
