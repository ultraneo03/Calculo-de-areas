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
        /// constructor rectangle
        /// </summary>
        /// <param name="baseRectangulo"></param>
        /// <param name="altura"></param>
        public Rectangle(double baseRectangle, double height)
        {
            this.baseRectangle = baseRectangle;
            this.height = height;
        }

        /// <summary>
        /// method to calculate area  
        /// </summary>
        public override void CalculateArea()
        {
            area = baseRectangle * height;
        }

        /// <summary>
        /// method to show information related to the figure
        /// </summary>
        public override void ShowInformation()
        {
            Console.WriteLine("Rectángulo con base " + baseRectangle + " y altura " + height);
        }
        /// <summary>
        /// method to show result of area calculation process
        /// </summary>
        public override void ShowResult()
        {
            Console.WriteLine("El área del rectangulo es: " + area);
        }
        /// <summary>
        /// Method to get area result
        /// </summary>
        /// <returns>area value</returns>
        public double GetArea()
        {
            return area;
        }
    }
}
