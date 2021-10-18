using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass_InterfaceDemo
{
    class Square
    {
        int side;
        float area;
        public void GetDimensions()
        {
            Console.WriteLine("Enter Value for side");
               side = Convert.ToByte(Console.ReadLine());
        }
        public void CaculateArea()
        {
            area = side * side;
        }
        public void DisplayArea()
        {
            Console.WriteLine("Area is " + area);
        }
    }
}
