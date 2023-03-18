using System;
using System.Collections.Generic;
using System.Text;

namespace Calculo_de_areas
{
    class Rectangulo : FiguraGeometrica
    {
        private double baseRectangulo;
        private double altura;
        private double area;

        public Rectangulo(double baseRectangulo, double altura)
        {
            this.baseRectangulo = baseRectangulo;
            this.altura = altura;
        }

        public override void CalcularArea()
        {
            this.area = baseRectangulo * altura;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Rectángulo con base " + baseRectangulo + " y altura " + altura);
        }
        public override void MostrarResultado()
        {
            Console.WriteLine("El área del rectangulo es: " + this.area);
        }
    }
}
