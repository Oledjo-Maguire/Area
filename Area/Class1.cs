using System;

namespace Area
{
    // Абстрактный класс Shape (фигура)
    public abstract class Shape
    {
        // Абстрактный метод расчета площади фигуры
        public abstract double CalculateArea();
    }

    // Класс Circle (круг)
    public class Circle : Shape
    {
        // Радиус круга
        public double Radius { get; set; }

        // Реализация метода расчета площади круга
        public override double CalculateArea()
        {
            if (Radius < 0)
            {
                throw new ArgumentException("Радиус круга не может быть отрицательным.");
            }

            return Math.PI * Radius * Radius;
        }
    }

    // Класс Triangle (треугольник)
    public class Triangle : Shape
    {
        // Длины сторон треугольника
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        // Реализация метода расчета площади треугольника
        public override double CalculateArea()
        {
            if (SideA < 0 || SideB < 0 || SideC < 0)
            {
                throw new ArgumentException("Длины сторон треугольника не могут быть отрицательными.");
            }

            // Проверка валидности треугольника
            if (!IsValid())
            {
                throw new ArgumentException("Треугольник с заданными сторонами не существует.");
            }

            // Вычисление полупериметра треугольника
            double s = (SideA + SideB + SideC) / 2;

            // Проверка прямоугольности треугольника
            if (IsRightAngled())
            {
                Console.WriteLine("Треугольник является прямоугольным.");
            }

            // Вычисление площади треугольника по формуле Герона
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        // Проверка валидности треугольника
        private bool IsValid()
        {
            return (SideA + SideB > SideC) && (SideA + SideC > SideB) && (SideB + SideC > SideA);
        }

        // Проверка прямоугольности треугольника
        private bool IsRightAngled()
        {
            return SideA * SideA == SideB * SideB + SideC * SideC || SideB * SideB == SideA * SideA + SideC * SideC || SideC * SideC == SideA * SideA + SideB * SideB;
        }
    }
}
