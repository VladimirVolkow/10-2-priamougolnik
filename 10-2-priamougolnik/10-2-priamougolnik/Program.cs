using System;

namespace _10_2_priamougolnik
{
    class Rectangle
    {
        public double side1;
        public double side2;
        public double AreaCalculator
        {
            get { return side1 * side2; }
        }
        public double PerimeterCalculator
        {
            get { return side1 * side2 + side1 * side2; }
        }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Первая сторона прямоугольника равна:");
            string chislo1 = Console.ReadLine();
            double side1 = double.Parse(chislo1);
            Console.WriteLine("Вторая сторона прямоугольника равна:");
            string chislo2 = Console.ReadLine();
            double side2 = double.Parse(chislo2);
            Rectangle pointB = new Rectangle(side1, side2);
            Console.WriteLine("Площадь прямоугольника равна: {0} ", pointB.AreaCalculator);
            Console.WriteLine("Периметр прямоугольника равен: {0} ", pointB.PerimeterCalculator);
            Console.ReadKey();
        }
    }
}
