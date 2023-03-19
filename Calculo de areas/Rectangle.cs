using System;
using System.Collections.Generic;
using System.Text;

namespace Calculo_de_areas
{
    public class Rectangle : GeometricFigure
    {
        /// <summary>
        /// base lenght rectangle
        /// </summary>
        private double baseRectangle;

        /// <summary>
        /// height rectangle
        /// </summary>
        private double height;

        /// <summary>
        /// area of rectangle
        /// </summary>
        private double area;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseRectangulo"></param>
        /// <param name="altura"></param>
        public Rectangle(double baseRectangle, double height)
        {
            this.baseRectangle = baseRectangle;
            this.height = height;
        }

        public override void CalculateArea()
        {
            area = baseRectangle * height;
        }

        public override void ShowInformation()
        {
            Console.WriteLine("Rectángulo con base " + baseRectangle + " y altura " + height);
        }
        public override void ShowResult()
        {
            Console.WriteLine("El área del rectangulo es: " + area);
        }
        public double getArea()
        {
            return area;
        }
    }
}
