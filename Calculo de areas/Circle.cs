using System;
using System.Collections.Generic;
using System.Text;

namespace Calculo_de_areas
{
    public class Circle : GeometricFigure
    {
        private double radio;

        private double area;

        public Circle(double radio)
        {
            this.radio = radio;
        }

        /// <summary>
        /// method to calculate area  
        /// </summary>
        public override void CalculateArea()
        {
            this.area = Math.PI * Math.Pow(radio, 2);
        }

        /// <summary>
        /// method to show information related to the figure
        /// </summary>
        public override void ShowInformation()
        {
            Console.WriteLine("Círculo con radio " + radio);
        }

        /// <summary>
        /// method to show result of area calculation process
        /// </summary>
        public override void ShowResult()
        {
            Console.WriteLine("El área del circulo es: " + this.area);
        }
        /// <summary>
        /// Method to get area result
        /// </summary>
        /// <returns>area value</returns>
        public double GetArea()
        {
            return this.area;
        }
    }
}
