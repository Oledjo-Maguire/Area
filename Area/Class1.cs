using System;

namespace Area
{
 
    public abstract class Shape
    {
        public abstract double CalculateArea();
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public override double CalculateArea()
        {
            double s = (SideA + SideB + SideC) / 2;
            if (SideA * SideA == SideB * SideB + SideC * SideC || SideB * SideB == SideA * SideA + SideC * SideC || SideC * SideC == SideA * SideA + SideB * SideB)
            {
                Console.WriteLine("Треугольник прямоугольный.");
            }
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }
    }
}
//Использовал для проверки работоспособности
/*Shape shape = new Circle() { Radius = 5 }; // или new Triangle() { SideA = 3, SideB = 4, SideC = 5 };
double area = shape.CalculateArea();
Console.WriteLine(area);*/