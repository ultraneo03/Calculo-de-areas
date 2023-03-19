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

        public override void CalculateArea()
        {
            this.area = Math.PI * Math.Pow(radio, 2);
        }

        public override void ShowInformation()
        {
            Console.WriteLine("Círculo con radio " + radio);
        }

        public override void ShowResult()
        {
            Console.WriteLine("El área del circulo es: " + this.area);
        }

        public double getArea()
        {
            return this.area;
        }
    }
}
